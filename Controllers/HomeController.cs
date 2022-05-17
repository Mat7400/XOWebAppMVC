using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using XO_WebApp.Models;

namespace XO_WebApp.Controllers
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
            var model = new MainModel();
            model.xo = "resutl will be here"; 
            return View(model);
        }
        public IActionResult test()
        {
            Random rnd = new Random();
            int res = rnd.Next(1, 100);
            string RES = "";
            if (res > 50) 
                RES = "X";
            else 
                RES = "O";

            var model = new MainModel();
            model.xo = RES;
            return View(model);
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
