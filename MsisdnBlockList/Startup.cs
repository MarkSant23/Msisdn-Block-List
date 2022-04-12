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
using MsisdnBlockList.Services;

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
            services.AddScoped<UserService>();
            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //opt.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(opt =>
            {
                opt.LoginPath = "/login";
                opt.AccessDeniedPath = "/denied";

                opt.Events = new CookieAuthenticationEvents()
                {
                    OnSigningIn = async context =>
                    {
                        var scheme = context.Properties.Items.Where(k => k.Key == ".AuthScheme").FirstOrDefault();
                        var claim = new Claim(scheme.Key, scheme.Value);
                        var claimsIdentity = context.Principal.Identity as ClaimsIdentity;
                        var userService = context.HttpContext.RequestServices.GetRequiredService(typeof(UserService)) as UserService;
                        var nameIdentifier = claimsIdentity.Claims.FirstOrDefault(m => m.Type == ClaimTypes.NameIdentifier)?.Value;
                        if (userService != null && nameIdentifier != null)
                        {
                            var appUser = userService.GetUserByExternalProvider(scheme.Value, nameIdentifier);
                            if (appUser is null)
                            {
                                appUser = userService.AddNewUser(scheme.Value, claimsIdentity.Claims.ToList());
                            }
                            foreach (var r in appUser.roleList)
                            {
                                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, r));
                            }
                        }
                        claimsIdentity.AddClaim(claim);
                        await Task.CompletedTask;
                    }
                };
            })
            .AddGoogle("google", opt =>
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
