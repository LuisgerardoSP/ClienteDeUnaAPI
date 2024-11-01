using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisorTerremotos.Objetos;
using static System.Net.WebRequestMethods;

namespace VisorTerremotos
{
    class ApiClient
    {
        public async Task<Root> GetRoot(int lim)
        {
            Root captura = new Root();

            HttpRequestMessage requestMessage;
            HttpClient client;
            HttpResponseMessage response;
            string url;

            url = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime=2014-01-01&endtime=2014-01-02&limit=" + lim;
            requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            client = new HttpClient();

            response = await client.SendAsync(requestMessage);

            if (response.IsSuccessStatusCode)
                captura = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
            else
                captura = null;

            return captura;
        }
    }
}
