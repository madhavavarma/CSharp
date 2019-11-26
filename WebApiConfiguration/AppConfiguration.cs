using Microsoft.Extensions.Configuration;

public class AppConfiguration {

    private const string AppSettings = "AppSettings";
    private const string Greetings = "Greetings";

    private IConfiguration configuration;

    public AppConfiguration(IConfiguration configuration) {
        this.configuration = configuration;
    }

    public IConfigurationSection AppSettingsSection {
        get => this.configuration.GetSection(AppSettings);
    }

    public string Greeting {
        get => AppSettingsSection[Greetings]; 
        private set {}
    }
}