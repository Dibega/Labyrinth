using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class God : Item
    {
        public override char Symbol
        {
            get
            {
                return 'G';
            }
        }
        public God(PointLabirinth newLocation, IInteractable[,] labirinth):base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
            user.Win = 1;
            user.Location = m_myLocation;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
    }
}
