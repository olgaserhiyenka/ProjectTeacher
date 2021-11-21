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

        public List<OpponentOnMap> Opponents { get; private set; }

        #endregion

        public HeroOnMap HeroOnMap { get; private set; }

        public Map(
            HeroOnMap heroOnMap,
            List<OpponentOnMap> opponents)
        {
            HeroOnMap = heroOnMap;

            Opponents = opponents;
        }

        public void InitialOpponentOnMap(int countOfOpponent)
        {
            var currentCount = 0;
            var rand = new Random();
            while (currentCount < countOfOpponent) // расставляем 10 ловушек
            {
                var temporarity = rand.Next(100);

                var temporarityRow = temporarity / 10;

                var temporarityCol = temporarity % 10;

                Position temporarityPosition = new (temporarityRow, temporarityCol);
                
                var temporarityDamag= rand.Next(40);
                             
                Orc temporarityOrc=new ("A",1, temporarityDamag);

                OpponentOnMap temporarityOrcInMap=new (temporarityOrc, temporarityPosition);

                Opponents.Add(temporarityOrcInMap);

                currentCount++;

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
