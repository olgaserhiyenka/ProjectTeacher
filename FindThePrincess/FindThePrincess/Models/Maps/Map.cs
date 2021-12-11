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

        //public char[,] ArrayOfMap { get; private set; }

        #endregion

        public Map(
            int xSize,
            int ySize)
        {
            XSize = xSize;

            YSize = ySize;

            Opponents = new List<OpponentOnMap>();

        }

        public void InitOpponentOnMap(List<OpponentOnMap> opponents)
        {
            Opponents = opponents;
        }

        public void InitHeroOnMap(HeroOnMap temporarityHeroOnMap)
        {
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
