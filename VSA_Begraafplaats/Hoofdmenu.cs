using Klassenlaag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSA_Begraafplaats
{
    public partial class Hoofdmenu : Form
    {
        List<GraveLocation> graves = new List<GraveLocation>();

        private struct mapText
        {
            public string Text;
            public int X;
            public int Y;
            public bool Visible;
        }

        mapText maptext = new mapText();

        public Hoofdmenu()
        {
            InitializeComponent();
            this.pbxGraveyard.MouseWheel += pbxGraveyard_MouseWheel;

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MMMM";
            dtpDate.ShowUpDown = true;

            DataAccess.GetCemeteryInformation(1, DateTime.Now );
        }

        public void SetLoggedIn(bool loggedIn)
        {
            if (loggedIn)
            {
                // User is logged in
            } else
            {
                // User  is logged out
            }
        }

        private void pbxGraveyard_MouseWheel(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Scroll wheel used!\nButton:" + e.Delta);
        }

        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new Inloggen(this);
            loginForm.Show();
        }

        private void trbYear_ValueChanged(object sender, EventArgs e)
        {
            this.lblSliderYear.Text = Convert.ToString(this.trbYear.Value);
        }

        private void pbxGraveyard_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMapCoords.Text = string.Format("{0},{1}",e.X,e.Y);
            this.maptext.Visible = false;

            foreach (GraveLocation g in graves)
            {
                if (e.X >= (g.Location.X - 10) && e.X <= (g.Location.X + 10) &&
                    e.Y >= (g.Location.Y - 10) && e.Y <= (g.Location.Y + 10))
                {
                    this.maptext.Text = "Grave #" + graves.IndexOf(g);
                    this.maptext.X = (int)g.Location.X;
                    this.maptext.Y = (int)g.Location.Y;
                    this.maptext.Visible = true;

                    break;
                }
            }

            this.pbxGraveyard.Invalidate();
        }

        private void pbxGraveyard_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if mouse is hovering over a grave location
            GraveLocation grave = null;

            foreach (GraveLocation g in graves)
            {
                if (e.X >= (g.Location.X - 10) && e.X <= (g.Location.X + 10) &&
                    e.Y >= (g.Location.Y - 10) && e.Y <= (g.Location.Y + 10))
                {
                    grave = g;

                    break;
                }
            }

            if (grave != null)
            {
                //get cemetery from controller
                //get grave spreads
                //find grave spread with given grave location

                // Open grave gui
                //Form form = new Graf();
                //form.Show();
            } else {
                //graves.Add(new GraveLocation(e.X - 2, e.Y - 2));
                MessageBox.Show("New Gravelocation");
                //Form form = new Graf();

                this.pbxGraveyard.Invalidate();
            }
        }

        private void pbxGraveyard_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraveLocation g in graves)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), g.Location.X, g.Location.Y, 5, 5);
            }

            // Draw text
            if (this.maptext.Visible)
            {
                Font f = new Font("Arial", 12);
                SizeF stringSize = e.Graphics.MeasureString(this.maptext.Text, f);
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(Convert.ToInt32(maptext.X - (stringSize.Width/2)), Convert.ToInt32(maptext.Y - (stringSize.Height/2) - 5), Convert.ToInt32(stringSize.Width), Convert.ToInt32(stringSize.Height)));
                e.Graphics.DrawString(this.maptext.Text, f, new SolidBrush(Color.Black), this.maptext.X - (stringSize.Width / 2), this.maptext.Y - (stringSize.Height / 2) - 5);
            }
        }

        private void grafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newReservationForm = new NewReservation();
            newReservationForm.Show();
        }
    }
}
