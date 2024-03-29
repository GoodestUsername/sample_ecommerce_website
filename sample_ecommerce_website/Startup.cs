using FoolProof.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website
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
            services.AddControllersWithViews();
            services.AddDbContext<ProductDBModel>(options => options.UseSqlServer(Configuration.GetConnectionString("ProductDBContext")).UseLazyLoadingProxies());

            /*            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                        {
                            options.Password.RequiredLength = 8;
                            options.Password.RequireNonAlphanumeric = true;
                            options.Password.RequireDigit = true;
                        }).AddEntityFrameworkStores<ProductDBModel>().AddDefaultTokenProviders();*/
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ProductDBModel>()
                .AddDefaultUI()
                .AddEntityFrameworkStores<ProductDBModel>().AddDefaultTokenProviders();
            /*            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                        {
                            options.Password.RequiredLength = 8;
                            options.Password.RequireNonAlphanumeric = true;
                            options.Password.RequireDigit = true;
                        }).AddEntityFrameworkStores<ProductDBModel>().AddDefaultTokenProviders();*/

/*            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ProductDBModel>();
*/
            services.AddAuthentication("CookieAuthentication")
                .AddCookie("CookieAuthentication", config => {
                config.Cookie.Name = "Access.Cookie";
                config.LoginPath = "/Home/Authenticate";
            });
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddFoolProof();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
