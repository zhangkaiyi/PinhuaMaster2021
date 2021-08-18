using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PinhuaMaster
{
    public class PermissionAttribute : Attribute
    {
        public PermissionAttribute(string guid)
        {
            Id = Guid.Parse(guid).ToString();
        }

        public string Id { get; private set; }
    }

    /// <summary>
    /// 访问授权验证
    /// </summary>
    [Description("验证访问权限")]
    public class IdentityAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        /// <summary>
        /// 授权上下文
        /// </summary>
        private AuthorizationFilterContext _filterContext;

        #region 重写父类方法
        /// <summary>
        /// 重写授权验证方法
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {
            _filterContext = filterContext;

            //filterContext.Result = new Microsoft.AspNetCore.Mvc.RedirectToPageResult("/Account/Login") ;
            //if (!HasPermission(_filterContext))
            //    return;
        }
        #endregion

        //#region 帮助方法
        ///// <summary>
        ///// 当前请求是否具有访问权限
        ///// </summary>
        ///// <param name="filterContext"></param>
        ///// <returns></returns>
        //private bool HasPermission(OnAuthorization filterContext)
        //{
        //    //取当前用户的权限            
        //    var rolePermissions = GetUserPermissions(filterContext.HttpContext);
        //    //待访问的Action的Permission
        //    var action = new ApplicationPermission
        //    {
        //        Id = (filterContext.ActionDescriptor.GetCustomAttributes(typeof(PermissionAttribute), false).FirstOrDefault() as PermissionAttribute)?.Id,
        //        Action = filterContext.ActionDescriptor.ActionName,
        //        Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
        //        Description = ActionPermissionService.GetDescription(filterContext.ActionDescriptor)
        //    };
        //    //是否授权
        //    return rolePermissions.Contains(action, new ApplicationPermissionEqualityComparer());
        //}

        ///// <summary>
        ///// 取当前用户的权限列表
        ///// </summary>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //private IEnumerable<ApplicationPermission> GetUserPermissions(HttpContextBase context)
        //{
        //    //取登录名
        //    var username = context.User.Identity.Name;
        //    //构建缓存key
        //    var key = string.Format("UserPermissions_{0}", username);
        //    //从缓存中取权限
        //    var permissions = HttpContext.Current.Session[key]
        //                        as IEnumerable<ApplicationPermission>;
        //    //若没有，则从db中取并写入缓存
        //    if (permissions == null)
        //    {
        //        //取rolemanager
        //        var roleManager = context.GetOwinContext().Get<ApplicationRoleManager>();
        //        //取用户权限集合
        //        permissions = roleManager.GetUserPermissions(username);
        //        //写入缓存
        //        //context.Session.Add(key, permissions);
        //    }
        //    return permissions;
        //}


        //#endregion
    }
}