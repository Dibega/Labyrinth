using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    class Friend : Item
    {
        static Random rnd = new Random();
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
            user.HealPoints += rnd.Next(-1, 2);
            user.Location = m_myLocation;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
    }
}
