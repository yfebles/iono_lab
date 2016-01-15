namespace IonoLab
{
    partial class formVD
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
            this.groupBoxV = new System.Windows.Forms.GroupBox();
            this.listD = new System.Windows.Forms.ListBox();
            this.groupBoxD = new System.Windows.Forms.GroupBox();
            this.listV = new System.Windows.Forms.ListBox();
            this.radioFH = new System.Windows.Forms.RadioButton();
            this.radioFHD = new System.Windows.Forms.RadioButton();
            this.radioFHDonly = new System.Windows.Forms.RadioButton();
            this.buttonok = new System.Windows.Forms.Button();
            this.radioFHDV = new System.Windows.Forms.RadioButton();
            this.pboximage = new System.Windows.Forms.PictureBox();
            this.groupBoxV.SuspendLayout();
            this.groupBoxD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboximage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxV
            // 
            this.groupBoxV.Controls.Add(this.listD);
            this.groupBoxV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxV.Name = "groupBoxV";
            this.groupBoxV.Size = new System.Drawing.Size(78, 319);
            this.groupBoxV.TabIndex = 0;
            this.groupBoxV.TabStop = false;
            this.groupBoxV.Text = "Descriptiva";
            // 
            // listD
            // 
            this.listD.FormattingEnabled = true;
            this.listD.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Q",
            "R",
            "S",
            "T",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.listD.Location = new System.Drawing.Point(10, 21);
            this.listD.Name = "listD";
            this.listD.Size = new System.Drawing.Size(51, 303);
            this.listD.TabIndex = 6;
            // 
            // groupBoxD
            // 
            this.groupBoxD.Controls.Add(this.listV);
            this.groupBoxD.Location = new System.Drawing.Point(96, 12);
            this.groupBoxD.Name = "groupBoxD";
            this.groupBoxD.Size = new System.Drawing.Size(76, 165);
            this.groupBoxD.TabIndex = 1;
            this.groupBoxD.TabStop = false;
            this.groupBoxD.Text = "Valorativa";
            // 
            // listV
            // 
            this.listV.FormattingEnabled = true;
            this.listV.Items.AddRange(new object[] {
            "A",
            "D",
            "E",
            "I",
            "J",
            "M",
            "O",
            "T",
            "U",
            "Z"});
            this.listV.Location = new System.Drawing.Point(13, 21);
            this.listV.Name = "listV";
            this.listV.Size = new System.Drawing.Size(37, 134);
            this.listV.TabIndex = 7;
            // 
            // radioFH
            // 
            this.radioFH.AutoSize = true;
            this.radioFH.Checked = true;
            this.radioFH.Location = new System.Drawing.Point(190, 21);
            this.radioFH.Name = "radioFH";
            this.radioFH.Size = new System.Drawing.Size(75, 17);
            this.radioFH.TabIndex = 2;
            this.radioFH.TabStop = true;
            this.radioFH.Text = "Solo F ó H";
            this.radioFH.UseVisualStyleBackColor = true;
            // 
            // radioFHD
            // 
            this.radioFHD.AutoSize = true;
            this.radioFHD.Location = new System.Drawing.Point(190, 89);
            this.radioFHD.Name = "radioFHD";
            this.radioFHD.Size = new System.Drawing.Size(114, 17);
            this.radioFHD.TabIndex = 3;
            this.radioFHD.Text = "F ó H + descriptiva";
            this.radioFHD.UseVisualStyleBackColor = true;
            // 
            // radioFHDonly
            // 
            this.radioFHDonly.AutoSize = true;
            this.radioFHDonly.Location = new System.Drawing.Point(190, 125);
            this.radioFHDonly.Name = "radioFHDonly";
            this.radioFHDonly.Size = new System.Drawing.Size(100, 17);
            this.radioFHDonly.TabIndex = 4;
            this.radioFHDonly.Text = "Solo descriptiva";
            this.radioFHDonly.UseVisualStyleBackColor = true;
            // 
            // buttonok
            // 
            this.buttonok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonok.Location = new System.Drawing.Point(200, 335);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(104, 27);
            this.buttonok.TabIndex = 5;
            this.buttonok.Text = "&Ok";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // radioFHDV
            // 
            this.radioFHDV.AutoSize = true;
            this.radioFHDV.Location = new System.Drawing.Point(190, 55);
            this.radioFHDV.Name = "radioFHDV";
            this.radioFHDV.Size = new System.Drawing.Size(112, 17);
            this.radioFHDV.TabIndex = 6;
            this.radioFHDV.Text = "F o H + desc + val";
            this.radioFHDV.UseVisualStyleBackColor = true;
            // 
            // pboximage
            // 
            this.pboximage.BackColor = System.Drawing.Color.Black;
            this.pboximage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboximage.Location = new System.Drawing.Point(107, 173);
            this.pboximage.Name = "pboximage";
            this.pboximage.Size = new System.Drawing.Size(195, 156);
            this.pboximage.TabIndex = 7;
            this.pboximage.TabStop = false;
            // 
            // formVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 372);
            this.Controls.Add(this.pboximage);
            this.Controls.Add(this.radioFHDV);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.radioFHDonly);
            this.Controls.Add(this.radioFHD);
            this.Controls.Add(this.radioFH);
            this.Controls.Add(this.groupBoxD);
            this.Controls.Add(this.groupBoxV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "formVD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formVD_Load);
            this.groupBoxV.ResumeLayout(false);
            this.groupBoxD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboximage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxV;
        private System.Windows.Forms.ListBox listD;
        private System.Windows.Forms.GroupBox groupBoxD;
        private System.Windows.Forms.ListBox listV;
        private System.Windows.Forms.RadioButton radioFH;
        private System.Windows.Forms.RadioButton radioFHD;
        private System.Windows.Forms.RadioButton radioFHDonly;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.RadioButton radioFHDV;
        private System.Windows.Forms.PictureBox pboximage;
    }
}