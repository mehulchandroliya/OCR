using OCR.Agent.Register.Constant;
using OCR.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Agent.Register
{
    public class Connect
    {
        #region Private Members
        public AgentConfig GetAgentConfig() => new AgentConfig { Name = AppConfig.AgentName, AgentProjectConfigFile = AppConfig.AgentProjectConfigFile, AgentHostName = AppConfig.AgentHostName };
        #endregion

        #region Public Members
        public Connect()
        {
            ContactMaster();
        }

        public void ContactMaster()
        {
            Task<HttpResponseMessage> registerAgent = MasterWebClient.RegisterAgent(GetAgentConfig());
            Task.WhenAll(registerAgent);
        }
        #endregion
    }
}
