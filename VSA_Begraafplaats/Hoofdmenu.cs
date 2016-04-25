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
        List<Point> points = new List<Point>();

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
        }

        void pbxGraveyard_MouseWheel(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Scroll wheel used!\nButton:" + e.Delta);
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

        private void trbYear_ValueChanged(object sender, EventArgs e)
        {
            this.lblSliderYear.Text = Convert.ToString(this.trbYear.Value);
        }

        private void pbxGraveyard_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMapCoords.Text = string.Format("{0},{1}",e.X,e.Y);
            this.maptext.Visible = false;

            foreach (Point p in points)
            {
                if (e.X >= (p.X - 10) && e.X <= (p.X + 10) &&
                    e.Y >= (p.Y - 10) && e.Y <= (p.Y + 10))
                {
                    this.maptext.Text = "Grave #" + points.IndexOf(p);
                    this.maptext.X = p.X;
                    this.maptext.Y = p.Y;
                    this.maptext.Visible = true;

                    break;
                }
            }

            this.pbxGraveyard.Invalidate();
        }

        private void pbxGraveyard_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X - 2, e.Y - 2));

            this.pbxGraveyard.Invalidate();
        }

        private void pbxGraveyard_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point p in points)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red),p.X,p.Y,5,5);
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
    }
}
