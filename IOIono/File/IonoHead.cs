using System;
using System.Collections.Generic;
using System.Text;

namespace Ionolab.IOIono
{
    /// <summary>
    /// Cabecera del fichero. Ocupa 16 bytes
    /// </summary>
    public  class IonoHead
    {
        /// <summary>
        /// Numero de ionograms
        /// </summary>
        public int fnum;
        /// <summary>
        /// Tamanno total del fichero en bytes
        /// </summary>
        public int fsize;
        /// <summary>
        /// Numero de la estacion
        /// </summary>
        public int fsite;
        /// <summary>
        /// Anno
        /// </summary>
        public int fyear;
        /// <summary>
        /// Mes
        /// </summary>
        public byte fmonth;
        /// <summary>
        /// Dia
        /// </summary>
        public byte fday;
        /// <summary>
        /// Hora
        /// </summary>
        public byte fhour;
        /// <summary>
        /// Minutos
        /// </summary>
        public byte fminute;
        /// <summary>
        /// Segundos
        /// </summary>
        public byte fsecond;


        public byte fflags;
    }
}
