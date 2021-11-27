using FindThePrincess.Models.Maps;
using FindThePrincess.Models;
using System;

namespace FindThePrincess
{
    public static class ConsoleHelper
    {
        public static string GetSting()
        {
            var value = Console.ReadLine();

            return value;
        }

        public static int GetIntFromConsole(
            string message = "Input number value",
            string errorMessage = "This is not number!"
            )
        {
            int value;

            PrintMessage(message);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.ForegroundColor = ConsoleColor.Red;

                PrintMessage(errorMessage);

                Console.ResetColor();
            }

            return value;
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMap(Game game)
        {
            var letterOfHero=game.Map.HeroOnMap.Hero.Name[0].ToString().ToUpper();

            for(var i = 0; i < game.Map.XSize; i++)
            {
                for (var j = 0; j < game.Map.YSize; j++)
                {
                   Console.Write(game.ArrayOfMap[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
