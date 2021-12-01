using FindThePrincess.Models.Maps;
using FindThePrincess.Models.Maps.Heroes;
using FindThePrincess.Models.Heroes;
using FindThePrincess.Models.Maps.Opponents;
using FindThePrincess.Models.Opponents;
using System.Collections.Generic;
using System;

namespace FindThePrincess.Models
{
    public class Game
    {
        public Map Map { get; set; }

        //2D image of the map
        public char[,] ArrayOfMap { get; private set; }

        //Дogic of determining the position of the hero on the map at the time of the start
        private Position InitHeroPosition()
        {
            var random = new Random();

            Position temporarityPosition;

            //определяем один из 4-х углов карты
            var temporarityNumber = random.Next(3);

            //переводи номер угла в координаты
            switch (temporarityNumber)
            {
                case 0:

                    ArrayOfMap[0, 0] = 'H';

                    temporarityPosition = new(0, 0);

                    break;

                case 1:
                    ArrayOfMap[0, Map.YSize - 1] = 'H';

                    temporarityPosition = new(0, Map.YSize - 1);

                    break;

                case 2:
                    ArrayOfMap[Map.XSize - 1, 0] = 'H';

                    temporarityPosition = new(Map.XSize - 1, 0);

                    break;

                default:

                    ArrayOfMap[0, Map.XSize] = 'H';

                    temporarityPosition = new(Map.XSize - 1, Map.YSize - 1);

                    break;

            }

            return temporarityPosition;
        }

        private Hero InitHero()
        {
            return ConsoleGameHelper.InitHero();
        }

        //Создание карты и начало создания образа карты
        public void InitGame()
        {
            Map = ConsoleGameHelper.InitMap();

            ArrayOfMap = new char[Map.XSize, Map.YSize];

            for (var i = 0; i < Map.XSize; i++)
            {
                for (var j = 0; j < Map.YSize; j++)
                {
                    ArrayOfMap[i, j] = '*';

                }
            }

            //  Map.HeroOnMap.Hero = InitialHero();

            var temporarityHero = InitHero();

            var temporarityPosition = InitHeroPosition();

            HeroOnMap temporarityHeroOnMap = new(temporarityHero, temporarityPosition);

            Map.InitialHeroOnMap(temporarityHeroOnMap);
        }

        public void MoveHero()
        {

        }
    }
}
