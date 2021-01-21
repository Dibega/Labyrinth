using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    class RandomMove : ControlStyleMove
    {
        int count = 0;
        Random rnd = new Random();
        public RandomMove(IInteractable[,] labirinth):base(labirinth)
        {
        }
        public override void MoveAndInteract(int newX, int newY, Player user)
        {
            if (count != 10)
            {
                newX = rnd.Next(-1, 1);
                newY = rnd.Next(-1, 1);
                MoveAndInteractWithPlayer(newX, newY, user);
            }
            else
            {
                MoveAndInteractWithPlayer(newX, newY, user);
                user.MoveStyle = new DeafaultMove(m_labirinth);
            }
            count++;
        }
    }
}
