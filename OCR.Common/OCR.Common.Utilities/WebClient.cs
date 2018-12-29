
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Common.Utilities
{
    public static class WebClient
    {
        #region Public Members
        public static async Task<HttpResponseMessage> Post<T>(Uri uri, T payload)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.PostAsJsonAsync(uri, payload);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
