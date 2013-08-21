namespace EmbassyRegistration.Form.App_Start
{
    public static class Configuration
    {
        public static string TemplatePath
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["TemplateLocation"];
            }
        }

        public static string ScriptsStoragePath
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["GeneratedTemplates"];
            }
        }
    }
}