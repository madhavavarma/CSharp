using Microsoft.AspNetCore.Mvc;
using System;

namespace CSharp.WebApiConfiguration {
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        AppConfiguration appConfiguration;
        AppOptionsConfiguration appOptionsConfiguration;

        public ConfigurationsController(AppConfiguration appConfig, AppOptionsConfiguration appOptionsConfiguration) {
            this.appConfiguration = appConfig;
            this.appOptionsConfiguration = appOptionsConfiguration;
        }

        [HttpGet]
        public ActionResult<string> Get() {
            Console.WriteLine(appConfiguration.Greeting);
            return appConfiguration.Greeting;
        }

        [HttpGet("options")]
        public ActionResult<string> GetOptions() {
            Console.WriteLine(appOptionsConfiguration.Greeting);
            return appOptionsConfiguration.Greeting;
        }

        [HttpGet("messages")]
        public ActionResult<string[]> GetMessages() {
            Console.WriteLine(appOptionsConfiguration.Messages);
            return appOptionsConfiguration.Messages;
        }

        [HttpGet("ms")]
        public ActionResult<ModuleSettings> GetModuleSettings() {
            Console.WriteLine(appOptionsConfiguration.ModuleSettings);
            return appOptionsConfiguration.ModuleSettings;
        }
    }
}