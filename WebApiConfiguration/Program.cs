using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CSharp.WebApiConfiguration {
    public class Program {

        public static void Main(string[] args) {
            CreateDefaultHost(args).Build().Run();
        }

        public static IHostBuilder CreateDefaultHost(string[] args) =>
         Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}