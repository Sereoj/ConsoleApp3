using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Projects
    {   
        /*
         * Подобие менеджера для работы с проектами.
         * Бесполезная вещь, но почему бы не сделать .-.
         */
        private static List<string> projects = new List<string>();

        public Projects(string nameProject)
        {
            if(string.IsNullOrWhiteSpace(nameProject))
                Console.WriteLine("Name Project{0} is nulled!", nameProject);
        }

        public static void Add(string nameProject)
        {
            projects.Add(nameProject);
        }

        public static List<string> Get()
        {
            return projects;
        }


    }
}
