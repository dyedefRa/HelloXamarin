using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebService05.Models;

namespace WebService05.Providers
{
    public class ServiceManager
    {
        private string url = "http://192.168.4.6/ServiceHub/api/aakademi/";
        private async Task<HttpClient> GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            HttpClient client = await GetClient();

            var result = await client.GetStringAsync(url + "getall");
            var mobileResult = JsonConvert.DeserializeObject<MobileResult>(result);
            return JsonConvert.DeserializeObject<IEnumerable<Student>>(mobileResult.Data.ToString());
        }
    }
}
