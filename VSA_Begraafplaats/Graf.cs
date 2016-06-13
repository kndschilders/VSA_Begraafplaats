using Klassenlaag;
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
    public partial class Graf : Form
    {
        public Graf(GraveSpread graveSpread)
        {
            InitializeComponent();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            Form contractForm = new Contract();
            contractForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
