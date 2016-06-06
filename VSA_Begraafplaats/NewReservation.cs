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
    public partial class NewReservation : Form
    {
        public NewReservation()
        {
            InitializeComponent();

            this.cbDuur.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
