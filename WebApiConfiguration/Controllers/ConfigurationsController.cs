using Microsoft.AspNetCore.Mvc;
using System;

namespace CSharp.WebApiConfiguration {
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        AppConfiguration appConfiguration;
        AppSettings appSettings;

        public ConfigurationsController(AppConfiguration appConfig, AppOptionsConfiguration appOptionsConfiguration) {
            this.appConfiguration = appConfig;
            this.appSettings = appOptionsConfiguration.appSettings;
        }

        [HttpGet]
        public ActionResult<string> Get() {
            Console.WriteLine(appConfiguration.Greeting);
            return appConfiguration.Greeting;
        }

        [HttpGet("options")]
        public ActionResult<string> GetOptions() {
            return appSettings.Greetings;
        }

        [HttpGet("messages")]
        public ActionResult<string[]> GetMessages() {
            return appSettings.Messages;
        }

        [HttpGet("ms")]
        public ActionResult<ModuleSettings> GetModuleSettings() {
            return appSettings.ModuleSettings;
        }
    }
}