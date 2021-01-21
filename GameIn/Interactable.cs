using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public interface IInteractable
    {
        void Interact(Player user);
        char Symbol { get; }
    }
}
