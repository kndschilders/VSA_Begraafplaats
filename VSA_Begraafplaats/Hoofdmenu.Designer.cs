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
            this.pbxGraveyard = new System.Windows.Forms.PictureBox();
            this.trbYear = new System.Windows.Forms.TrackBar();
            this.lblSliderYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMapCoords = new System.Windows.Forms.Label();
            this.menustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraveyard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYear)).BeginInit();
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
            this.menustrip.Size = new System.Drawing.Size(1383, 24);
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
            // pbxGraveyard
            // 
            this.pbxGraveyard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxGraveyard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGraveyard.Image = global::VSA_Begraafplaats.Properties.Resources.begraafplaats;
            this.pbxGraveyard.Location = new System.Drawing.Point(12, 36);
            this.pbxGraveyard.Name = "pbxGraveyard";
            this.pbxGraveyard.Size = new System.Drawing.Size(1359, 526);
            this.pbxGraveyard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGraveyard.TabIndex = 0;
            this.pbxGraveyard.TabStop = false;
            this.pbxGraveyard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxGraveyard_Paint);
            this.pbxGraveyard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxGraveyard_MouseClick);
            this.pbxGraveyard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxGraveyard_MouseMove);
            // 
            // trbYear
            // 
            this.trbYear.Location = new System.Drawing.Point(115, 568);
            this.trbYear.Maximum = 2100;
            this.trbYear.Minimum = 1900;
            this.trbYear.Name = "trbYear";
            this.trbYear.Size = new System.Drawing.Size(1187, 45);
            this.trbYear.TabIndex = 2;
            this.trbYear.Value = 2016;
            this.trbYear.ValueChanged += new System.EventHandler(this.trbYear_ValueChanged);
            // 
            // lblSliderYear
            // 
            this.lblSliderYear.AutoSize = true;
            this.lblSliderYear.Location = new System.Drawing.Point(1320, 584);
            this.lblSliderYear.Name = "lblSliderYear";
            this.lblSliderYear.Size = new System.Drawing.Size(31, 13);
            this.lblSliderYear.TabIndex = 3;
            this.lblSliderYear.Text = "2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1900";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1271, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "2000";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 568);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(97, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // lblMapCoords
            // 
            this.lblMapCoords.AutoSize = true;
            this.lblMapCoords.Location = new System.Drawing.Point(164, 647);
            this.lblMapCoords.Name = "lblMapCoords";
            this.lblMapCoords.Size = new System.Drawing.Size(22, 13);
            this.lblMapCoords.TabIndex = 6;
            this.lblMapCoords.Text = "0,0";
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 713);
            this.Controls.Add(this.lblMapCoords);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSliderYear);
            this.Controls.Add(this.trbYear);
            this.Controls.Add(this.pbxGraveyard);
            this.Controls.Add(this.menustrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menustrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hoofdmenu";
            this.ShowIcon = false;
            this.Text = "Hoofdmenu";
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraveyard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGraveyard;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tijdelijkOpenGrafGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafToolStripMenuItem;
        private System.Windows.Forms.TrackBar trbYear;
        private System.Windows.Forms.Label lblSliderYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMapCoords;

    }
}