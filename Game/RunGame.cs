using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Labyrinth.Game
{
    class RunGame
    {
        int m_stateGame = 0;
        Random m_rnd = new Random();
        static IInteractable[,] m_labirinth;
        Player m_user;

        public void Events(int stateCase, List<RichTextBox> rtb_List)
        {
            UpdateView(rtb_List);
            switch (stateCase)
            {
                case 1: //moveUp
                    if (m_stateGame != 0)
                    {
                        m_user.MoveAndInteract(-1, 0);
                    }
                    break;
                case 2: //moveDown
                    if (m_stateGame != 0)
                    {
                        m_user.MoveAndInteract(1, 0);
                    }
                    break;

                case 3: //moveLeft
                    if (m_stateGame != 0)
                    {
                        m_user.MoveAndInteract(0, -1);
                    }
                    break;
                case 4: //moveRight
                    if (m_stateGame != 0)
                    {
                        m_user.MoveAndInteract(0, 1);
                    }
                    break;
                case 5: //StartNewGameByGenerateLabirinth
                    m_stateGame = 1;
                    m_labirinth = ReadWallsFromFileInlabirinth();
                    GenerateItemsInLabirinth();
                    m_user = new Player(new DeafaultMove(m_labirinth));
                    break;
            }
            m_user.CheckWin();
            UpdateView(rtb_List);
        }


        private void UpdateView(List<RichTextBox> rtb_List)
        {
            if (m_labirinth != null)
            {
                ClearAllRTB(rtb_List);
                UpdateLabitinthView(rtb_List[0]);
                UpdateStats(rtb_List[1]);
            }
        }
        private void UpdateStats(RichTextBox rtb)
        {
            string line = string.Format("Состояние игрока\nЗдоровье: {0}\nСостояние выигрыша: {1}",m_user.HealPoints,m_user.Win);
            rtb.Text = line;
        }
        private void UpdateLabitinthView(RichTextBox rtb_Labirinth)
        {
            string line = "";
            PointLabirinth userPoint = m_user.Location;
            for (int i = userPoint.x - 1; i <= userPoint.x + 1; i++)
            {
                for (int j = userPoint.y - 1; j <= userPoint.y + 1; j++)
                {
                    if (userPoint.x != i || userPoint.y != j)
                    {
                        IInteractable item = m_labirinth[i, j];
                        if (item != null)
                        {
                            line += m_labirinth[i, j].Symbol;
                        }
                        else
                        {
                            line += "   ";
                        }
                    }
                    else
                    {
                        line += "P";
                    }
                }
                line += "\n";
            }
            rtb_Labirinth.Text = line;
        }
        private void ClearAllRTB(List<RichTextBox> rtb_List)
        {
            foreach (var el in rtb_List)
            {
                el.Clear();
            }
        }

        private void CheckGameState()
        {

        }
        private static IInteractable[,] ReadWallsFromFileInlabirinth()
        {
            StreamReader strLabirinth = new StreamReader("Labirinth.txt");
            IInteractable[,] labirinth = new IInteractable[20, 20];
            AddWalls(strLabirinth, ref labirinth);
            return labirinth;
        }
        private static void AddWalls(StreamReader strLabirinth, ref IInteractable[,] labirinth)
        {
            string line = "";
            int count = 0;

            while ((line = strLabirinth.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    char simbol = line[i];
                    if (simbol == 'w')
                    {
                        PointLabirinth point = new PointLabirinth(count, i);
                        Wall wall = new Wall(point, labirinth);
                        labirinth[count, i] = wall;
                    }
                }
                count++;
            }
        }
        private void GenerateItemsInLabirinth()
        {
            for (int i = 0; i <= m_labirinth.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= m_labirinth.GetUpperBound(1); j++)
                {
                    if (m_labirinth[i, j] == null)
                    {
                        PointLabirinth point = new PointLabirinth(i, j);
                        m_labirinth[i, j] = GetOrNotRandomItem(point);
                    }
                }
            }
        }
        private IInteractable GetOrNotRandomItem(PointLabirinth point)
        {
            int i = m_rnd.Next(0, 3);
            if (i == 2)
            {
                return GetRandomInteractableClass(point);
            }
            else
            {
                return null;
            }

        }
        private IInteractable GetRandomInteractableClass(PointLabirinth point)
        {
            int i = m_rnd.Next(0, 7);
            IInteractable obj = null;

            if (i == 1)
            {
                obj = new Teleport(point, m_labirinth);
            }
            if (i == 2)
            {
                obj = new Undead(point, m_labirinth);
            }
            if (i == 3)
            {
                obj = new Bandit(point, m_labirinth);
            }
            if (i == 4)
            {
                obj = new Hill(point, m_labirinth);
            }
            if (i == 5)
            {
                obj = new Grave(point, m_labirinth);
            }
            if (i == 6)
            {
                obj = new God(point, m_labirinth);
            }

            return obj;
        }
    }
}
