using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class Grave : Item
    {
        public override char Symbol
        {
            get
            {
                return 'g';
            }
        }
        public Grave(PointLabirinth newLocation, IInteractable[,] labirinth):base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
            user.HealPoints = 0;
            user.Location = m_myLocation;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
    }
}
