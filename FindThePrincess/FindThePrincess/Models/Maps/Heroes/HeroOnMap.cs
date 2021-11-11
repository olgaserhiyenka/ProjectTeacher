using FindThePrincess.Models.Heroes;

namespace FindThePrincess.Models.Maps.Heroes
{
    public class HeroPosition
    {
        public Hero Hero { get; private set; }

        public Position Position { get; private set; }

        public HeroPosition(
            Hero hero,
            Position position)
        {
            Hero = hero;

            Position = position;
        }
    }
}
