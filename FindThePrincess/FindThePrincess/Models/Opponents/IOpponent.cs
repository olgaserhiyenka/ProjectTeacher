namespace FindThePrincess.Models.Opponents
{
    public interface IOpponent
    {
        string Name { get; }

        string Level { get; }

        int Damage { get; }
    }
}
