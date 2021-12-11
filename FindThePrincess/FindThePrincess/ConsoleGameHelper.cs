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
            var xMapSize = ConsoleHelper.GetIntFromConsole(message: "Enter length of the card");

            var yMapSize = ConsoleHelper.GetIntFromConsole(message: "Enter width of the card");

            var map = new Map(
                xSize: xMapSize,
                ySize: yMapSize);

            return map;
        }

        public static Hero InitHero()
        {
            ConsoleHelper.PrintMessage("What do you want to name the hero?");

            var nameOfHero = ConsoleHelper.GetSting();

            var hero = new Hero(nameOfHero);

            return hero;
        }
        public static int DefinitionCountOfOpponents()
        {
           var CountOfOpponents = ConsoleHelper.GetIntFromConsole("How many opponents do you need in the game?");

            return CountOfOpponents;
        }

        public static int DefinitionCountOfMoves()
        {
            var CountOfMoves = ConsoleHelper.GetIntFromConsole("How many moves do you need in the game?");

            return CountOfMoves;
        }
    }
}
