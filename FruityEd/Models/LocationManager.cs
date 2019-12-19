using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FruityEd.Models
{
    public class LocationManager
    {

      private  const string Url = "192.168.100.8:5000/api/locations";
       // private string authorizationKey = "";



        

        public async Task<IEnumerable<Location>> GetAll()

        {

            var httpClient = new HttpClient();

            string json = await httpClient.GetStringAsync(Url);

            var locations =  JsonConvert.DeserializeObject<IEnumerable<Location>>(json);

            return locations;

        }
    }
}
