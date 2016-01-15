using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IonoLab
{
    public partial class Tipo_Es : Form
    {
        public Tipo_Es()
        {
            InitializeComponent();
            Result = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string Result { get; set; }

        private void aceptbutton_Click(object sender, EventArgs e)
        {
            int l,f,h,c;
            List<string> list = new List<string>(4);
            if (int.TryParse(tboxL.Text, out l)) list.Add("l" + l);
            if (int.TryParse(tboxF.Text, out f)) list.Add("f" + f); 
            if (int.TryParse(tboxH.Text, out h)) list.Add("h" + h); 
            if (int.TryParse(tboxC.Text, out c)) list.Add("c" + c);
            list.Sort(new Comparer());

            Result = Elements(list);
        }

        private string Elements(List<string> list)
        {
            string s = "";
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i].ToString()+" ";
            }
            return s;
        }
        class Comparer : IComparer<string>
        {
            #region IComparer<string> Members

            public int Compare(string x, string y)
            {
                return x[1].CompareTo(y[1]);
            }

            #endregion
        }
    }
}
