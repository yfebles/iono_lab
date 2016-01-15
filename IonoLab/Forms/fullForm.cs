using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IonoLab
{
    public partial class fullForm : Form
    {
        public fullForm()
        {
            InitializeComponent();
        }

        private void fullForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close(); ;
        }

      
    }
}
