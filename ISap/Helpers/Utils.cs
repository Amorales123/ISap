using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace ISap.Helpers
{
    public static class Utils
    {
        public static string DB_Server {get;set; }
        public static string DB_User { get; set; }
        public static string DB_Pass { get; set; }
        public static string DB_ServerType { get; set; }
        public static string SAP_Company { get; set; }
        public static string SAP_User { get; set; }
        public static string SAP_Pass { get; set; }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                //var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.);
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        public static String getAppSettings(string key) =>
            (ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings[key] == null) ? null :
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings[key].Value;
    }
}
