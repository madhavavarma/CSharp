using Microsoft.AspNetCore.Mvc;
using System;

namespace CSharp.WebApiConfiguration {
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        AppConfiguration appConfiguration;

        public ConfigurationsController(AppConfiguration appConfig) {
            this.appConfiguration = appConfig;
        }

        [HttpGet]
        public ActionResult<string> Get() {
            Console.WriteLine(appConfiguration.Greeting);
            return appConfiguration.Greeting;
        }
    }
}