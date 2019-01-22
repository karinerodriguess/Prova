using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Prova.Domain.Interfaces.Repositories;
using Prova.Domain.Interfaces.Services;
using Prova.Domain.Services;
using Prova.Infra.Persistence.EF;
using Prova.Infra.Persistence.Repositories;
using Prova.Infra.Transactions;

namespace Prova
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Add dependency injection
            services.AddScoped<ProvaContext, ProvaContext>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Services
            services.AddTransient<IServiceTask, ServiceTask>();

            //Repositories
            services.AddTransient<IRepositoryTask, RepositoryTask>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
