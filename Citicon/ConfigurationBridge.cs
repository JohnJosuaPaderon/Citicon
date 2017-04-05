using System;
using System.Configuration;

namespace Citicon
{
    public class ConfigurationBridge
    {
        private static string _MRISReportConfiguration;
        private const string PathDependencyKey_CurrentDir = ":CurrentDir:";

        public static string MRISReportConfiguration
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_MRISReportConfiguration))
                {
                    _MRISReportConfiguration = InjectPathDependency(ConfigurationManager.AppSettings[nameof(MRISReportConfiguration)]);
                }

                return _MRISReportConfiguration;
            }
        }

        private static string InjectPathDependency(string basePath)
        {
            if (!string.IsNullOrWhiteSpace(basePath))
            {
                basePath = basePath.Replace(PathDependencyKey_CurrentDir, Environment.CurrentDirectory);
            }

            return basePath;
        }
    }
}
