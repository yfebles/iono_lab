using System;
using System.Collections.Generic;
using System.Text;

namespace Ionolab.IOIono
{
    public class IonoIHead
    {
        /// <summary>
        /// Numero de ionograma. Este numero es unico
        /// </summary>
        public int inum;
        /// <summary>
        /// Left-hand column of ionogram. 
        /// </summary>
        public int ilcol;
        /// <summary>
        /// Right-hand column of ionogram.
        /// </summary>
        public int ircol;
        /// <summary>
        /// Tamanno en bytes del ionograma
        /// </summary>
        public int iheight;
        /// <summary>
        /// Tamanno en bloques de 16 bytes 
        /// </summary>
        public int isize;
        /// <summary>
        /// Fecha que el ionograma fue recolectado
        /// </summary>
        public byte imonth;
        public byte iday;
        public byte ihour;
        public byte iminute;
        /// <summary>
        /// Relates to start of ionogram.  
        /// </summary>
        public byte isecond;
        public byte iflags;

        /*
            ilcol, ircol specify the first and last frequency that is stored; these
            correspond to the 512 frequency steps in the IPS-42 ionogram.
         */
    }
}
