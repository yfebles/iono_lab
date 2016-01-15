using System;
using System.Collections.Generic;
using System.Text;

namespace Ionolab.IOIono
{
    public class FrecuenciaAtribute : System.Attribute { }
    public class M3000_Atribute : System.Attribute { }
    public class IonoInfo
    {
        public IonoInfo()
        {

            fmin = "";
            fbEs = "";
            f0Es = "";
            h_Es = "";
            Tipo_Es = "";
            f0E = "";
            h_E = "";
            f0E2 = "";
            h_F = "";
            f0F1 = "";
            f0F2 = "";
            M3000_F2 = "";
            fxI = "";
            h_F2 = "";
        }
        /// <summary>
        /// f0 valor de frecuencia minima
        /// </summary>
     [FrecuenciaAtribute]
        public string fmin { get; set; }
        /// <summary>
        /// Esporadica
        /// </summary>
      [FrecuenciaAtribute]
        public string fbEs { get; set; }
        /// <summary>
        /// Esporadica
        /// </summary>
         [FrecuenciaAtribute]
        public string f0Es { get; set; }
         /// <summary>
        /// E 2
        /// </summary>
         [FrecuenciaAtribute]
        public string f0E2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
         [FrecuenciaAtribute]
        public string f0F1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
         [FrecuenciaAtribute]
        public string f0F2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [M3000_Atribute]
        [FrecuenciaAtribute]
        public string M3000_F2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [FrecuenciaAtribute]
        public string fxI { get; set; }

        /// <summary>
        /// E normal
        /// </summary>
         [FrecuenciaAtribute]
        public string f0E { get; set; }
        
        public string Tipo_Es { get; set; }
        /// <summary>
        /// Esporadica valor de altura
        /// </summary>
        public string h_Es { get; set; }

      
        /// <summary>
        /// E normal
        /// </summary>
        public string h_E { get; set; }
       

        public string h_F { get; set; }

        public string h_F2 { get; set; }
        public bool Empty()
        {
            return fmin == "" && fbEs == "" && f0Es == "" && h_Es == "" && Tipo_Es == "" && f0E == "" && h_E == "" && f0E2 == "" && h_F == "" && f0F1 == "" && f0F2 == "" && M3000_F2 == "" && fxI == "" && h_F2 == "";
        }
        public override string ToString()
        {
            return fmin + fbEs + f0Es + h_Es + Tipo_Es + f0E + h_E + f0E2 + h_F + f0F1 + f0F2 + M3000_F2 + fxI + h_F2;
        }
    }
}
