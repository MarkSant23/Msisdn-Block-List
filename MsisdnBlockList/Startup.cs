using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MsisdnBlockList.Data;
using MsisdnBlockList.Models;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace MsisdnBlockList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddLogging();

            services.AddDbContext<MySqlContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"));
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
            });

            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            }).AddCookie(opt =>
            {
                opt.LoginPath = "/login";
                opt.AccessDeniedPath = "/denied";

                //dajemo Adminu rolu pristupa stranici preko cookiea
                opt.Events = new CookieAuthenticationEvents()
                {
                    OnSigningIn = async context =>
                    {
                        var principal = context.Principal;
                        if (principal.HasClaim(k => k.Type == ClaimTypes.NameIdentifier))
                        {
                            if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value == "Mark")
                            {
                                var clIdenity = principal.Identity as ClaimsIdentity;
                                clIdenity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                            }
                        }
                        await Task.CompletedTask;
                    },
                    OnSignedIn = async context =>
                    {
                        await Task.CompletedTask;
                    },
                    OnValidatePrincipal = async context =>
                    {
                        await Task.CompletedTask;
                    }
                };
            })
            .AddGoogle(opt =>
                {
                     opt.ClientId = Configuration["Authentication:Google:ClientId"];
                     opt.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
                     opt.CallbackPath = "/auth";
                 
                     //vraća na google login
                     opt.AuthorizationEndpoint += "?prompt=consent";
                });


            services.AddRazorPages();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }           
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Msisdn}/{action=Index}/{id?}");
            });
                      
        }
    }
}
