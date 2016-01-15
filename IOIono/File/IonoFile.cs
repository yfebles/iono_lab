using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Ionolab.StructIono;
using System.Collections;
using System.Drawing;


namespace Ionolab.IOIono
{
    public class IonoFile
    {
        #region Variables globales
        private FileStream file;
        private List<Ionogram> iono;
        private IonoHead head;
        private Color color;
        #endregion

        #region Ctor
        public IonoFile(string filename,Color color)
        {
            if (!File.Exists(filename))
                throw new Exception("File not found");
            FileName = filename;
            iono = new List<Ionogram>();
            this.color = color;
            file = new FileStream(FileName, FileMode.Open);
            if (!ReadHead() || !ReadIonograms()) { throw new FileLoadException("Wrong file"); }
            file.Close();
        }
        #endregion

        public FileStream FileStream { get { return file; } }
        public string FileName { get; private set; }
        public IonoHead Head { get { return head; } private set { head = value; } }
        /// <summary>
        /// Lee el n'esimo ionograma del fichero
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public virtual Ionogram Ionogram(int n)
        {
            return iono[n];
        }
        /// <summary>
        /// Funcion auxiliar para leer la cabecera del fichero
        /// </summary>
        /// <returns></returns>
        private bool ReadHead()
        { 
            byte[] buffer = new byte[16];
            int read=FileStream.Read(buffer, 0, 16);
            if (read != 16)
                return false;
            Head = new IonoHead();
            Head.fnum = ConvertToInt(buffer[0], buffer[1]);
            Head.fsize = ConvertToInt(buffer[2], buffer[3], buffer[4], buffer[5]);
            Head.fsite = ConvertToInt(buffer[6], buffer[7]);
            Head.fyear = ConvertToInt(buffer[8], buffer[9]);
            Head.fmonth = buffer[10];
            Head.fday = buffer[11];
            Head.fhour = buffer[12];
            Head.fminute = buffer[13];
            Head.fsecond = buffer[14];
            Head.fflags = buffer[15];
            return true;
        }
        private int ConvertToInt(params byte[] b)
        {
            int result = 0;
            for (int i = 0; i < b.Length; i++)
            {
                result += b[i] << 8 * i;
            }
            return result;
        }

        private bool ReadIonograms()
        {
            int offset = 0;
            byte[] bhead = new byte[16];
            byte[] bbody;
            for (int i = 0; i < Head.fnum; i++)
            {
                //Leo head
                Ionogram itemp = new Ionogram();
                int read =  FileStream.Read(bhead,offset,16);
                if(read!=16)return false;
                itemp.Head.inum = ConvertToInt(bhead[0], bhead[1]);
                itemp.Head.ilcol = ConvertToInt(bhead[2], bhead[3]);
                itemp.Head.ircol = ConvertToInt(bhead[4], bhead[5]);
                itemp.Head.iheight = ConvertToInt(bhead[6], bhead[7]);
                itemp.Head.isize = ConvertToInt(bhead[8], bhead[9]);
                itemp.Head.imonth = bhead[10];
                itemp.Head.iday = bhead[11];
                itemp.Head.ihour = bhead[12];
                itemp.Head.iminute = bhead[13];
                itemp.Head.isecond = bhead[14];
                itemp.Head.iflags = bhead[15];

                //Leo cuerpo
                bbody = new byte[itemp.Head.isize * 16];
                read = FileStream.Read(bbody, 0, bbody.Length);
                if (read != bbody.Length)
                    return false;
                itemp.IonoImage = Unpack(bbody, -itemp.Head.ilcol + itemp.Head.ircol + 1, itemp.Head.iheight * 8);
                itemp.IonoInfo = new IonoInfo();
                //Analized se inicializa en false
                itemp.Year = Head.fyear;
                iono.Add(itemp);
            }
            return true;
        }
        /// <summary>
        /// Descomprime un ionograma
        /// </summary>
        private byte[] Unpack(byte[] b)
        {
            List<byte> list = new List<byte>(b.Length);
              for (int i = 0; i < b.Length-1; i++)
            {
                if (b[i] != 0)
                {
                    list.Add(((b[i] & 128) == 128) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 64) == 64) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 32) == 32) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 16) == 16) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 8) == 8) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 4) == 4) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 2) == 2) ? (byte)1 : (byte)0);
                    list.Add(((b[i] & 1) == 1) ? (byte)1 : (byte)0);
                }
                else
                {
                    if (b[i + 1] == 0)
                        break;
                    else
                    {
                        for (int j = 0; j < b[i + 1]*8; j++)
                            list.Add(0);
                        i++;
                    }
                }
            }
            return list.ToArray();
        }
        /// <summary>
        /// Descomprime un ionograma como bitmap
        /// </summary>
        private Bitmap Unpack(byte[] b, int w, int h)
        {
            Bitmap bit = new Bitmap(h, w);
            int x = 0, y = 0;
            for (int i = 0; i < b.Length - 1; i++)
            {
                if (b[i] != 0)
                {
                    for (int j = 129 - 1; j >= 1; )
                    {
                        if ((b[i] & j) == j)
                            bit.SetPixel(x, y, color);
                        x++;
                        if (x % h == 0)
                        {
                            x = 0;
                            y++;
                        }
                        j /= 2;
                    }
                }
                else
                {
                    if (b[i + 1] == 0)
                        break;
                    else
                    {
                        int jump = 8*b[i + 1];
                        y += (x+jump) / h;
                        x = (x + (jump)) % h;
                        i++;
                    }
                }
            }
            bit.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bit;
        }
        /// <summary>
        /// Devuelve todos los ionograms
        /// </summary>
        public List<Ionogram> Ionograms
        {
            get
            {
                return iono;
            }
        }

    }
}
