
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
        public static async Task<HttpResponseMessage> Post<T>(Uri uri, string type, T payLoad)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(type));
                HttpResponseMessage response = await client.PostAsJsonAsync(uri, payLoad);
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
