
using OCR.Common.Model;
using System.Web.Http;

namespace OCR.Master.Web.Controllers
{
    [RoutePrefix("api/agents")]
    public class AgentsController : ApiController
    {
        [Route("register")]
        [HttpPost]
        public IHttpActionResult Register(AgentConfig agentConfig)
        {
            return Ok(new { Test = "Test is good" });
        }
    }
}