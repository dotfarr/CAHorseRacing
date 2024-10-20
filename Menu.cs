using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    internal class Menu
    {

        public int DisplayMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Welcome to the Horse Racing App LTDA");
            Console.WriteLine("Please Select one of the options below:");
            Console.WriteLine("Horserace Managers Select 1");
            Console.WriteLine("Horse Owners Select 2");
            Console.WriteLine("Racegoers Select 3");
            Console.WriteLine("To exit select 4");
            Console.WriteLine("*******************");
            Console.WriteLine();

            int MenuOptionSelected = int.Parse(Console.ReadLine());

            return MenuOptionSelected;

        }



    }
}
