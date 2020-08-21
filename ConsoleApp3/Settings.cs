using System;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    public class Settings
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void GetArgs(string[] args)
        {
            if(isArgs(args))
            {
                /*
                * @args one: 
                * no-window - Не открывать окно консольное приложения.
                * open-window - Открывать окно программы.
                * TODO: Пока не реализовано.
                */
                var handle = GetConsoleWindow();

                switch (args[0])
                {
                    case "-nw":
                    ShowWindow(handle, 0);
                        break;
                    case "-ow":
                    ShowWindow(handle, 5);
                        break;
                    default:
                        Color.SetterColor( ConsoleColor.Red, false);
                        Console.WriteLine("Use main arguments -nw or -ow");
                        Console.ResetColor();
                        break;
                }
                /*
                 * @args two / three / four: 
                 * Активно работают -w2me -klink
                 * Названия проектов, с которыми будем работать =D
                 */
                ArgsToProject(args);
            }
            else
            {
                Projects.Add("-w2me");
                Color.SetterColor(ConsoleColor.Red, false);
                Console.WriteLine("Standard project -w2me");
                Console.ResetColor();
            }
                
        }
        /*
         * Простая проверка нахождения аргументов.
         */
        private static bool isArgs(string[] args)
        {
            return args.Length > 0 ? true : false;
        }
        /*
        * Добавляем аргументы от 1 нахождения. 0 не учитываем, т.к см. @args one.
        */
        private static void ArgsToProject(string[] args)
        {
            for (int x = 1; x <= args.Length - 1; x++)
            {
                if (!string.IsNullOrEmpty(args[x]))
                {
                    Projects.Add(args[x]);
                    Console.WriteLine(args[x]);
                }
            }
        }
    }

    public static class Color
    {
        /*
         * Простая установка цвета консоли.
         * Хрен знает насколько правильно, главное работает =D
         */
        public static void SetterColor(ConsoleColor color, bool bColor )
        {
            if(bColor == true) 
                Console.BackgroundColor = color;
                    else
                Console.ForegroundColor = color;
        }
    }

}
