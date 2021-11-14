using FindThePrincess.Models.Opponents;

namespace FindThePrincess.Models.Maps.Opponents
{
    public class OpponentOnMap
    {
        public IOpponent Opponent { get; private set; }

        public Position Position { get; private set; }

        public OpponentOnMap(
            IOpponent opponent,
            Position position)
        {
            Opponent = opponent;

            Position = position;
        }
    }
}
