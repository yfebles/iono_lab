using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace IonoLab
{
    [Serializable]
    public class ChartDetail
    {
        public Color BackColor { get; set; }
        public Color LineColor { get; set; }
        public int CursorWidth { get; set; }
        public Color CursorColor { get; set; }
        public Color PixelColor { get; set; }
        public int Habana_station_number { get; set; }
      
    }
}
