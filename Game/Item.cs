using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public abstract class Item : IInteractable
    {
        protected PointLabirinth m_myLocation;
        protected IInteractable[,] m_labirinth;
        abstract public void Interact(Player user);
        abstract public char Symbol
        {
            get;
        }
        protected Item(PointLabirinth newLocation)
        {
            m_myLocation = newLocation;
        }
    }
}
