namespace CSharp.WebApiConfiguration {

    using Microsoft.Extensions.Options;

    public class AppOptionsConfiguration {
        public AppSettings appSettings;

        public AppOptionsConfiguration(IOptions<AppSettings> appSettingOptions) {
            this.appSettings = appSettingOptions.Value;
        }
    }
}