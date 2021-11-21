using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePrincess
{
    public static class ConsoleGameHelper
    {
        public static void Start()
        {
            ConsoleHelper.PrintMessage("Как Вы хотете назвать героя?");

            var NameOfHero=  ConsoleHelper.GetSting();

            ConsoleHelper.PrintMessage("Укажите размер карты ");

            var x= Convert.ToInt32(ConsoleHelper.GetSting());

            ConsoleHelper.PrintMessage("Укажите число бомб");

            var n = Convert.ToInt32(ConsoleHelper.GetSting());

        }
    }
}
