namespace PinedaL_API_IA.Interfaces
{
    public interface IChatbotService
    {
        public Task<string> ObtenerRespuestaChatBot(string prompt);

        public bool GuardarRespuestaBD(string prompt, string respuesta);

    }
}
