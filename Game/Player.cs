using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Game
{
    public class Player
    {
        int m_Win = 0;
        int m_heelPoints = 3;
        PointLabirinth m_location = new PointLabirinth(1, 1);
        IControlStategy m_moveStyle;
        public Player(IControlStategy moveStyle)
        {
            m_moveStyle = moveStyle;
        }

        public IControlStategy MoveStyle
        {
            set
            {
                m_moveStyle = value;
            }
            get
            {
                return m_moveStyle;
            }
        }
        public PointLabirinth Location
        {
            set
            {
                m_location = value;
            }
            get
            {
                return m_location;
            }
        }
        public int HealPoints
        {
            set
            {
                m_heelPoints = value;
            }
            get
            {
                return m_heelPoints;
            }
        }
        public int Win
        {
            set
            {
                if (value == 1)
                {
                    m_Win = 1;
                }
            }
            get
            {
                return m_Win;
            }
        }
        public void MoveAndInteract(int newX,int newY)
        {
            m_moveStyle.MoveAndInteract(newX, newY, this);
        }
        public void CheckWin()
        {
            if (m_heelPoints <= 0)
            {
                m_Win = -1;
            }
        }
    }
}
