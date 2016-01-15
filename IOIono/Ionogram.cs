using System;
using System.Collections.Generic;
using System.Text;
using Ionolab.IOIono;
using System.Collections;
using System.Drawing;

namespace Ionolab.StructIono
{
    public class Ionogram
    {
        public Ionogram()
        {
            Head = new IonoIHead();

        }
      
       
        public int Year { get; set; }
        public IonoIHead Head { get; internal set; }
        public Bitmap IonoImage { get; set; }
        public IonoInfo IonoInfo{ get;  set; }
        public override string ToString()
        {
            return Head.inum + " " + Head.iday + "/" + Head.imonth + "/"+Year+" " + Head.ihour + ":" + Head.iminute + ":" + Head.isecond;

        }
       
        ///<summary>
        /// Representa si este ionograma ha sido analizado.
        /// 
        /// <returns>Si se han calculado los datos correspondientes a su imagen y han sido guardados en
        /// Ionoinfo</returns>
        /// </summary>
        public bool Analized()
        {
            return !IonoInfo.Empty();
        }
    }
}
