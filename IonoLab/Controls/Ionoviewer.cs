using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Ionolab.StructIono;
using System.IO;
using Ionolab.IOIono;

namespace IonoLab
{
  
    public partial class Ionoviewer : UserControl
    {
        Ionogram iono;
        ChartDetail chartdetail;
        float km, f;//el kilometro y la frecuencia que señala el cursor en el ionoviewer
        PointF position;
       
        #region Ctor()
        public Ionoviewer()
        {
            InitializeComponent();
            panelG.BackColor = ChartInfo.BackColor;
            ShowMouse = true;
            auxPen = new Pen(ChartInfo.LineColor, 1);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            LoadBAf();
            LoadM300();
            KM += new Action<float>(i => km = i);
            Freq += new Action<float>(i => f = i);
            Position += new Action<PointF>(i => position = i);

        }
        #endregion

        #region Llenando el menu
        private void MakeMenu()
        {
            var m = new ContextMenu();
            foreach (var subm in Ionogram.IonoInfo.GetType().GetMembers())
            {
                if (subm.MemberType == System.Reflection.MemberTypes.Property)
                {
                    MenuItem mi = new MenuItem(subm.Name);
                    mi.Click += new EventHandler(mi_Click);
                    m.MenuItems.Add(mi);
                }
            }
            panelG.ContextMenu = m;
        }
        #region Eventos del menu
        void mi_Click(object sender, EventArgs e)
        {
            if (this.Ionogram != null)
            {
                MenuItem mi = (MenuItem)sender;
                Type type = typeof(Ionolab.IOIono.IonoInfo);
                if (mi.Text == "Tipo_Es")
                {
                    Tipo_Es tipo_es = new Tipo_Es();
                    if (tipo_es.ShowDialog() == DialogResult.OK)
                    {
                        type.InvokeMember(mi.Text, System.Reflection.BindingFlags.SetProperty, null, Ionoinfo,
                                         new object[] { tipo_es.Result });

                    }
                }
                else
                {
                    formVD form = new formVD(km, f, mi.Text);
                    form.Fondo = iono.IonoImage;
                    form.Color_Fondo_Ionograma = chartdetail.BackColor;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        

                        if (mi.Text == "M3000_F2")//hay que modificarlo si se cambia la propiedad en ionoinfo
                        {

                            if (iono.IonoInfo.f0F2 == "")
                                MessageBox.Show("No se puede calcular la M3000_F2 sin antes tener la F0F2. ", "ATENCION", MessageBoxButtons.OK);
                            else
                                type.InvokeMember(mi.Text, System.Reflection.BindingFlags.SetProperty, null, Ionoinfo,
                                new object[] { RoundM3000(float.Parse(form.Result) / ExtractFrec(iono.IonoInfo.f0F2)) });

                        }
                        else
                            type.InvokeMember(mi.Text, System.Reflection.BindingFlags.SetProperty, null, Ionoinfo, new object[] { form.Result });
                        
                    }

                }
                propertyGrid.SelectedObject = Ionoinfo;
            }
        }
        string RoundM3000(float m3000) 
        {

            var d = Math.Round(m3000 * 10);
            return d.ToString().Length > 2 ? d.ToString() : "0" + d.ToString();
        }
        float ExtractFrec(string f0F2)//030 C F ...121 C F
        {
            float result = 0;
            for (int i = 0; i < f0F2.Length; i++)
            {
                if (f0F2[i] - '0' >= 0 && f0F2[i] - '0' < 10)
                {
                    result *= 10;
                    result += f0F2[i] - '0';
                }
                else
                    break;
            }
            float temp = result % 10;

            return result / 10 + 0.1f * temp;
        }
       #endregion

        #endregion
      
        #region Propiedades
        public IonoInfo Ionoinfo
        {
            get
            {
                if (Ionogram != null)
                    return Ionogram.IonoInfo;
                return null;
            }

        }

        public Color SetBackColor
        {
            set { panelG.BackColor = value; }
        }
        public ChartDetail ChartInfo
        {
            get { return chartdetail==null? SClass.Deserialize_Options():chartdetail; }
            set
            {
                chartdetail = value != null ? value : chartdetail;
                if (value != null)
                {
                    auxPen = new Pen(value.LineColor, value.CursorWidth);
                    SetBackColor = chartdetail.BackColor;
                }
            }
        }
        
        /// <summary>
        /// Procesa la imagen del ionograma para agregarle el nombre de la estacion y demas
        /// parametros ademas de la escala de frecuencia y altura.
        /// </summary>
        /// <returns></returns>
        public Image SaveIonogramImage()
        {

            return iono.IonoImage;
          //return  new Bitmap(iono.IonoImage.Width, iono.IonoImage.Height, panelG.CreateGraphics());
          

            
        }
        public Ionogram Ionogram
        {
            get
            {
                return iono;
            }
            set
            {
                iono = value;
                if (iono != null)
                {
                    MakeMenu();//crea el menu contextual via reflection
                    panelG.Image = iono.IonoImage;
                    propertyGrid.SelectedObject = iono.IonoInfo;
                }
            }
        }

        public bool ShowMouse { get; set; }
        public bool ShowMouseM300 { get; set; }

        #endregion
        #region Auxiliares
        Pen auxPen;
        Pen auxPen2 = new Pen(Color.Green, 3);//para pintar la curva del m3000
        private void DrawMouse(Point e)
        {
            panelG.Refresh();
            Graphics g = panelG.CreateGraphics();
            Point p4, p1, p2, p3;
            p1 = new Point(0, e.Y);
            p2 = new Point(panelG.Width, e.Y);
            p3 = new Point(e.X, 0);
            p4 = new Point(e.X, panelG.Height);

            g.DrawLine(auxPen, p1, p2);
            g.DrawLine(auxPen, p3, p4);
        }
        PointF[] pM300 = new PointF[9];
        private void DrawMouseM3000()
        {
            Graphics g = panelG.CreateGraphics();
            var p = new PointF[9];
            float fre = f;
            for (int i = 0; i < 9; i++)
            {
                float pixelKM = ((float)pM300[i].Y / 800f) * (float)panelG.Height;
                float tempf = GetPixelfromF(pM300[i].X * fre);
                float pixelF = ((float)panelG.Width / 512f) * tempf;
                if (pixelF <= 0)
                    return;
                p[i] = new PointF(pixelF,panelG.Height- pixelKM);
            }
            g.DrawCurve(auxPen2, p);
           
        }
        private void LoadM300()
        {
            pM300[0] = new PointF(.220f, 200);
            pM300[1] = new PointF(.247f, 250);
            pM300[2] = new PointF(.274f, 300);
            pM300[3] = new PointF(.300f, 350);
            pM300[4] = new PointF(.325f, 400);
            pM300[5] = new PointF(.372f, 500);
            pM300[6] = new PointF(.417f, 600);
            pM300[7] = new PointF(.455f, 700);
            pM300[8] = new PointF(.490f, 800);
        }
        #endregion
        #region Mouse
        private void panelG_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void panelG_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelG_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelG_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
            panelG.Refresh();
        }
        private void panelG_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShowMouse)
                DrawMouse(new Point(e.X, e.Y));
            if (ShowMouseM300)
                DrawMouseM3000();
            if (KM != null && Freq != null)
            {
                KM(800.0f * ((float)panelG.Height - e.Y) / (float)panelG.Height);
                
                Freq(GetFfromPixel(578f * (float)e.X / (float)panelG.Width));
            }
        }

        void LoadBAf()
        {
            B = new float[128];
            A = new float[128];
            f1i = new float[128];

            float bi = 1748f;
            float ai = 309f;
            for (int i = 0; i < 128; i++)
            {
                B[i] = bi;
                A[i] = ai;
                f1i[i] = (A[i] / B[i]) * 5.657f;
                ai++;
                bi -= 4;
            }
        }
        float[] B;//para el calculo de la frecuencia
        float[] A;
        float[] f1i;
        /// <summary>
        /// Obtiene la frecuencia que representa el pixel del parametro en le ionograma
        /// </summary>
        /// <param name="pixel"></param>
        /// <returns></returns>
        private float GetFfromPixel(double pixel)
        {
            int i = (int)pixel / 128;
            return (float)Math.Pow(2, i) * f1i[(int)pixel % 128];
        }
        private int GetPixelfromF(float ff)
        {
            if (ff < 1)
                return -1;
            int i = 0;
            for (; i <= 4; i++)
                if (ff < Math.Pow(2, i + 1) && ff > Math.Pow(2, i))
                    break;
            int pixel = 128 * i;
            int j = 0;
            for (; j < f1i.Length; j++)
                if (f1i[j] * Math.Pow(2, i) > ff)
                    break;
            pixel += j;
            pixel--;
            return pixel;
        }
        #endregion
        #region Escala
        public event Action<float> KM;
        public event Action<float> Freq;
        public event Action<PointF> Position;
        #endregion
        #region Metodos
        public void ClearBoard()
        {
            if (Ionogram != null)
            {
                Ionogram.IonoInfo = new IonoInfo();
                propertyGrid.SelectedObject = Ionoinfo;
            }
        }
        #endregion

        #region Pintando la escala de frecuencia y altura
        
        Pen auxPen3 = new Pen(Color.White);
        Font font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif),10, FontStyle.Bold);
        string[] frecuencias = new string[] {"1.4","2.0","2.8","4.0","5.6","8.0","11.3","16.0"};
        
        private void panelG_Paint(object sender, PaintEventArgs e)
        {
            float frec = panelG.Width / 9.0f,
                  h = panelG.Height / 8.0f;
            e.Graphics.DrawString("KM", font, auxPen3.Brush, 0,20);
            e.Graphics.DrawString("MHZ", font, auxPen3.Brush, panelG.Width-panelG.Width*0.07f,panelG.Height-panelG.Height*0.06f);
           
            for (int i = 1; i <= 7; i++)
            {
                e.Graphics.DrawLine(auxPen3,0,h*i,.02f*panelG.Width,h*i);
                e.Graphics.DrawString(((8-i) * 100).ToString(), font, auxPen3.Brush, 0, h * i);
                e.Graphics.DrawLine(auxPen3,i*frec,panelG.Height-.02f*panelG.Height,i*frec,panelG.Height);
                e.Graphics.DrawString(frecuencias[i-1],font,auxPen3.Brush,frec*i-font.SizeInPoints,panelG.Height-panelG.Height*0.05f);
            }
            e.Graphics.DrawLine(auxPen3, 8 * frec, panelG.Height - .02f * panelG.Height, 8 * frec, panelG.Height);
            e.Graphics.DrawString(frecuencias[7], font, auxPen3.Brush, frec * 8 - font.SizeInPoints, panelG.Height - panelG.Height * 0.05f);

        }
        #endregion



    }
}
