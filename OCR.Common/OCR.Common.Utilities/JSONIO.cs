using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Common.Utilities
{
    public static class JSONIO
    {
        public static string ToJSON<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ToObj<T>(string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
