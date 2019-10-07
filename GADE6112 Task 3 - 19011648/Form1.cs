using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GADE6112_Task_3___19011648
{
    public partial class Form1 : Form
    {
        GameEngine game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new GameEngine(20, 9, txtOut, gpbxMap);
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            if (tmrRound.Enabled == false)
            {
                tmrRound.Enabled = true;
                btnControl.Text = "Pause";
            }
            else
            {
                tmrRound.Enabled = false;
                btnControl.Text = "Play";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            game.Save();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            game.Load();
        }

        private void TmrRound_Tick(object sender, EventArgs e)
        {
            lblRound.Text = "Round: " + game.Round.ToString();
            game.Update();
        }
    }
}
