namespace CSharp.WebApiConfiguration {

    public class AppSettings {

        public string Greetings { get; set; }

        public bool ShowGreetings { get; set; }

        public string[] Messages { get; set; }

        public ModuleSettings ModuleSettings {get; set;}
    }
}