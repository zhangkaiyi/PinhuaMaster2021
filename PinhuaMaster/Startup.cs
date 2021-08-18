using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PinhuaMaster.Data;
using PinhuaMaster.Services;
using Microsoft.Extensions.FileProviders;
using System.IO;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Data.Entities.EastRiver;
using AutoMapper;
using PinhuaMaster.Extensions;
using Zky.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;

namespace PinhuaMaster
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // AspNetCore 2.1
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //options.CheckConsentNeeded = context => true;
                //options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Add DbContext
            services.AddDbContext<PinhuaContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("PinhuaConnection"),
                o => o.UseRowNumberForPaging())
                );

            services.AddDbContext<EastRiverContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("EastRiverConnection"),
                o => o.UseRowNumberForPaging())
                );

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    //options.Conventions.AuthorizeFolder("/Account/Manage");
                    //options.Conventions.AuthorizePage("/Account/Logout");
                    options.Conventions.AuthorizeFolder("/", "Permissons")
                    .AllowAnonymousToFolder("/Account")
                    .AllowAnonymousToFolder("/Statement/External")
                    .AllowAnonymousToFolder("/ProductionManagement/ProductionOrder");
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddRazorPagesOptions(o => {
                    o.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute()); //����XSRF��֤, ����ajax����,���ǵķ���һ�㶼��û��ϵ��, ������Ҫ��ȫ��֤������, �����ҳ������������, �����Ҫ����ȫ�ֹرշ�α������֤, ��ע�����д���
                });

            services.AddAuthentication().AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Permissons", policy =>
                    {
                        policy.Requirements.Add(new PermissionRequirement());
                    });
            });

            // Register no-op EmailSender used by account confirmation and password reset during development
            // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
            services.AddSingleton<IEmailSender, EmailSender>();
            // ע�ᵼ���˵����ɷ���
            services.AddTransient<INavMenuService, NavMenuService>();
            // ע��PinhuaTimeline����
            services.AddTransient<ITimelineService, TimelineService>();
            // ���ʱ����ļ�����ķ���
            services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));
            // ��ȡ��ҳ������ͼ�굽���ݿ�ķ���
            services.AddTransient<IWebfontExtractor, WebfontExtractor>();

            services.AddTransient<IActionPermissionService, ActionPermissionService>();
            services.AddTransient<IAttendanceService, AttendanceService>();
            services.AddTransient<IAuthorizationHandler, PermissionHandler>();

            // Asp.net Core 2.2 �Ժ���RazorPage��̬���������
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IConfigureOptions<RazorViewEngineOptions>, RazorViewEngineOptionsSetup>());

            //��ʼ��Ӧ������
            //InitAppConfig(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                //app.UseExceptionHandler("/Error");
                // AspNetCore 2.1
                app.UseHsts();
            }

            // AspNetCore 2.1
            app.UseCookiePolicy();
            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseStaticHttpContext();

            app.UseUtility();

            loggerFactory.AddNLog();
            env.ConfigureNLog("nlog.config");
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="services"></param>
        //private void InitAppConfig(IServiceCollection services)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("NavbarMenus.json", optional: true, reloadOnChange: true);

        //    var config = builder.Build();

        //    services.Configure<List<NavbarMenu>>(config.GetSection("NavBarMenus"));
        //}
    }

    public class RazorViewEngineOptionsSetup : ConfigureOptions<RazorViewEngineOptions>
    {
        public RazorViewEngineOptionsSetup(IHostingEnvironment hostingEnvironment) :
            base(options =>
            {
                options.AllowRecompilingViewsOnFileChange = true;
            })
        {

        }
    }
}
