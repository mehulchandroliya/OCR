using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OCR.Agent.Process.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [Route("")]
        // GET api/values
        public IEnumerable<string> Get() => new string[] { "value1", "value2" };
    }
}
