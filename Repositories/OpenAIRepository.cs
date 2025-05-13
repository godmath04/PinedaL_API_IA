using PinedaL_API_IA.Interfaces;

namespace PinedaL_API_IA.Repositories
{
    public class OpenAIRepository : IChatbotService
    {
        public bool GuardarRespuestaBD(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerRespuestaChatBot(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
