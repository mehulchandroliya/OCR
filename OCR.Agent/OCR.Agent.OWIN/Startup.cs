
using System.Web.Http;
using Microsoft.Owin;
using OCR.Agent.Process;
using Owin;

[assembly: OwinStartup(typeof(OCR.Agent.OWIN.Startup))]
namespace OCR.Agent.OWIN
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            WebApiConfig.Register(config);

            appBuilder.UseWebApi(config);
        }
    }
}
