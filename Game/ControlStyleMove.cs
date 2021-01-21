using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class ControlStyleMove : IControlStategy
    {
        protected IInteractable[,] m_labirinth;
        public virtual void MoveAndInteract(int newX,int newY, Player user)
        {
        }
        public ControlStyleMove(IInteractable[,] labirinth)
        {
            m_labirinth = labirinth;
        }
        protected void MoveAndInteractWithPlayer(int x, int y,Player user)
        {
            PointLabirinth newPoint = user.Location;
            newPoint.x += x;
            newPoint.y += y;

            IInteractable l = m_labirinth[newPoint.x, newPoint.y];
            if (l != null)
            {
                l.Interact(user);
            }
            if (l == null)
            {
                user.Location = newPoint;
            }
        }
    }
}
