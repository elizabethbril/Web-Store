using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Logic;
using Database;

namespace WebShop
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
            services.AddMvc();

            services.AddScoped<ShopContext>();
            services.AddScoped<ContextRepository<Database.User>>();
            services.AddScoped<ContextRepository<Database.Manager>>();
            services.AddScoped<ContextRepository<Database.Admin>>();
            services.AddScoped<ContextRepository<Database.Laptop>>();
            services.AddScoped<ContextRepository<Database.Accessories>>();
            services.AddScoped<ContextRepository<Database.PhotoTechique>>();
            services.AddScoped<ContextRepository<Database.SmartPhone>>();
            services.AddScoped<ContextRepository<Database.Tablet>>();
            services.AddScoped<ContextRepository<Database.Order>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ShopLogic>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
