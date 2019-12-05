using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Polynomtech.PolynomTech.Bll.Abstract;
using Polynomtech.PolynomTech.Bll.Concrate;
using Polynomtech.PolynomTech.Dal.Abstract;
using Polynomtech.PolynomTech.Dal.Concrate;
using Polynomtech.PolynomtechEntities;

namespace Polynomtech
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddOData();
            services.AddODataQueryFilter();
            services.AddDbContext<PolynomDbContext>(options => options.UseSqlServer("Server=DESKTOP-U3DKA58\\SQLEXPRESS;Database=PolynomtechDB;Trusted_Connection=True;"));
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IRepositoryParfume, RepositoryParfume>();
            services.AddTransient<IParfumeBusiness, ParfumeBusiness>();
            services.AddTransient<IRepositoryBrand, RepositoryBrand>();
            services.AddTransient<IBrandBusiness, BrandBusiness>();
            services.AddTransient<IRepositoryOrderDetail, RepositoryOrderDetail>();
            services.AddTransient<IOrderDetailBusiness, OrderDetailBusiness>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.EnableDependencyInjection();
                routeBuilder.Select().Filter().OrderBy().Expand().Count().MaxTop(10);

                routeBuilder.MapODataServiceRoute("api", "api", GetEdmModel(app.ApplicationServices));
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static IEdmModel GetEdmModel(IServiceProvider serviceProvider)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder(serviceProvider);

            builder.EntitySet<Brand>("Brands")
                    .EntityType
                    .Filter()
                    .Count()
                    .Expand()
                    .OrderBy()
                    .Page()
                    .Select();
            builder.EntitySet<Parfume>("Parfumes")
                    .EntityType
                    .Filter()
                    .Count()
                    .Expand()
                    .OrderBy()
                    .Page()
                    .Select();
            return builder.GetEdmModel();
        }
    }
}
