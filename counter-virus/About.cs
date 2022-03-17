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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnAboutBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
