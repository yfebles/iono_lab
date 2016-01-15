using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ionolab.IOIono;

namespace IonoLab
{
    public partial class formVD : Form
    {
        float km;
        
        string f;
        string p;
        //Los parametros que usan frecuencia
        List<string> useF = new List<string>() { "fmin", "fbEs", "f0Es", "f0E", "f0E2", "f0F1", "f0F2", "F2_M3000", "fxI" };
        

        public formVD(float km,float f,string prop)
        {
            this.km = km;
            var d= Math.Round(f*10);
            this.f=d.ToString().Length>2?d.ToString():"0"+d.ToString();
            this.p=prop;
            
            InitializeComponent();
        }
        public string Result { get; set; }

        private void buttonok_Click(object sender, EventArgs e)
        {
            
          
            if (radioFH.Checked)
            {
                if (useF.Contains(p))
                {
                    Result = f;
                }
                else
                {
                    Result = (Math.Round(km)).ToString();
                }
            }
            else if (radioFHDonly.Checked)
            {
               
                    Result = string.Format("{0}", listV.SelectedItem);
                
            }
            else if (radioFHD.Checked)
            {
                if (useF.Contains(p))
                {
                    Result = string.Format("{0} {1}", f, listV.SelectedItem);
                }
                else
                {
                    Result = string.Format("{0} {1}", Math.Round(km), listV.SelectedItem);
                }
            }
            else
            {
                if (useF.Contains(p))
                {
                    Result = string.Format("{0} {1} {2}", f, listV.SelectedItem, listD.SelectedItem);
                }
                else
                {
                    Result = string.Format("{0} {1} {2}", Math.Round(km), listV.SelectedItem, listD.SelectedItem);
                }
            }

        }
        Image fondo;
        public Image Fondo
        {
            get { return fondo; }
            set { fondo = value; pboximage.BackgroundImage = fondo; pboximage.BackgroundImageLayout = ImageLayout.Stretch; }
        }
        public Color Color_Fondo_Ionograma
        {
            get { return pboximage.BackColor; }
            set {
                pboximage.BackColor = value;
                pboximage.Refresh();
            }
        }
        private void formVD_Load(object sender, EventArgs e)
        {

        }

    }
}
