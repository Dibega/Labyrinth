using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labyrinth.Game;

namespace Labyrinth
{
    public partial class LabirinthForm : Form
    {
        public LabirinthForm()
        {
            InitializeComponent();
        }

        RunGame game = new RunGame();
        List<RichTextBox> rtb_List = new List<RichTextBox>();

        private void btn_GenerateLab_Click(object sender, EventArgs e)
        {
            rtb_List.Clear();
            rtb_List.Add(rtb_Labirinth);
            rtb_List.Add(rtb_PlayerStats);

            game.Init(rtb_List);
        }
        private void btn_Move_Up_Click(object sender, EventArgs e)
        {
            game.Events(1, rtb_List);
        }

        private void btn_Move_Down_Click(object sender, EventArgs e)
        {
            game.Events(2, rtb_List);
        }

        private void btn_Move_Left_Click(object sender, EventArgs e)
        {
            game.Events(3, rtb_List);
        }

        private void btn_Move_Right_Click(object sender, EventArgs e)
        {
            game.Events(4, rtb_List);
        }
    }
}
