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

        public IActionResult Index(MainModel model)
        {
            if (model==null) model = new MainModel();
            model.xo = "resutl will be here"; 
            return View(model);
        }
        public IActionResult test(string cellname = "", string xplayer = "X")
        {
            Random rnd = new Random();
            int res = rnd.Next(1, 100);
            string RES = "";
            string next = "";
            if (xplayer == "X" || xplayer == "")
            {
                RES = "X";
                next = "O";
            }
            else
            {
                RES = "O";
                next = "X";
            }
            var model = new MainModel();
            //заполнить клеточку поля 
            model.Field[cellname] = RES;

            model.xo = RES;
            model.Xplayer = next;
            model.cellname = cellname;
            //вернуть вместо test.cshtml обратно главную страницу
            //на главной странице в выбранной клетке должно стоять значение (Х или O или V)
            return RedirectToAction("Index",model);
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
