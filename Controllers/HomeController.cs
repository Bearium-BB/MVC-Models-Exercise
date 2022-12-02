using Microsoft.AspNetCore.Mvc;
using MVC_Models_Exercise.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace MVC_Models_Exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Games()
        {
            var SGR = new SteamGameRepository();
            return View(SGR);
        }

        public IActionResult Game(uint id)
        {
            ViewData["id"] = id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}