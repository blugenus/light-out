using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FrontEnd
{
    public class ClsHttp
    {
        private static readonly HttpClient client = new HttpClient();

        public static Task<System.IO.Stream> GetUrl(string Url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Light Out Front End");
            return client.GetStreamAsync(Url);
        }

    }
}
