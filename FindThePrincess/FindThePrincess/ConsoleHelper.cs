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

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMap(Map map)
        {
            map.HeroOnMap.Hero.Name[0].ToString().ToUpper();

            for(int i = 0; i < map.XSize; i++)
            {
                if(map.)
            }
        }
    }
}
