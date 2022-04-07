using Autofac;
using EBAUExercise.Repository;
using EBAUExercise.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EBAUExercise
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EBAUExercise", Version = "v1" });
            });
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<DoWorkService>().AsSelf();
            builder.RegisterType<CountingService>().AsSelf();
            builder.RegisterType<MockDataRepository>().AsSelf();
            builder.RegisterType<SampleDataRepository>().AsSelf();
            builder.RegisterType<CustomerReportService>().AsSelf();

            builder.RegisterType<StoresReportService>().AsSelf();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EBAUExercise v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(options => options.WithOrigins("https://localhost"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
