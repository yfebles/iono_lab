namespace IonoLab
{
    partial class optionsForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbox_options = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxback_color = new System.Windows.Forms.PictureBox();
            this.pboxpixelcolor = new System.Windows.Forms.PictureBox();
            this.pboxlinecolor = new System.Windows.Forms.PictureBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gbox_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxback_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxpixelcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxlinecolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_options
            // 
            this.gbox_options.Controls.Add(this.label5);
            this.gbox_options.Controls.Add(this.numericUpDown2);
            this.gbox_options.Controls.Add(this.label2);
            this.gbox_options.Controls.Add(this.button2);
            this.gbox_options.Controls.Add(this.button1);
            this.gbox_options.Controls.Add(this.numericUpDown1);
            this.gbox_options.Controls.Add(this.label4);
            this.gbox_options.Controls.Add(this.label3);
            this.gbox_options.Controls.Add(this.label1);
            this.gbox_options.Controls.Add(this.pboxback_color);
            this.gbox_options.Controls.Add(this.pboxpixelcolor);
            this.gbox_options.Controls.Add(this.pboxlinecolor);
            this.gbox_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbox_options.Location = new System.Drawing.Point(0, 0);
            this.gbox_options.Name = "gbox_options";
            this.gbox_options.Size = new System.Drawing.Size(364, 129);
            this.gbox_options.TabIndex = 0;
            this.gbox_options.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ancho de linea";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(210, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color de lineas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color de pixeles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color de fondo";
            // 
            // pboxback_color
            // 
            this.pboxback_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxback_color.Location = new System.Drawing.Point(95, 19);
            this.pboxback_color.Name = "pboxback_color";
            this.pboxback_color.Size = new System.Drawing.Size(25, 25);
            this.pboxback_color.TabIndex = 6;
            this.pboxback_color.TabStop = false;
            this.pboxback_color.Click += new System.EventHandler(this.pboxback_color_Click);
            // 
            // pboxpixelcolor
            // 
            this.pboxpixelcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxpixelcolor.Location = new System.Drawing.Point(213, 19);
            this.pboxpixelcolor.Name = "pboxpixelcolor";
            this.pboxpixelcolor.Size = new System.Drawing.Size(25, 25);
            this.pboxpixelcolor.TabIndex = 4;
            this.pboxpixelcolor.TabStop = false;
            this.pboxpixelcolor.Click += new System.EventHandler(this.pboxback_color_Click);
            // 
            // pboxlinecolor
            // 
            this.pboxlinecolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxlinecolor.Location = new System.Drawing.Point(95, 53);
            this.pboxlinecolor.Name = "pboxlinecolor";
            this.pboxlinecolor.Size = new System.Drawing.Size(25, 25);
            this.pboxlinecolor.TabIndex = 3;
            this.pboxlinecolor.TabStop = false;
            this.pboxlinecolor.Click += new System.EventHandler(this.pboxback_color_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(278, 54);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estacion Habana";
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 129);
            this.Controls.Add(this.gbox_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "optionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opciones de Configuracion";
            this.Load += new System.EventHandler(this.optionsForm_Load);
            this.gbox_options.ResumeLayout(false);
            this.gbox_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxback_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxpixelcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxlinecolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbox_options;
        private System.Windows.Forms.PictureBox pboxback_color;
        private System.Windows.Forms.PictureBox pboxpixelcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pboxlinecolor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}