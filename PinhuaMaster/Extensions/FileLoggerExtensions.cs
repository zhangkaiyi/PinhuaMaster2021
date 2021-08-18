using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PinhuaMaster.Extensions
{
    public static class FileLoggerExtensions
    {
        //add 日志文件创建规则，分割规则，格式化规则，过滤规则 to appsettings.json
        public static ILoggerFactory AddFile(this ILoggerFactory factory, IConfiguration configuration)
        {
            return AddFile(factory, new FileLoggerSettings(configuration));
        }
        public static ILoggerFactory AddFile(this ILoggerFactory factory, FileLoggerSettings fileLoggerSettings)
        {
            factory.AddProvider(new FileLoggerProvider(fileLoggerSettings));
            return factory;
        }
    }

    public class FileLoggerProvider : ILoggerProvider, IDisposable
    {
        FileLoggerSettings _configuration;
        readonly ConcurrentDictionary<string, InitLoggerModel> _loggerKeys = new ConcurrentDictionary<string, InitLoggerModel>();
        readonly ConcurrentDictionary<string, FileLogger> _loggers = new ConcurrentDictionary<string, FileLogger>();

        public FileLoggerProvider(FileLoggerSettings configuration)
        {
            _configuration = configuration;
            _configuration.ChangeToken.RegisterChangeCallback(p =>
            {
                //appsettings.json changed. reload settings.
                _configuration.Reload();

                //update loggers settings form new settings
                foreach (var item in this._loggers.Values)
                {
                    InitLoggerModel model = new InitLoggerModel();
                    InitLoggerSettings(item.Name, model);
                    InitLogger(model, item);
                }

            }, null);
        }
        public ILogger CreateLogger(string categoryName)
        {
            var loggerKey = this._loggerKeys.GetOrAdd(categoryName, p =>
            {
                InitLoggerModel model = new InitLoggerModel();
                InitLoggerSettings(categoryName, model);
                return model;
            });
            var key = loggerKey.FileDiretoryPath + loggerKey.FileNameTemplate;
            return this._loggers.GetOrAdd(key, p =>
            {
                var logger = new FileLogger(categoryName);
                InitLogger(loggerKey, logger);
                return logger;
            });
        }

        private static void InitLogger(InitLoggerModel model, FileLogger logger)
        {
            logger.FileNameTemplate = model.FileNameTemplate;
            logger.FileDiretoryPath = model.FileDiretoryPath;
            logger.MinLevel = model.MinLevel;
        }

        class InitLoggerModel
        {
            public LogLevel MinLevel { get; set; }
            public string FileDiretoryPath { get; set; }
            public string FileNameTemplate { get; set; }

            public override int GetHashCode()
            {
                return this.MinLevel.GetHashCode() + this.FileDiretoryPath.GetHashCode() + this.FileNameTemplate.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                var b = obj as InitLoggerModel;
                if (b == null)
                    return false;
                return this.MinLevel == b.MinLevel && this.FileDiretoryPath == b.FileDiretoryPath && this.FileNameTemplate == b.FileNameTemplate;
            }

        }
        private void InitLoggerSettings(string categoryName, InitLoggerModel model)
        {
            model.MinLevel = LogLevel.Debug;
            var keys = this.GetKeys(categoryName);
            foreach (var item in keys)
            {
                var switchV = _configuration.GetSwitch(item);
                if (switchV.Item1)
                {
                    model.MinLevel = switchV.Item2;
                    break;
                }
            }
            model.FileDiretoryPath = this._configuration.DefaultPath;
            foreach (var item in keys)
            {
                var switchV = _configuration.GetDiretoryPath(item);
                if (switchV.Item1)
                {
                    model.FileDiretoryPath = switchV.Item2;
                    break;
                }
            }
            model.FileNameTemplate = this._configuration.DefaultFileName;
            foreach (var item in keys)
            {
                var switchV = _configuration.GetFileName(item);
                if (switchV.Item1)
                {
                    model.FileNameTemplate = switchV.Item2;
                    break;
                }
            }
        }

        IEnumerable<string> GetKeys(string categoryName)
        {
            while (!String.IsNullOrEmpty(categoryName))
            {
                // a.b.c
                //--result
                // a.b.c，a.b，a，Default
                yield return categoryName;
                var last = categoryName.LastIndexOf('.');
                if (last <= 0)
                {
                    yield return "Default";
                    yield break;
                }
                System.Diagnostics.Debug.WriteLine(categoryName + "--" + last);
                categoryName = categoryName.Substring(0, last);
            }
            yield break;

        }
        public void Dispose()
        {
        }
    }

    public class FileLogger : ILogger
    {
        static protected string delimiter = new string(new char[] { (char)1 });
        public FileLogger(string categoryName)
        {
            this.Name = categoryName;
        }
        class Disposable : IDisposable
        {
            public void Dispose()
            {
            }
        }
        Disposable _DisposableInstance = new Disposable();
        public IDisposable BeginScope<TState>(TState state)
        {
            return _DisposableInstance;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return this.MinLevel <= logLevel;
        }
        public void Reload()
        {
            _Expires = true;
        }

        public string Name { get; private set; }

        public LogLevel MinLevel { get; set; }
        public string FileDiretoryPath { get; set; }
        public string FileNameTemplate { get; set; }
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!this.IsEnabled(logLevel))
                return;
            var msg = formatter(state, exception);
            this.Write(logLevel, eventId, msg, exception);
        }
        void Write(LogLevel logLevel, EventId eventId, string message, Exception ex)
        {
            EnsureInitFile();

            //TODO 提高效率 队列写！！！
            var log = String.Concat(DateTime.Now.ToString("HH:mm:ss"), '[', logLevel.ToString(), ']', '[',
                  Thread.CurrentThread.ManagedThreadId.ToString(), ',', eventId.Id.ToString(), ',', eventId.Name, ']',
                  delimiter, message, delimiter, ex?.ToString());
            lock (this)
            {
                this._sw.WriteLine(log);
            }
        }

        bool _Expires = true;
        string _FileName;
        protected StreamWriter _sw;
        void EnsureInitFile()
        {
            if (CheckNeedCreateNewFile())
            {
                lock (this)
                {
                    if (CheckNeedCreateNewFile())
                    {
                        InitFile();
                        _Expires = false;
                    }
                }
            }
        }
        bool CheckNeedCreateNewFile()
        {
            if (_Expires)
            {
                return true;
            }
            //TODO 使用 RollingType判断是否需要创建文件。提高效率！！！
            if (_FileName != DateTime.Now.ToString(this.FileNameTemplate))
            {
                return true;
            }
            return false;
        }
        void InitFile()
        {
            if (!Directory.Exists(this.FileDiretoryPath))
            {
                Directory.CreateDirectory(this.FileDiretoryPath);
            }
            var path = "";
            int i = 0;
            do
            {
                _FileName = DateTime.Now.ToString(this.FileNameTemplate);
                path = Path.Combine(this.FileDiretoryPath, _FileName + "_" + i + ".log");
                i++;
            } while (System.IO.File.Exists(path));
            var oldsw = _sw;
            _sw = new StreamWriter(new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read), Encoding.UTF8);
            _sw.AutoFlush = true;
            if (oldsw != null)
            {
                try
                {
                    _sw.Flush();
                    _sw.Dispose();
                }
                catch
                {
                }
            }
        }
    }
    public class FileLoggerSettings
    {
        IConfiguration _configuration;
        public IChangeToken ChangeToken { get; private set; }
        public FileLoggerSettings(IConfiguration configuration)
        {
            _configuration = configuration;
            this.ChangeToken = _configuration.GetReloadToken();
        }

        public string DefaultPath
        {
            get
            {
                return this._configuration["DefaultPath"];
            }
        }

        public int DefaultMaxMB
        {
            get
            {
                return int.Parse(this._configuration["DefaultMaxMB"]);
            }
        }
        public string DefaultFileName
        {
            get { return this._configuration["DefaultFileName"]; }
        }

        public void Reload()
        {
            //update cache settings
        }

        public Tuple<bool, LogLevel> GetSwitch(string name)
        {
            var section = this._configuration.GetSection("LogLevel");
            if (section != null)
            {
                LogLevel level;
                if (Enum.TryParse(section[name], true, out level))
                    return new Tuple<bool, LogLevel>(true, level);
            }
            return new Tuple<bool, LogLevel>(false, LogLevel.None);
        }
        public Tuple<bool, string> GetDiretoryPath(string name)
        {
            var section = this._configuration.GetSection("Path");
            if (section != null)
            {
                var path = section[name];
                if (!String.IsNullOrEmpty(path))
                {
                    return new Tuple<bool, string>(true, path);
                }
            }
            return new Tuple<bool, string>(false, this.DefaultPath);
        }
        public Tuple<bool, string> GetFileName(string name)
        {
            var section = this._configuration.GetSection("FileName");
            if (section != null)
            {
                var path = section[name];
                if (!String.IsNullOrEmpty(path))
                {
                    return new Tuple<bool, string>(true, path);
                }
            }
            return new Tuple<bool, string>(false, this.DefaultFileName);
        }
    }
}
