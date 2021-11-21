using FindThePrincess.Models.Opponents;
using System;
using System.Collections.Generic;

namespace FindThePrincess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Вы готовы начать?");

                if (false)
                {
                    //break;
                }
                else
                {
                    //ConsoleGameHelper.Start();

                    var list = new List<IOpponent>();

                    for(var i = 0; i < 10; i++)
                    {
                        var orc = new Orc(
                            name: $"Orc №{i + 1}",
                            level: 1,
                            damage: 60);
                    }
                }
            }
        }
    }
}
