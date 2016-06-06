namespace VSA_Begraafplaats
{
    partial class NewReservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDuur = new System.Windows.Forms.ComboBox();
            this.cbGrafNummer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoegGrafToe = new System.Windows.Forms.Button();
            this.lbGrafNummers = new System.Windows.Forms.ListBox();
            this.btnSluit = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDuur);
            this.groupBox1.Controls.Add(this.cbGrafNummer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVoegGrafToe);
            this.groupBox1.Controls.Add(this.lbGrafNummers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg een reservering toe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "jaar";
            // 
            // cbDuur
            // 
            this.cbDuur.FormattingEnabled = true;
            this.cbDuur.Items.AddRange(new object[] {
            "10",
            "20"});
            this.cbDuur.Location = new System.Drawing.Point(93, 123);
            this.cbDuur.Name = "cbDuur";
            this.cbDuur.Size = new System.Drawing.Size(68, 21);
            this.cbDuur.TabIndex = 4;
            // 
            // cbGrafNummer
            // 
            this.cbGrafNummer.FormattingEnabled = true;
            this.cbGrafNummer.Location = new System.Drawing.Point(93, 21);
            this.cbGrafNummer.Name = "cbGrafNummer";
            this.cbGrafNummer.Size = new System.Drawing.Size(97, 21);
            this.cbGrafNummer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graf nummer(s):";
            // 
            // btnVoegGrafToe
            // 
            this.btnVoegGrafToe.Location = new System.Drawing.Point(196, 19);
            this.btnVoegGrafToe.Name = "btnVoegGrafToe";
            this.btnVoegGrafToe.Size = new System.Drawing.Size(58, 23);
            this.btnVoegGrafToe.TabIndex = 1;
            this.btnVoegGrafToe.Text = "Voeg toe";
            this.btnVoegGrafToe.UseVisualStyleBackColor = true;
            // 
            // lbGrafNummers
            // 
            this.lbGrafNummers.FormattingEnabled = true;
            this.lbGrafNummers.Location = new System.Drawing.Point(93, 48);
            this.lbGrafNummers.Name = "lbGrafNummers";
            this.lbGrafNummers.Size = new System.Drawing.Size(161, 69);
            this.lbGrafNummers.TabIndex = 0;
            // 
            // btnSluit
            // 
            this.btnSluit.Location = new System.Drawing.Point(12, 226);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(75, 23);
            this.btnSluit.TabIndex = 1;
            this.btnSluit.Text = "Sluit";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(197, 226);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 1;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.btnSluit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReservation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NewReservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDuur;
        private System.Windows.Forms.ComboBox cbGrafNummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoegGrafToe;
        private System.Windows.Forms.ListBox lbGrafNummers;
        private System.Windows.Forms.Button btnSluit;
        private System.Windows.Forms.Button btnVoegToe;
    }
}