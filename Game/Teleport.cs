using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class Teleport : Item
    {
        public override char Symbol
        {
            get
            {
                return 'T';
            }
        }
        public Teleport(PointLabirinth newLocation,IInteractable[,] labirinth):base(newLocation)
        {
            m_labirinth = labirinth;
        }
        public override void Interact(Player user)
        {
            PointLabirinth point = user.Location;
            while (FindPoint(ref point))
            {
            }
            user.Location = point;
            m_labirinth[m_myLocation.x, m_myLocation.y] = null;
        }
        private bool FindPoint(ref PointLabirinth point)
        {
            Random r = new Random();
            int x = m_labirinth.GetLowerBound(0);
            int y = m_labirinth.GetUpperBound(1);
            PointLabirinth local_point = new PointLabirinth(r.Next(x, y), r.Next(x, y));
            if (m_labirinth[local_point.x, local_point.y] as Wall == null)
            {
                point = local_point;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
