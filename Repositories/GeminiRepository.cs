using System.Text;
using Newtonsoft.Json;
using PinedaL_API_IA.Interfaces;
using PinedaL_API_IA.Models;
namespace PinedaL_API_IA.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private HttpClient _httpClient;
        private readonly string GeminiApiKey = "AIzaSyCbt6kfzMCOUsOOXjwt4D7s3l8igH1eYwU";
        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> ObtenerRespuestaChatBot(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" +GeminiApiKey;

            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text= prompt
                            }
                        }
                    }
                }
            };

            string json_data = JsonConvert.SerializeObject(request);

            var content = new StringContent(json_data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }

  
        public bool GuardarRespuestaBD(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }
    }
}
