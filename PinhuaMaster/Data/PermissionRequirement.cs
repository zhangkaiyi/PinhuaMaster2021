using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using PinhuaMaster.Data;
using PinhuaMaster.Data.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PinhuaMaster
{
    public class PermissionRequirement : IAuthorizationRequirement
    {

    }

    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private ApplicationDbContext _identityContext { get; set; }

        public PermissionHandler(ApplicationDbContext identityContext)
        {
            _identityContext = identityContext;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            var action = (context.Resource as AuthorizationFilterContext)?.ActionDescriptor as CompiledPageActionDescriptor;

            if (!context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            if (context.User.Identity.Name == "116307766@qq.com" || context.User.IsInRole("管理员") /*|| context.User.IsInRole("业务员")*/)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            if (context.User.IsInRole("业务员"))
            {
                var roleId = _identityContext.Roles.FirstOrDefault(r => r.Name == "业务员")?.Id;
                var pages = _identityContext.RolePages.Where(p => p.RoleId == roleId).Select(p => p.Page);
                if (pages.Contains(action.RouteValues["page"]))
                {
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }
            }

            context.Fail();

            return Task.CompletedTask;
        }
    }
}
