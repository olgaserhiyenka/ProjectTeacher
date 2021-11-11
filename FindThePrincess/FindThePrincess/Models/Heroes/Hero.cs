namespace FindThePrincess.Models.Heroes
{
    public class Hero
    {
        private readonly int _maxHealthPoint;

        public string Name { get; private set; }

        public int Health { get; private set; }

        public Hero(
            string name,
            int health = 100,
            int maxHealthPoint = 100)
        {
            Name = name;

            Health = health;

            _maxHealthPoint = maxHealthPoint;
        }

        public void Damage(int healthPoints)
        {
            if(healthPoints > 0)
            {
                Health -= healthPoints;

                if(Health < 0)
                {
                    Health = 0;
                }
            }
        }

        public void Healing(int healthPoints)
        {
            if (healthPoints > 0)
            {
                Health += healthPoints;

                if (Health > _maxHealthPoint)
                {
                    Health = _maxHealthPoint;
                }
            }
        }
    }
}
