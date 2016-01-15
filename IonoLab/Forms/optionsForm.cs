using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IonoLab
{
    public partial class optionsForm : Form
    {
        public optionsForm()
        {
            InitializeComponent();
            chartdetail = SClass.Deserialize_Options();
            if (chartdetail == null)
            {
                chartdetail = new ChartDetail();
                SClass.Serialize_Options(chartdetail);
            }
            pboxback_color.BackColor = chartdetail.BackColor;
            pboxlinecolor.BackColor = chartdetail.LineColor;
            pboxpixelcolor.BackColor = chartdetail.PixelColor;

        }
        ChartDetail chartdetail;
        public ChartDetail ChartDetail
        {
            get { return chartdetail; }
            set { chartdetail = value; }
        }
      
        private void pboxback_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            if (Object.Equals(sender, pboxback_color))
            {
                chartdetail.BackColor = colorDialog1.Color;
            }
            else if (Object.Equals(sender, pboxlinecolor))
            { chartdetail.LineColor = colorDialog1.Color; }
            else if (Object.Equals(sender, pboxpixelcolor))
            { chartdetail.PixelColor = colorDialog1.Color; }

            ((PictureBox)(sender)).BackColor=colorDialog1.Color;
            ((PictureBox)(sender)).Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            chartdetail.CursorWidth = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartDetail.CursorWidth = Convert.ToInt32(numericUpDown1.Value);
            ChartDetail.BackColor = pboxback_color.BackColor;
            ChartDetail.CursorColor = pboxlinecolor.BackColor;
            ChartDetail.PixelColor = pboxpixelcolor.BackColor;
            chartdetail.Habana_station_number = Convert.ToInt32(numericUpDown2.Value);
            SClass.Serialize_Options(ChartDetail);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
