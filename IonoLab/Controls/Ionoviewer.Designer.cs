namespace IonoLab
{
    partial class Ionoviewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelG)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(117, 391);
            this.propertyGrid.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelG);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer.Size = new System.Drawing.Size(517, 391);
            this.splitContainer.SplitterDistance = 396;
            this.splitContainer.TabIndex = 1;
            // 
            // panelG
            // 
            this.panelG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelG.Location = new System.Drawing.Point(0, 0);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(396, 391);
            this.panelG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelG.TabIndex = 0;
            this.panelG.TabStop = false;
            this.panelG.Paint += new System.Windows.Forms.PaintEventHandler(this.panelG_Paint);
            this.panelG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelG_MouseClick);
            this.panelG.MouseEnter += new System.EventHandler(this.panelG_MouseEnter);
            this.panelG.MouseLeave += new System.EventHandler(this.panelG_MouseLeave);
            this.panelG.MouseHover += new System.EventHandler(this.panelG_MouseHover);
            this.panelG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelG_MouseMove);
            // 
            // Ionoviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "Ionoviewer";
            this.Size = new System.Drawing.Size(517, 391);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox panelG;
    }
}
