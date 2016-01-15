using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ionolab.IOIono;
using Ionolab.StructIono;
using System.Drawing.Printing;
using System.Threading;
using System.IO;




namespace IonoLab
{
    public partial class mainForm : Form
    {
        IonoFile ionofile;

        public mainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ionoviewer.KM += new Action<float>(f => this.kmvaluetoolStripStatusLabel.Text = f.ToString());
            ionoviewer.Freq += new Action<float>(f => this.fvaluetoolStripStatusLabel.Text = f.ToString());
            Habana_station_number = 7;
          

        }

        #region Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    
                       var temp = SClass.Deserialize_Options();
                       if (temp != null)
                       {
                           ionoviewer.ChartInfo = temp;
                       }
                       else
                       {
                           ionoviewer.ChartInfo = new ChartDetail();
                       }
                       ionoviewer.SetBackColor = ionoviewer.ChartInfo.BackColor;
                       ionofile = new IonoFile(openFile.FileName, ionoviewer.ChartInfo.PixelColor);
                       treeView.Nodes.Clear();
                       treeView.ImageList = new ImageList();
                       treeView.ImageList.Images.Add(Properties.Resources.inactive);
                       treeView.ImageList.Images.Add(Properties.Resources.ok);
                       TreeNode node = null;

                       foreach (var iono in ionofile.Ionograms)
                       {
                           node = new TreeNode("Ionograma "+iono.ToString());
                           node.SelectedImageIndex = node.ImageIndex = 0;
                           treeView.Nodes.Add(node);
                       }
                       treeView.SelectedNode = treeView.Nodes[0];
                       treeView.Visible = true;
                       treeView.Refresh();
                       ionoviewer.Ionogram = ionofile.Ionogram(0);
                       Actualizar_Station_Label();
                   
                   
                   
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        void Actualizar_Station_Label()
        {
            try
            {
                lb_station.Text = (this.ionofile.Head.fsite == Habana_station_number) ? "Habana" : "Desconocida";
                lb_station.Text += " " + ionoviewer.Ionogram.ToString();
                lb_station.BackColor = ionoviewer.ChartInfo.BackColor;
                lb_station.Refresh();
            }
            catch (Exception)
            {

                //puede lanzar una NUllreference si no se ha cargado el ionograma o el chartInfo
                //La visualizacion del label es secundaria por lo que ignoro esta excepcion
            }
            
        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region TreeView
        private void preToolStripButton_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void nextToolStripButton_Click(object sender, EventArgs e)
        {
            Next();
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ionofile != null)
            {
                ionoviewer.Ionogram = ionofile.Ionogram(e.Node.Index);
                treeView.SelectedNode = e.Node;
                Actualizar_Station_Label();
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (ionofile != null)
            {
                ionoviewer.Ionogram = ionofile.Ionogram(e.Node.Index);
                treeView.SelectedNode = e.Node;
                Actualizar_Station_Label();
            }
        }
        private void Next()
        {
            if (ionofile != null && treeView.SelectedNode.Index < treeView.Nodes.Count - 1)
            {
                ionoviewer.Ionogram = ionofile.Ionogram(treeView.SelectedNode.Index + 1);
                treeView.SelectedNode = treeView.Nodes[treeView.SelectedNode.Index + 1];
                Actualizar_Station_Label();
            }
        }
        private void Previous()
        {
            if (ionofile != null && treeView.SelectedNode.Index > 0)
            {
                ionoviewer.Ionogram = ionofile.Ionogram(treeView.SelectedNode.Index - 1);
                treeView.SelectedNode = treeView.Nodes[treeView.SelectedNode.Index - 1];
                Actualizar_Station_Label();
            }
        }
       
        void Update_Nodes_Images()
        {
            int i = 0;
            foreach (TreeNode item in treeView.Nodes)
            {
                if (ionofile.Ionogram(i).Analized())
                {
                    if (item.ImageIndex == 0)
                        item.ImageIndex = item.SelectedImageIndex = 1;
                }
                else
                {
                    if (item.ImageIndex == 1)
                        item.ImageIndex = item.SelectedImageIndex = 0;
                }
                i++;
            }

        }
        #endregion

        #region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ionoviewer.Ionogram != null && saveFile.ShowDialog() == DialogResult.OK)
            {
               
                ionoviewer.SaveIonogramImage().Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        #endregion

        #region Pintar Mouse

        private void mouseStripButton_Click(object sender, EventArgs e)
        {
            ionoviewer.ShowMouse = !ionoviewer.ShowMouse;
            cursorToolStripMenuItem.Checked = !cursorToolStripMenuItem.Checked;
        }
        #endregion

        #region Maximizar
        private bool maximized;
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = !maximized ? FormWindowState.Maximized : FormWindowState.Normal;
            maximized = !maximized;
            fullScreenToolStripMenuItem.Checked = !fullScreenToolStripMenuItem.Checked;
        }
        #endregion

        #region Dialogo About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm af = new aboutForm();
            af.ShowDialog();
        }
        #endregion

        #region Imprimir

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            printDialog.Document = document;
            if (ionoviewer.Ionogram != null && printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                document.Print();
            }

        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ionoviewer.Ionogram.IonoImage, new Point(e.PageSettings.Bounds.Width / 2 - ionoviewer.Ionogram.IonoImage.Width / 2, 120));
        }
        #endregion


        public int Habana_station_number { get; set; }

        private void erasetoolStripButton_Click(object sender, EventArgs e)
        {
            ionoviewer.ClearBoard();
            
            
        }

        private void fullScreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ionoviewer.Ionogram != null)
            {
                fullForm form = new fullForm();
                form.BackgroundImage = ionoviewer.Ionogram.IonoImage;
                form.ShowDialog();
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsForm f = new optionsForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                SClass.Serialize_Options(f.ChartDetail);
                ionoviewer.ChartInfo = f.ChartDetail;
                Habana_station_number = f.ChartDetail.Habana_station_number;
                Actualizar_Station_Label();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customizeToolStripMenuItem_Click(sender, e);
        }

        private void m3000StripButton_Click(object sender, EventArgs e)
        {
            ionoviewer.ShowMouseM300 = !ionoviewer.ShowMouseM300;
        }

        /// <summary>
        /// Guarda la tabla diaria 
        ///El formato de la tabla diaria es el siguiente:
        ///24 lineas para cada hora del dia
        ///por cada linea todas las propiedades calculadas en un IOnograma
        ///cada propiedad tiene 3 espacios para numeros y 2 para letras 
        ///Las propiedades estan separadas por un ;
        ///Y la hora esta separada de las propiedades por un ;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabladiariatoolstrip_Click(object sender, EventArgs e)
        {
            
            if (ionofile != null && ionofile.Head != null)
            {
                saveFileDialog1.FileName = "Tabla_Diaria";
                saveFileDialog1.FileName += "_" + ionofile.Head.fday + "_" + ionofile.Head.fmonth + "_" + ionofile.Head.fyear;
            }
            else { return; }
            StreamWriter writer=null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    //busco los ionogramas que hay que guardar
                    List<Ionogram> lista = new List<Ionogram>(24);
                    foreach (var item in ionofile.Ionograms)
                        if (item.Analized() && !item.IonoInfo.ToString().Contains(";"))
                            lista.Add(item);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        writer.WriteLine(i + ";" + lista[i].IonoInfo.fmin + ";"
                                              + lista[i].IonoInfo.fbEs + ";"
                                              + lista[i].IonoInfo.f0Es + ";"
                                              + lista[i].IonoInfo.h_Es + ";"
                                              + lista[i].IonoInfo.Tipo_Es + ";"
                                              + lista[i].IonoInfo.f0E + ";"
                                              + lista[i].IonoInfo.h_E + ";"
                                              + lista[i].IonoInfo.f0E2 + ";"
                                              + lista[i].IonoInfo.f0F1 + ";"
                                              + lista[i].IonoInfo.f0F2 + ";"
                                              + lista[i].IonoInfo.M3000_F2 + ";"
                                              + lista[i].IonoInfo.fxI + ";"
                                              + lista[i].IonoInfo.h_F + ";"
                                              + lista[i].IonoInfo.h_F2);
                        if (i >= 24) break;
                    }



                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error Guardando Tabla Diaria." + "  " + exp.Message, "ERROR", MessageBoxButtons.OK);


                }
                finally
                {
                    writer.Close();

                    saveFileDialog1.FileName = "";
                }
                
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea Guardar los cambios?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                tabladiariatoolstrip_Click(null, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Update_Nodes_Images();
        }



      
    }
}
