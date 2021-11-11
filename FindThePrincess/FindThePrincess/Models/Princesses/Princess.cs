namespace FindThePrincess.Models.Princesses
{
    public class Princess
    {
        public string Name { get; private set; }

        public Princess(string name = "Princess")
        {
            Name = name;
        }
    }
}
