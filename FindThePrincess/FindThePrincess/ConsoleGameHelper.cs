using FindThePrincess.Models.Heroes;
using FindThePrincess.Models.Maps;
using FindThePrincess.Models.Opponents;
using System;
using System.Collections.Generic;

namespace FindThePrincess
{
    public static class ConsoleGameHelper
    {
        public static void Start()
        {
            var map = InitMap();
        }

        public static Map InitMap()
        {
            var hero = InitHero();

            var xMapSize = ConsoleHelper.GetIntFromConsole(message: "Укажите длину карты");

            var yMapSize = ConsoleHelper.GetIntFromConsole(message: "Укажите ширину карты");

            var map = new Map(
                xSize: xMapSize,
                ySize: yMapSize);

            map.InitHeroOnMap(hero);

            map.InitOpponentsOnMap(InitOpponents());
        }

        public static Hero InitHero()
        {
            ConsoleHelper.PrintMessage("Как Вы хотете назвать героя?");

            var nameOfHero = ConsoleHelper.GetSting();

            var hero = new Hero(nameOfHero);

            return hero;
        }

        public static List<IOpponent> InitOpponents()
        {
            var list = new List<IOpponent>();

            for (var i = 0; i < 10; i++)
            {
                var orc = new Orc(
                    name: $"Orc №{i + 1}",
                    level: 1,
                    damage: 60);

                list.Add(orc);
            }

            return list;
        }
    }
}
