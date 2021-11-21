using FindThePrincess.Models.Maps.Heroes;
using FindThePrincess.Models.Heroes;
using FindThePrincess.Models.Maps.Opponents;
using FindThePrincess.Models.Opponents;
using System.Collections.Generic;
using System;

namespace FindThePrincess.Models.Maps
{
    public class Map
    {
        #region Map Info

        public int XSize { get; private set; }

        public int YSize { get; private set; }

        public HeroOnMap HeroOnMap { get; private set; }

        public List<OpponentOnMap> Opponents { get; private set; }

        #endregion

        public Map(
            int xSize,
            int ySize)
        {
            XSize = xSize;

            YSize = ySize;

            Opponents = new List<OpponentOnMap>();
        }

        public void InitHeroOnMap(Hero hero)
        {

        }

        public void InitOpponentOnMap(List<IOpponent> opponents)
        {
            var currentCount = 0;

            var random = new Random();

            // расставляем 10 ловушек
            foreach(var opponent in opponents)
            {
                do
                {
                   var temporarityRow = temporarity / 10;

                    var temporarityCol = temporarity % 10;

                    if (true)
                    {
                        Opponents.Add(new(
                            opponent: opponent, 
                            position: new(
                                xCoordinate: temporarityRow, 
                                yCoordinate: temporarityCol)));

                        break;
                    }
                } while (true);

                //var temporarityDamag = random.Next(40);

                //Orc temporarityOrc = new("A", 1, temporarityDamag);
            }
        }

        public void InitialHeroOnMap(string NameOfHero)
        {
            var rand = new Random();

            var temporarity = rand.Next(100);

            var temporarityX = temporarity / 10;

            var temporarityY = temporarity % 10;

            //   HeroOnMap.Hero.Name = NameOfHero;
            Hero temporarityHero = new(NameOfHero);

            Position temporarityPosition = new(temporarityX, temporarityY);

            HeroOnMap temporarityHeroOnMap = new(temporarityHero, temporarityPosition);

            HeroOnMap = temporarityHeroOnMap;

        }

        //public bool IsCoordinateInculeSomething(
        //    int XCoordinate,
        //    int Y)
        //{
        //    return true;        
        //}
    }
}
