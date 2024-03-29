using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Study2gether.Atributtes;
using Study2gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study2gether
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //Banco de dados local
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/user/AccessDenied/";
                    options.LoginPath = "/user/Login/";
                });
            services.AddControllersWithViews(options =>
               {
                   options.Filters.Add<ViewBagActionFilter>();
               });

        }
        //Banco de dados na smarterasp
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    var connectionString = "Server=MYSQL5044.site4now.net;Database=db_a9a07d_studytw;Uid=a9a07d_studytw;Pwd=f4487dhwyfdTSDYF";
        //    var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
        //    services.AddDbContext<ApplicationDbContext>(
        //        dbContextOptions => dbContextOptions
        //            .UseMySql(connectionString, serverVersion)
        //            .LogTo(Console.WriteLine, LogLevel.Information)
        //            .EnableSensitiveDataLogging()
        //            .EnableDetailedErrors()
        //    );

        //    services.Configure<CookiePolicyOptions>(options =>
        //    {
        //        options.CheckConsentNeeded = context => true;
        //        options.MinimumSameSitePolicy = SameSiteMode.None;
        //    });

        //    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        //        .AddCookie(options =>
        //        {
        //            options.AccessDeniedPath = "/user/AccessDenied/";
        //            options.LoginPath = "/user/Login/";
        //        });

        //    services.AddControllersWithViews(options =>
        //    {
        //        options.Filters.Add<ViewBagActionFilter>();
        //    });
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapAreaControllerRoute(
                   name: "Admin",
                   areaName: "Admin",
                   pattern: "Admin/{controller=AdminHome}/{action=Index}/{id?}"
               );
               endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );
               endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
