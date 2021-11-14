namespace FindThePrincess.Models.Opponents
{
    public interface IOpponent
    {
        string Name { get; }

        int Level { get; }

        int Damage { get; }
    }
}
