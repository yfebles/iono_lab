using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace IonoLab
{
    static class SClass
    {
        /// <summary>
        /// Hace persistente a disco las opciones de configuracion
        /// Guarda los cambios en "options.ser" un archivo privado de la aplicacion.
        /// </summary>
        public static void Serialize_Options(ChartDetail options)
        {


            try
            {
       
                BinaryFormatter binary = new BinaryFormatter();
                FileStream file = new FileStream(Application.StartupPath+"\\options.dat", FileMode.OpenOrCreate, FileAccess.Write);
                binary.Serialize(file, options);
                file.Close();
            }
            catch (Exception)
            {
                //algun error guardando
          
            }
        }
        /// <summary>
        /// Recupera del archivo privado de la aplicacion "options.ser" 
        /// los datos de personalizacion del ionoviewer
        /// </summary>
        /// <returns></returns>

        public static ChartDetail Deserialize_Options()
        {
             ChartDetail default_chart=new ChartDetail();
            try
            {
                BinaryFormatter binary = new BinaryFormatter();
                if (File.Exists(Application.StartupPath + "\\options.dat"))
                {
                    FileStream file = new FileStream(Application.StartupPath + "\\options.dat", FileMode.OpenOrCreate, FileAccess.Read);
                    ChartDetail chart = (ChartDetail)binary.Deserialize(file);
                    file.Close();
                    return chart;
                }
            }
            catch (Exception)
            {
               
                default_chart.PixelColor = Color.Purple;
                default_chart.BackColor = Color.Black;
                default_chart.CursorWidth = 1;
                default_chart.CursorColor = Color.White;
                default_chart.LineColor = Color.Red;

            }

            return default_chart;
        }
    }
}
