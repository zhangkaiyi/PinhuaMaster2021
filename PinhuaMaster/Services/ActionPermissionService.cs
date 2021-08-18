using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster;
using PinhuaMaster.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace PinhuaMaster.Services
{
    public class ActionPermissionService : IActionPermissionService
    {
        public ActionPermissionService(IActionDescriptorCollectionProvider actionCollection)
        {
            _actionCollection = actionCollection;
        }

        public IActionDescriptorCollectionProvider _actionCollection { get; set; }

        /// <summary>
        /// 使用反射，获取Action的信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationPermission> GetAllActionByAssembly_01()
        {
            var result = new List<ApplicationPermission>();
            //取程序集中的全部类型
            var types = Assembly.Load("PHDS.Web").GetTypes();

            foreach (var type in types)
            {
                if (type.BaseType.Name == "BaseController")//如果是BaseController                
                {
                    //取类型的方法，类型为实例方法，公共方法
                    var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
                    foreach (var method in methods)
                    {
                        //因存在异步与同步方法，所以统一用返回类型的tostring方法
                        var returnType = method.ReturnType.ToString();

                        if (returnType.Contains("ActionResult"))//如果是ActionResult
                        {
                            var ap = new ApplicationPermission()
                            {
                                Action = method.Name,
                                Controller = method.DeclaringType.Name.Substring(0, method.DeclaringType.Name.Length - 10), /* 去掉“Controller”后缀*/
                                Params = FormatParams(method)
                            };
                            //取Action的描述
                            var attrs = method.GetCustomAttributes(typeof(DescriptionAttribute), true);
                            if (attrs.Length > 0)
                                ap.Description = (attrs[0] as DescriptionAttribute).Description;

                            result.Add(ap);
                        }
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 使用Descriptor,取程序集中所有Action的元数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationPermission> GetAllPermissions()
        {
            var result = new List<ApplicationPermission>();
            //取程序集中的全部类型
            foreach (var action in _actionCollection.ActionDescriptors.Items)
            {
                var pageAction = action as Microsoft.AspNetCore.Mvc.RazorPages.PageActionDescriptor;
                if (pageAction != null)
                    result.Add(new ApplicationPermission
                    {
                        Action = pageAction.RelativePath,
                        Page = pageAction.RouteValues["Page"],
                        //Description = GetDescription((action as CompiledPageActionDescriptor).ModelTypeInfo.CustomAttributes)
                    });
            }
            return result;
        }
        /// <summary>
        /// 取Action的描述文本
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string GetDescription(ICustomAttributeProvider action)
        {
            //取自定义特性数组
            var description = action.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //取出Description，否则为空
            var result = description.Length > 0 ? (description[0] as DescriptionAttribute).Description : null;
            return result;
        }
        /// <summary>
        /// 取Action的描述文本
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string GetPermissionId(ICustomAttributeProvider action)
        {
            //取自定义特性数组
            var description = action.GetCustomAttributes(typeof(PermissionAttribute), false);
            //取出Description，否则为空
            var result = description.Length > 0 ? (description[0] as PermissionAttribute).Id : null;
            return result;
        }
        /// <summary>
        /// 格式化Method的参数字符串
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatParams(MethodInfo method)
        {
            var param = method.GetParameters();
            var result = new StringBuilder();
            if (param.Length > 0)
            {
                foreach (var item in param)
                {
                    result.AppendLine(String.Format("Type:{0}, Name:{1}; ", item.ParameterType, item.Name));
                }
                return result.ToString();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 格式化Action的参数字符串
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string FormatParams(ActionDescriptor action)
        {
            var param = action.Parameters;
            var result = new StringBuilder();
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    result.Append(string.Format("Type:{0}, Name:{1}; ", item.ParameterType, item.Name));
                }
                return result.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}