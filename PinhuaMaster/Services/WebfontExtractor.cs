using Microsoft.Extensions.FileProviders;
using PinhuaMaster.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Services
{
    public class WebfontExtractor : IWebfontExtractor
    {
        public WebfontExtractor(ApplicationDbContext dbContext, IFileProvider fileProvider)
        {
            _dbContext = dbContext;
            _fileProvider = fileProvider;
        }

        public ApplicationDbContext _dbContext { get; set; }
        public IFileProvider _fileProvider { get; set; }

        public void ExtractFontawesome()
        {
            var path_fontawesome = _fileProvider.GetFileInfo("wwwroot/lib/font-awesome/css/font-awesome.css");
            var regex_fontawesome = @"(?<=\.)fa-.*(?=:before\s*\{)";
            using (var stream = path_fontawesome.CreateReadStream())
            {
                using (var reader = new System.IO.StreamReader(stream))
                {
                    var output = reader.ReadToEnd();
                    var strArray = new List<string>();
                    var results = System.Text.RegularExpressions.Regex.Matches(output, regex_fontawesome).ToList();
                    results.ForEach(result => {
                        strArray.Add(result.Value);
                        _dbContext.Icons.Add(new Icon
                        {
                            Name = result.Value,
                            ClassName = "fa " + result.Value,
                            SourceType = SourceTypes.Fontawesome

                        });
                    });
                    _dbContext.SaveChanges();
                }
            }
        }

        public void ExtractGlyphicon()
        {
            var path_glyphicon = _fileProvider.GetFileInfo("wwwroot/lib/bootstrap/dist/css/bootstrap.css");
            var regex_glyphicon = @"glyphicon-.*(?=:before\s*\{)";
            using (var stream = path_glyphicon.CreateReadStream())
            {
                using (var reader = new System.IO.StreamReader(stream))
                {
                    var output = reader.ReadToEnd();
                    var strArray = new List<string>();
                    var results = System.Text.RegularExpressions.Regex.Matches(output, regex_glyphicon).ToList();
                    results.ForEach(result => {
                        strArray.Add(result.Value);
                        _dbContext.Icons.Add(new Icon
                        {
                            Name = result.Value,
                            ClassName = "glyphicon " + result.Value,
                            SourceType = SourceTypes.Fontawesome

                        });
                    });
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
