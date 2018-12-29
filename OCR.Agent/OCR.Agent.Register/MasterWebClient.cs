
using OCR.Agent.Register.Constant;
using OCR.Common.Model;
using OCR.Common.Utilities;
using System.Net.Http;
using System.Threading.Tasks;

namespace OCR.Agent.Register
{
    public class MasterWebClient
    {
        #region Public Members
        public static Task<HttpResponseMessage> RegisterAgent(AgentConfig agentConfig)
        {
            return WebClient.Post(MasterRoute.RegisterAgent, agentConfig);
        }
        #endregion
    }
}
