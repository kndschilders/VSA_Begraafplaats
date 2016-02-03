namespace VSA_Begraafplaats
{
    partial class Hoofdmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tijdelijkOpenGrafGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menustrip
            // 
            this.menustrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inloggenToolStripMenuItem,
            this.tijdelijkOpenGrafGUIToolStripMenuItem,
            this.nieuwToolStripMenuItem});
            this.menustrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(1061, 24);
            this.menustrip.TabIndex = 1;
            this.menustrip.Text = "menuStrip1";
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            this.inloggenToolStripMenuItem.Click += new System.EventHandler(this.inloggenToolStripMenuItem_Click);
            // 
            // tijdelijkOpenGrafGUIToolStripMenuItem
            // 
            this.tijdelijkOpenGrafGUIToolStripMenuItem.Name = "tijdelijkOpenGrafGUIToolStripMenuItem";
            this.tijdelijkOpenGrafGUIToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.tijdelijkOpenGrafGUIToolStripMenuItem.Text = "[Tijdelijk] Open graf GUI";
            this.tijdelijkOpenGrafGUIToolStripMenuItem.Click += new System.EventHandler(this.tijdelijkOpenGrafGUIToolStripMenuItem_Click);
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafToolStripMenuItem});
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            // 
            // grafToolStripMenuItem
            // 
            this.grafToolStripMenuItem.Name = "grafToolStripMenuItem";
            this.grafToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.grafToolStripMenuItem.Text = "Reservering";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VSA_Begraafplaats.Properties.Resources.begraafplaats;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Hoofdmenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menustrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menustrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hoofdmenu2";
            this.ShowIcon = false;
            this.Text = "Hoofdmenu";
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tijdelijkOpenGrafGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafToolStripMenuItem;

    }
}