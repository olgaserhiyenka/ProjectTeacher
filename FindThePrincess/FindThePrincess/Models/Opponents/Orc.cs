namespace FindThePrincess.Models.Opponents
{
    public class Orc : IOpponent
    {
        public string Name { get; private set; }

        public string Level { get; private set; }

        public int Damage { get; private set; }

        public Orc(
            string name = "Orc",
            string level = "Level 1",
            int damage = 40)
        {
            Name = name;

            Level = level;

            Damage = damage;
        }
    }
}
