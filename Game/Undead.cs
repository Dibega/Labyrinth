using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class Undead : Item
    {
        public override char Symbol
        {
            get
            {
                return 'U';
            }
        }
        public Undead(PointLabirinth newLocation, IInteractable[,] labirinth):base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
            user.MoveStyle = new RandomMove(m_labirinth);
            user.Location = m_myLocation;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
    }
}
