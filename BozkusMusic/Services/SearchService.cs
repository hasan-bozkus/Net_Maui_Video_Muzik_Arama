using BozkusMusic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozkusMusic.Services
{
    public class SearchService : ISearchService
    {
        private const string apiUrl = "https://wvw.mp3juices.la/grab/json.php?q=";
        HttpClient client = new HttpClient();

        public async Task<List<Video>> GetVideoBySearch(string searchText)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, apiUrl + searchText);
            var response = await  client.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SearchModel>(json);

            return result.Items;
        }
    }
}
