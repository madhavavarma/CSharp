namespace CSharp.Template {

    using Microsoft.Extensions.Options;
    using CSharp.Template.Models;

    public class AppConfiguration {

        public AppSettings appSettings;

        public AppConfiguration(IOptions<AppSettings> appSettingsOptions) {
            this.appSettings = appSettingsOptions.Value;
        }
    }
}