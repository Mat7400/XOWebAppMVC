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
        public IActionResult Win()
        {
            return View(Program.mainModelData);
        }


        public IActionResult Index(MainModel model)
        {
            if (Program.mainModelData == null) Program.mainModelData = new MainModel();
            //model.xo = "resutl will be here"; 
            return View(Program.mainModelData);
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
            var model = Program.mainModelData;
            //заполнить клеточку поля 
            model.Field[cellname] = RES;

            model.xo = RES;
            model.Xplayer = next;
            model.cellname = cellname;
            //проверка на победу
            bool resWin = checkWin(Program.mainModelData);
            if (resWin)
            {
                return RedirectToAction("win");
            }
            //вернуть вместо test.cshtml обратно главную страницу
            //на главной странице в выбранной клетке должно стоять значение (Х или O или V)
            return RedirectToAction("Index", model);
        }
        private bool checkWin(MainModel model)
        {
            //проверка выигрыша
            //1) проходим по всем строкам и ищем три Х или три О подряд
            //2) и то же самое оп всем столбцам
            //3) проверка диагоналей
            int initial = (int)'a';
            string[,] arr = new string[5, 5];
            foreach (var keyPair in model.Field)
            {
                string cellname = keyPair.Key;
                int row = (int)(cellname[0]) - initial;
                int column = Convert.ToInt32(cellname[1].ToString());
                string value = keyPair.Value;
                arr[row, column] = value;
            }
            //проверим по строкам
            for (int i = 0; i < model.size; i++)
            {
                int xcounter = 0;
                int ocounter = 0;
                for (int j = 0; j < model.size; j++)
                {
                    if (arr[i, j] == "X") xcounter++;
                    if (arr[i, j] == "O") ocounter++;
                }
                if (xcounter >= 3)
                {
                    model.xo = "X"; return true;
                }
                if (ocounter >= 3)
                {
                    model.xo = "O"; return true;
                }
            }
            //проверим по столбцам
            for (int i = 0; i < model.size; i++)
            {
                int xcounter = 0;
                int ocounter = 0;
                for (int j = 0; j < model.size; j++)
                {
                    if (arr[j, i] == "X") xcounter++;
                    if (arr[j, i] == "O") ocounter++;
                }
                if (xcounter >= 3)
                {
                    model.xo = "X"; return true;
                }
                if (ocounter >= 3)
                {
                    model.xo = "O"; return true;
                }
            }
            //проверка выигрыша чтоб прервать циклы
            bool win = false;
            //ПРОВЕРИМ ПО ДИАГОНАЛЯМ
            for (int i = 0; i < model.size && !win; i++)
            {
                string tocheck = "";
                int counterUpLeft = 0;
                int counterUpRight = 0;
                int counterDownRight = 0;
                int counterDownLeft = 0;
                for (int j = 0; j < model.size && !win; j++)
                {
                    if (arr[i, j] == "X")
                    {
                        tocheck = "X";
                    }
                    if (arr[i, j] == "O")
                    {
                        tocheck = "O";
                    }
                    //проверим можем ли пойти вверх-влево
                    if ((i - 1) > 0 && (j - 1) > 0)
                    {
                        //проверяем что есть сверху слева
                        if (arr[i - 1, j - 1] == tocheck) counterUpLeft++;
                    }
                    //проверим можем ли пойти вверх-вправо
                    if ((i + 1) < model.size && (j - 1) > 0)
                    {
                        //проверяем что ест
                        if (arr[i + 1, j - 1] == tocheck) counterUpRight++;
                    }
                    //проверим можем ли пойти вниз-вправо
                    if ((i + 1) < model.size && (j + 1) < model.size)
                    {
                        //проверяем что есть 
                        if (arr[i + 1, j + 1] == tocheck) counterDownRight++;
                    }
                    //проверим можем ли пойти вниз-влево
                    if ((i - 1) > 0 && (j + 1) < model.size)
                    {
                        //проверяем что есть
                        if (arr[i - 1, j + 1] == tocheck) counterDownLeft++;
                    }
                }
                //проверяем счетчики
                if (counterUpLeft + counterDownRight==2 || counterUpRight+counterDownLeft==2)
                {
                    win = true;
                    model.xo = tocheck;
                    return true;
                }
            }

            return false;
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
