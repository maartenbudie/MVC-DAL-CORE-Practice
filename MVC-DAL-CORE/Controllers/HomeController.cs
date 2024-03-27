using FactoryProj;
using Microsoft.AspNetCore.Mvc;
using MVC_DAL_CORE.Models;
using System.Diagnostics;
using Core;

namespace MVC_DAL_CORE.Controllers
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
            IData data = Factory.CreateData();
            List<int> ids = data.GetIDs();
            return View(ids);
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
