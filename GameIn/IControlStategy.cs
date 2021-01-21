using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public interface IControlStategy
    {
        void MoveAndInteract(int newX, int newY, Player user);
    }
}
