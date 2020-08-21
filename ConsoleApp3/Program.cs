using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        /*
         * Проект создан в ознакомительных целях, все права на проект принадлежат w2me.ru
         * Цель проекта: Расширить поведенческий фактор сайта.
         * Задачи проекта: Открывать сайт в промежуток времени.
         * 
         * World to Me / 2020
         */


        static void Main(string[] args)
        {
            Console.Title = "StasoBombila - 2020";
            Console.SetWindowSize(90, 20);

            Console.WriteLine("\n\t\t\t\tStasoBombila - 2020\n");
            Console.WriteLine("\tПроект создан в ознакомительных целях.");
            Console.WriteLine($"\tНикогда не изучайте языки программирования\n");
            Settings.GetArgs(args);
            
            if(InternetChecker.GetInternetConnect())
            {
                foreach(string projects in Projects.Get())
                {
                    Work.OpenUrl(projects);
                }
            }
            Console.WriteLine($"\tНажми любую клавишу!");
            Console.ReadLine();
        }
    }
}
