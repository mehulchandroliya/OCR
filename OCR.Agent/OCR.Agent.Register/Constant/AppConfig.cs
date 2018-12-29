
using OCR.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OCR.Agent.Register.Constant
{
    public static class AppConfig
    {
        #region Private Members
        private const string MASTER_URI = "MASTER_URI";
        private const string AGENT_NAME = "AGENT_NAME";
        private const string AGENT_PROJECT_CONFIG_FILE = "AGENT_PROJECT_CONFIG_FILE";
        private static string AGENT_HOST_NAME = Dns.GetHostName();
        #endregion

        #region Public Members
        public static string MasterURI => AppConfigIO.Get(MASTER_URI);
        public static string AgentName => AppConfigIO.Get(AGENT_NAME);
        public static string AgentProjectConfigFile => AppConfigIO.Get(AGENT_PROJECT_CONFIG_FILE);
        public static string AgentHostName => AGENT_NAME;
        #endregion
    }
}
