namespace CSharp.WebApiConfiguration {

    using Microsoft.Extensions.Options;

    public class AppOptionsConfiguration {

        AppSettings appSettings;

        public AppOptionsConfiguration(IOptions<AppSettings> appSettingOptions) {
            this.appSettings = appSettingOptions.Value;
        }

        public string Greeting {
        get => appSettings.Greetings; 
        set {}
    }
    }
}