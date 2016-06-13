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
    public partial class Inloggen : Form
    {
        private Hoofdmenu hoofdForm;

        private const string password = "admin";

        public Inloggen(Hoofdmenu form)
        {
            InitializeComponent();

            this.hoofdForm = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (this.tbPassword.Text.Equals(password))
            {
                // Show message
                MessageBox.Show("Ingelogd!");

                // Set logged in
                hoofdForm.SetLoggedIn(true);

                // Close this form
                this.Close();
            }
            else
            {
                // Show message
                MessageBox.Show("Het wachtwoord is onjuist!");
            }
        }
    }
}
