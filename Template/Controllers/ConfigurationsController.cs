namespace CSharp.Template {

    using Microsoft.AspNetCore.Mvc;
    using System;
    using CSharp.Template.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        AppSettings appSettings;

        public ConfigurationsController(AppConfiguration appConfig) {
            this.appSettings = appConfig.appSettings;
        }

        [HttpGet]
        public ActionResult<string> Get() {
            return this.appSettings.Greeting;
        }
    }
}