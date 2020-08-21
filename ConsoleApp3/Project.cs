using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Project
    {
        /// <summary>
        /// URL для открытия приложением
        /// </summary>
        public string URL{ get;set;}
        /// <summary>
        /// Время в минутах!
        /// </summary>
        public int Time { get; set; }

        /*
         * Запускаем процесс. 
         * мс превращаем в минуты. Можно дополнить код и присваивать от главного класса. 
         */
        public void Start()
        {
            for(int x = 0; x < 5; x++)
            {
                Thread.Sleep(Time * 60000);
                Process.Start(URL);
                Console.WriteLine("Open site: {0} time: {1}min. Success", URL, Time);
            }
        }
    }
}
