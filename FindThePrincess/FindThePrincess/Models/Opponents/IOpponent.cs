using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePrincess.Models.Opponents
{
    public interface IOpponent
    {
        string Name { get; }

        string Level { get; }

        int Damage { get; }
    }
}
