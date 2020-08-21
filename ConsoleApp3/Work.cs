using System;

namespace ConsoleApp3
{
    public static class Work
    {
        public static void OpenUrl(string nameProject)
        {
            if (InternetChecker.GetInternetConnect())
                switch (nameProject)
                {
                    case "-w2me":
                        Console.WriteLine("Wait for 1 min");
                        new Project { URL = "https://w2me.ru/", Time = 1 }.Start();
                        break;
                    case "-klink":
                        Console.WriteLine("Wait for 2 min");
                        new Project { URL = "https://klinklinom.video.blog/", Time = 2 }.Start();
                        break;
                    default:
                        Console.WriteLine("Wait for 3 min");
                        new Project { URL = "https://yandex.ru/", Time = 2 }.Start();
                        break;
                }
        }
    }
}
