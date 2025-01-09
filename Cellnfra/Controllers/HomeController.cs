using Cellnfra.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cellnfra.Controllers
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

        public IActionResult WhyUs()
        {
            return View();
        }
        public IActionResult ElectronicsRepairs()
        {
            return View();
        }

        public IActionResult Telecom()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult EWasteManagement()
        {
            return View();
        }
    }
}
