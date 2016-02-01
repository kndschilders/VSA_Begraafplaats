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
            this.menuitem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menustrip
            // 
            this.menustrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem1ToolStripMenuItem,
            this.inloggenToolStripMenuItem});
            this.menustrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(1061, 24);
            this.menustrip.TabIndex = 1;
            this.menustrip.Text = "menuStrip1";
            // 
            // menuitem1ToolStripMenuItem
            // 
            this.menuitem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item2ToolStripMenuItem});
            this.menuitem1ToolStripMenuItem.Name = "menuitem1ToolStripMenuItem";
            this.menuitem1ToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuitem1ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.menuitem1ToolStripMenuItem.Text = "Menuitem1";
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item1ToolStripMenuItem.Text = "item1";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item2ToolStripMenuItem.Text = "item2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(101, 6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VSA_Begraafplaats.Properties.Resources.begraafplaats;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 452);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem menuitem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;

    }
}

