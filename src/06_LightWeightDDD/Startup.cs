using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;
using ApiArchitectureSample.Core.Application.UseCases.Hello;
using ApiArchitectureSample.Core.Application.UseCases.User;
using ApiArchitectureSample.Infrastructure;
using ApiArchitectureSample.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            // Add DbContext
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApiArchitectureSampleContext>(options =>
                options.UseSqlServer(connectionString)
            );

            // DI
            services.AddTransient<IHelloGetByUserNameUseCase, HelloGetByUserNameUseCase>();
            services.AddTransient<IHelloGetByUserIdUseCase, HelloGetByUserIdUseCase>();
            services.AddTransient<IUsersFindAllUseCase, UsersFindAllUseCase>();
            services.AddTransient<IUsersGetByIdUseCase, UsersGetByIdUseCase>();
            services.AddTransient<IUserRepository, UserRepository>();
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
