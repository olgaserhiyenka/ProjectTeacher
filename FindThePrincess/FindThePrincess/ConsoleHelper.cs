using FindThePrincess.Models.Maps;
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

        public static void PrintMap(Map map)
        {
            var letterOfHero=map.HeroOnMap.Hero.Name[0].ToString().ToUpper();

            for(var i = 0; i < map.XSize; i++)
            {
                for (var j = 0; j < map.YSize; j++)
                {
                    if (map.HeroOnMap.Position.XCoordinate == i && map.HeroOnMap.Position.YCoordinate == j)
                    {
                        Console.WriteLine(letterOfHero);
                    }
                    else
                    {
                        Console.WriteLine('*');
                    }
                }
                //if (map)
                //{ }
            }
        }
    }
}
