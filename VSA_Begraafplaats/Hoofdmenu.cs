using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSA_Begraafplaats
{
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new Inloggen();
            loginForm.Show();
        }

        private void tijdelijkOpenGrafGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form graveForm = new Graf();
            graveForm.Show();
        }
    }
}
