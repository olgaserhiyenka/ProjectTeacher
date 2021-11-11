namespace FindThePrincess.Models.Maps
{
    public class Position
    {
        public int XCoordinate { get; private set; }

        public int YCoordinate { get; private set; }

        public Position(
            int xCoordinate = 0,
            int yCoordinate = 0)
        {
            XCoordinate = xCoordinate;

            YCoordinate = yCoordinate;
        }
    }
}
