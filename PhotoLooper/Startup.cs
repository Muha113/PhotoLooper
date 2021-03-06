using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PhotoLooper.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.IO;
using PhotoLooper.Logger;
using PhotoLooper.Services;
using PhotoLooper.Hubs;
using PhotoLooper.BackgroundServices;

namespace PhotoLooper
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            /*var builder = new ConfigurationBuilder().AddJsonFile("config.json");
            AppConfiguration = builder.Build();*/
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<SocialUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId = "766282803838651";
                    options.AppSecret = "a55d494b372da34c23d78525b1ed40c5";
                });

            services.AddTransient<IDbService, DbService>();

            services.AddTransient<IEmailService, EmailService>();

            services.AddHostedService<SendStatsBackgroundService>();

            services.AddMvc(options => {
                options.EnableEndpointRouting = false;
                });
            services.AddControllersWithViews();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IWebHostEnvironment env)
        {
            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logs.txt"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error", "?statusCode={0}");
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/error", "?statusCode={0}");
            app.UseDefaultFiles();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseSignalR(routes =>
            {
                routes.MapHub<PostHub>("/HuHub");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
