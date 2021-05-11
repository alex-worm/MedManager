using MedManager.Data;
using MedManager.Data.Repositories;
using MedManager.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MedManager.Web
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
            services.AddCors();

            var connection = Configuration.GetConnectionString("LocalConnection");

            services.AddDbContext<MmContext>(options =>
                options.UseSqlServer(connection));
            
            services.AddTransient<GenericRepository<Patient>>();
            services.AddTransient<GenericRepository<Employee>>();
            services.AddTransient<GenericRepository<Medicament>>();
            
            services.AddControllers();
            services.AddSwaggerDocument(settings =>
            {
                settings.Title = "MedManager";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();
                app.UseSwaggerUi3(cfg =>
                {
                    cfg.CustomInlineStyles = ".topbar-wrapper img {content:url('https://among-us.io/wp-content/uploads/2020/09/among-us-logo.png');}";
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}