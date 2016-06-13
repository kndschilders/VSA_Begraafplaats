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
        /// <summary>
        /// Struct used to contain variables used for a maptext object.
        /// </summary>
        private struct mapText
        {
            public string Text;
            public int X;
            public int Y;
            public bool Visible;
        }

        /// <summary>
        /// A single mapText object. This object will be filled with the info of the
        /// selected grave, and the location will be set to the location of the grave.
        /// </summary>
        private mapText maptext = new mapText();

        /// <summary>
        /// A boolean indicating if the user is logged in.
        /// </summary>
        private bool LoggedIn;

        public Hoofdmenu()
        {
            InitializeComponent();

            // Set loggedIn to false
            this.LoggedIn = false;

            // Bind the mousewheel event to the mousewheel event handler
            this.pbxGraveyard.MouseWheel += pbxGraveyard_MouseWheel;

            // Set the right settings on the datetimepicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MMMM";
            dtpDate.ShowUpDown = true;

            // Get the cemetery info
            DataAccess.GetCemeteryInformation(1, DateTime.Now);
        }

        /// <summary>
        /// Logs the user in/out.
        /// </summary>
        /// <param name="loggedIn">The boolean indicating whether to log the user in or out.</param>
        public void SetLoggedIn(bool loggedIn)
        {
            if (loggedIn)
            {
                // User is logged in
                this.inloggenToolStripMenuItem.Enabled = false;
            } else {
                // User  is logged out
                this.inloggenToolStripMenuItem.Enabled = true;

            }
        }

        /// <summary>
        /// Mousewheel event handler used for zooming the map.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void pbxGraveyard_MouseWheel(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Scroll wheel used!\nButton:" + e.Delta);
        }

        /// <summary>
        /// Inloggen menu button event handler used for showing the login form.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new Inloggen(this);
            loginForm.Show();
        }

        /// <summary>
        /// Trackbar year event hander used to show the gravelocations based on to year.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void trbYear_ValueChanged(object sender, EventArgs e)
        {
            this.lblSliderYear.Text = Convert.ToString(this.trbYear.Value);
        }

        /// <summary>
        /// PictureBox graveyard mousemove event handler used to show the label when
        /// the mouse is hovered over a grave.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void pbxGraveyard_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMapCoords.Text = string.Format("{0},{1}",e.X,e.Y);
            this.maptext.Visible = false;

            if (Controller.Cemetery != null)
            {
                // Loop through all gravelocations to find the right gravelocation.
                foreach (GraveLocation g in Controller.Cemetery.GraveLocations)
                {
                    if (e.X >= (g.Location.X - 10) && e.X <= (g.Location.X + 10) &&
                        e.Y >= (g.Location.Y - 10) && e.Y <= (g.Location.Y + 10))
                    {
                        this.maptext.Text = "Grave " + g.ID;
                        this.maptext.X = (int)g.Location.X;
                        this.maptext.Y = (int)g.Location.Y;
                        this.maptext.Visible = true;

                        break;
                    }
                }
            }

            this.pbxGraveyard.Invalidate();
        }

        /// <summary>
        /// PictureBox graveyard click event handler used to create or show a grave.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void pbxGraveyard_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if mouse is hovering over a grave location
            GraveLocation grave = null;

            if (Controller.Cemetery != null)
            {
                foreach (GraveLocation g in Controller.Cemetery.GraveLocations)
                {
                    if (e.X >= (g.Location.X - 10) && e.X <= (g.Location.X + 10) &&
                        e.Y >= (g.Location.Y - 10) && e.Y <= (g.Location.Y + 10))
                    {
                        grave = g;

                        break;
                    }
                }
            }

            // Check if the grave is not null. If the grave is not null, show the grave
            // information. If the grave is null, add a new grave.
            if (grave != null)
            {
                //get cemetery from controller
                Cemetery cemetery = Controller.Cemetery;

                if (cemetery != null)
                {
                    //get grave spreads
                    List<GraveSpread> graveSpreads = cemetery.GraveSpreads;

                    //find grave spread with given grave location
                    foreach (GraveSpread gs in graveSpreads)
                    {
                        if (gs.GraveLocations.Find(gl => gl.ID == grave.ID) != null)
                        {
                            Form form = new Graf(gs);
                            form.Show();
                        }
                    }
                }
            } else {
                //graves.Add(new GraveLocation(e.X - 2, e.Y - 2));
                // Open a form to add a new grave.
                Form form = new Graf();
                form.Show();

                this.pbxGraveyard.Invalidate();
            }
        }

        /// <summary>
        /// PictureBox graveyard paint event handler, used to paint the gravelocations.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void pbxGraveyard_Paint(object sender, PaintEventArgs e)
        {
            if (Controller.Cemetery != null)
            {
                // Loop through all graves to paint the grave on the PictureBox.
                foreach (GraveLocation g in Controller.Cemetery.GraveLocations)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), g.Location.X, g.Location.Y, 5, 5);
                }
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

        /// <summary>
        /// Graftool menuitem click event handler used to show the new reservation form.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event object.</param>
        private void grafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newReservationForm = new NewReservation();
            newReservationForm.Show();
        }
    }
}
