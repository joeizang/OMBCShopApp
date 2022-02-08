using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.Toast;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OBMCShopApp.Constants;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.Services;
using Syncfusion.Blazor;

namespace OBMCShopApp
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
            services.AddDbContext<OBMCShopAppContext>(options =>
            options.UseNpgsql(
                    Configuration.GetConnectionString("DefaultConnection")));
            //options.UseSqlite(
            //        Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI()
                .AddEntityFrameworkStores<OBMCShopAppContext>();
            services.AddHttpClient();
            services.AddMemoryCache();
            services.AddScoped<IProductDataService, ProductDataService>();
            services.AddScoped<ISaleDataService, SaleDataService>();
            services.AddScoped<IShelfDataService, ShelfDataService>();
            services.AddScoped<IDataService<ProductSold>, GenericDataService<ProductSold>>();
            services.AddScoped<IDataService<Product>, GenericDataService<Product>>();
            services.AddTransient<ISaleService, SaleService>();
            // services.AddTransient(typeof(ProtectedBrowserStorage));
            services.AddHttpContextAccessor();
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(Startup));
            services.AddScoped(typeof(IDataService<>), typeof(GenericDataService<>));
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredModal();
            services.AddBlazoredToast();
            services.AddBlazoredLocalStorage();
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<ApplicationRole> roleManager)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Keys.SyncFusionKey);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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
                    pattern: "{controller=Sales}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
            });
        }
    }
}