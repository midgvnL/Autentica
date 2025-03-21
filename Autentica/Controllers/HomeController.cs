using Autentica.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autentica.Controllers
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

        [Authorize(Roles = "Admin,TI")]
        public IActionResult Tecnologia()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Financeiro")]
        public IActionResult Financeiro()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Comercial")]
        public IActionResult Comercial()
        {
            return View();
        }

        [Authorize(Roles = "Admin,RH")]
        public IActionResult RH()
        {
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
