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

        public int CountOfMoves { get; private set; }
        //2D image of the map
        public char[,] ArrayOfMap { get; private set; }

        //Logic of determining the position of the hero on the map at the time of the start
        private Position InitHeroPosition()
        {
            var random = new Random();

            Position temporarityPosition;

            //Define one of the 4 corners of the map
            var temporarityNumber = random.Next(3);

            //Translate the number of corner  into coordinates
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

        private static Hero InitHero()
        {
            return ConsoleGameHelper.InitHero();
        }

        //Initialization the map image
        private void InitArrayOfMap()
        {
            ArrayOfMap = new char[Map.XSize, Map.YSize];

            for (var i = 0; i < Map.XSize; i++)
            {
                for (var j = 0; j < Map.YSize; j++)
                {
                    ArrayOfMap[i, j] = '*';

                }
            }
        }

        //Create the map and start creating the map image
        public void InitGame()
        {
            Map = ConsoleGameHelper.InitMap();

            InitArrayOfMap();

            var temporarityHero = InitHero();

            var temporarityPosition = InitHeroPosition();

            HeroOnMap temporarityHeroOnMap = new(temporarityHero, temporarityPosition);

            Map.InitHeroOnMap(temporarityHeroOnMap);

            var temporarityOpponentsOnMap= InitOpponentsOnMap();

            Map.InitOpponentOnMap(temporarityOpponentsOnMap);

            CountOfMoves = ConsoleGameHelper.DefinitionCountOfMoves();
        }

        //Creating opponents and determining their position on the map
        public List<OpponentOnMap> InitOpponentsOnMap()
        {
            var list = new List<OpponentOnMap>();

            var countOfOpponent = ConsoleGameHelper.DefinitionCountOfOpponents(); 
            
            var random = new Random();

            Orc newOrc;

            for (var i = 0; i < countOfOpponent; i++)
            {
                var temoparityDamage = random.Next(DefaultValues.MinDamage, DefaultValues.MaxDamage);

                newOrc = new Orc(
                    name: $"Orc №{i + 1}",
                    level: 1,
                    damage: temoparityDamage);

                int temporarityXPosition;

                int temporarityYPosition;

                while (true)
                {
                    temporarityXPosition = random.Next(0, Map.XSize);

                    temporarityYPosition = random.Next(0, Map.YSize);

                    if (ArrayOfMap[temporarityXPosition, temporarityYPosition] == '*')
                    {
                        ArrayOfMap[temporarityXPosition, temporarityYPosition] = 'x';

                        break;
                    }
                }

                var temporarityPosition = new Position(temporarityXPosition, temporarityYPosition);

                var temporarityOpponentOnMap = new OpponentOnMap(newOrc, temporarityPosition);

                list.Add(temporarityOpponentOnMap);
            }

            return list;
        }

        public (string, int, int) GetStatus()
        {
            var nameOfHero = Map.HeroOnMap.Hero.Name;

            var healsOfHero = Map.HeroOnMap.Hero.Health;

            var status = (nameOfHero, healsOfHero, CountOfMoves);

            return status;
        }

        public void MoveHero(Position theСhangePosition)
        {
            Map.HeroOnMap.Position = theСhangePosition;

        }
    }
}
