
using System.Configuration;
using System.Linq;

namespace OCR.Common.Utilities
{
    public static class AppConfigIO
    {
        public static string Get(string key)
        {
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                return ConfigurationManager.AppSettings[key];
            }
            return string.Empty;
        }
    }
}
