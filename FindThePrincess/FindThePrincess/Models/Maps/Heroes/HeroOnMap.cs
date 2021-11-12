using FindThePrincess.Models.Heroes;

namespace FindThePrincess.Models.Maps.Heroes
{
    public class HeroOnMap
    {
        public Hero Hero { get; private set; }

        public Position Position { get; private set; }

        public HeroOnMap(
            Hero hero,
            Position position)
        {
            Hero = hero;

            Position = position;
        }
    }
}
