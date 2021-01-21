using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    class DeafaultMove : ControlStyleMove
    {
        public DeafaultMove(IInteractable[,] labirinth):base(labirinth)
        {
        }
        public override void MoveAndInteract(int newX, int newY, Player user)
        {
            MoveAndInteractWithPlayer(newX, newY,user);
        }
    }
}
