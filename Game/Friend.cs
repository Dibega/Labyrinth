using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    class Friend : Item
    {
        public override char Symbol
        {
            get
            {
                return 'F';
            }
        }
        public Friend(PointLabirinth newLocation, IInteractable[,] labirinth) : base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
            int add = StaticRnd.Rnd.Next(0, 2) == 0 ? -1 : 1;
            user.HealPoints += add;
            user.Location = m_myLocation;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
    }
}
