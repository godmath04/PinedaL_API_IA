using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PinedaL_API_IA.Interfaces;
using PinedaL_API_IA.Models;
using PinedaL_API_IA.Repositories;

namespace PinedaL_API_IA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IChatbotService _chatbotService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _chatbotService = new GeminiRepository();
        }

        public async Task<IActionResult> Index()
        { 
            var response = await _chatbotService.ObtenerRespuestaChatBot("Resumen de 50 palabras de South Park");
            ViewBag.respuesta = response;
            return View();
        }

    }
}