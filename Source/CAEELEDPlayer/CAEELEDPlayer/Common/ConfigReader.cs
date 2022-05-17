using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CAEELEDPlayer.Common
{
    public class ConfigReader
    {
        public static string ProjectUrl = ConfigurationManager.AppSettings["ProjectUrl"] ?? string.Empty;

        public static string ProjectShowUrl = ConfigurationManager.AppSettings["ProjectShowUrl"] ?? string.Empty;
        
        public static string BuyUrl = ConfigurationManager.AppSettings["BuyUrl"] ?? string.Empty;

        public static string DBConnectionString =
            ConfigurationManager.ConnectionStrings["CAEELEDPlayer.Properties.Settings.LEDInfoConnectionString"].ConnectionString ??
            string.Empty;

        public static int RequestSpan = ConfigurationManager.AppSettings["RequestSpan"] == string.Empty ? 1 : Int32.Parse(ConfigurationManager.AppSettings["RequestSpan"]);

        public static string RequestSource = ConfigurationManager.AppSettings["RequestSource"] ?? string.Empty;

        public static string RequestSource2 = ConfigurationManager.AppSettings["RequestSource2"] ?? string.Empty;
        
    }
}
