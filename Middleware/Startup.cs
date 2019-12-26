namespace CSharp.Middleware {

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using System;

    public class Startup {

        IConfiguration configuration;

        public Startup(IConfiguration configuration) {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            Console.WriteLine("Configure");

            app.Use( async (context, next) => 
            {
                Console.WriteLine("First Delegate");
                await next.Invoke(); 
            });

            app.Run(async context =>
            {
                Console.WriteLine("Second Delegate");
                await context.Response.WriteAsync("Hello from 2nd delegate.");
            });
        }
    }
}