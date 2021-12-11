using FindThePrincess.Models.Opponents;
using FindThePrincess.Models;
using System;
using System.Collections.Generic;

namespace FindThePrincess
{
    class Program
    {
        static void Main()
        {
            var game= new Game();

            game.InitGame();

            ConsoleHelper.PrintMap(game);

            ConsoleHelper.PrintMessage(ConsoleGameHelper.FormPlayerStatus(game.GetStatus()));

            //while (true)
            //{
            //    Console.WriteLine("Вы готовы начать?");

            //    if (false)
            //    {
            //        //break;
            //    }
            //    else
            //    {
            //        ConsoleGameHelper.Start();
            //    }
            //}
        }
    }
}
