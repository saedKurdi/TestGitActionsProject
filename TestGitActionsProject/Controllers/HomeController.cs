using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestGitActionsProject.Models;

namespace TestGitActionsProject.Controllers
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
            var name = "Seid";
            var name2 = "Ulfet";
            return View();
        }

        public IActionResult Index2()
        {
            var name = "Seid";
            var name2 = "Ulfet";
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
