﻿using FindThePrincess.Models.Maps.Heroes;
using FindThePrincess.Models.Opponents;
using System.Collections.Generic;

namespace FindThePrincess.Models.Maps
{
    public class Map
    {
        #region Map Info

        public int XSize { get; private set; }

        public int YSize { get; private set; }

        public List<IOpponent> Opponents { get; private set; }

        #endregion

        public HeroOnMap HeroOnMap { get; private set; }

        public Map(
            HeroOnMap heroOnMap,
            List<IOpponent> opponents)
        {
            HeroOnMap = heroOnMap;

            Opponents = opponents;
        }
    }
}