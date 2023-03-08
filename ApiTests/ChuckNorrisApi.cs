using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiTests
{
    public class ChuckNorrisApi
    {
        [Test]
        public async Task GetRandomJoke()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.chucknorris.io/jokes/random");
            HttpResponseMessage response = await client.SendAsync(request);
            
            string content = await response.Content.ReadAsStringAsync();

            ChuckNorrisJoke joke = JsonSerializer.Deserialize<ChuckNorrisJoke>(content);
            //using Newtonsoft.Json;
            //ChuckNorrisJoke joke = JsonConvert.DeserializeObject<ChuckNorrisJoke>(content);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            StringAssert.Contains("assets.chucknorris.host", joke.icon_url);
            StringAssert.Contains("api.chucknorris.io", joke.url);
        }
    }
}
