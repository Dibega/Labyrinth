using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class Wall : Item
    {
        public override char Symbol
        {
            get
            {
                return 'W';
            }
        }
        public Wall(PointLabirinth newLocation, IInteractable[,] labirinth):base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
        }
    }
}
