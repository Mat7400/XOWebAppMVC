using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XO_WebApp.Models
{
    public class MainModel
    {
        public string xo="";
        public string Xplayer = "";
        public string cellname = "";
        public int size = 5;
        //простой вариант для хранения данных поля: создать 25 значений
        //а1..а5, b1..b5,c,d, e1..e5
        //второй вариант: создать массив или онг же словарь Dictionary Field["a5"]
        public Dictionary<string, string> Field = new Dictionary<string, string>();
        public MainModel()
        {
            int ia = (int)'a';
            char a = 'a';
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    string key = a.ToString() + j.ToString();
                    Field.Add(key, "_");
                }
                ia++;
                a = (char)ia;
            }
        }
    }
}
