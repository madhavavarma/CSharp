using Microsoft.Extensions.Configuration;

public class AppConfiguration {

    private const string DefaultGreeting = "Greetings:Default";

    private IConfiguration configuration;

    public AppConfiguration(IConfiguration configuration) {
        this.configuration = configuration;
    }

    public string Greeting {
        get => this.configuration.GetValue<string>(DefaultGreeting); 
        private set {}
    }

    

}