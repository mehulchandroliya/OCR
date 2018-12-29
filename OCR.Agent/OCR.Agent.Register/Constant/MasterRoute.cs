
using System;
using OCR.Agent.Register.Constant;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Agent.Register.Constant
{
    public static class MasterRoute
    {
        #region Private Members
        private static Uri BASE_URL = new Uri(AppConfig.MasterURI);
        #endregion

        public static Uri RegisterAgent => new Uri(BASE_URL, "api/agents/register");
    }
}
