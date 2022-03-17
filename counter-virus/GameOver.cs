using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter_virus
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close(); // need to restart game
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Home homePage = new Home(); // error
            homePage.Show();
            Game game = new Game();
            game.Close();
            this.Close();
        }
    }
}
