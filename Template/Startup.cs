

namespace CSharp.Template {

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using CSharp.Template.Models;

    public class Startup {

        IConfiguration configuration;

        public Startup(IConfiguration configuration) {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {

            services.AddControllers();

            // Setting appSettings.json to AppSettings Model using Options Pattern
            services.Configure<AppSettings>(this.configuration);
            services.AddScoped<AppConfiguration>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}