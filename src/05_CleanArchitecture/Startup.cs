using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiArchitectureSample.Application.Core.Models;
using ApiArchitectureSample.Core.Application.UseCases.Hello;
using ApiArchitectureSample.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ApiArchitectureSample
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
            services.AddControllers();

            // DI
            services.AddTransient<IHelloGetByUserNameUseCase, HelloGetByUserNameUseCase>();
            services.AddTransient<IHelloGetByUserIdUseCase, HelloGetByUserIdUseCase>();
            services.AddTransient<IUserRepository, InMemoryUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
