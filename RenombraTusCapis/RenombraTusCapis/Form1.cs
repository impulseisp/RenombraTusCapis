using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RenombraTusCapis
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            leerConfig();
        }

        private void leerConfig()
        {
            if (!File.Exists("Config.xml"))
            {
                XmlWriter w = XmlWriter.Create("Config.xml");
                w.WriteStartElement("General_Config");
                w.WriteElementString("CarpetaSeries", "");
                w.WriteElementString("CarpetaTemporada", "");
                w.WriteEndElement();
                w.Close();
            }
            try
            { 
                XmlReader r = XmlReader.Create("Config.xml");
                r.ReadStartElement("General_Config");
                textoPathSeries.Text = r.ReadElementContentAsString();
                textoCarpetaTemporada.Text = r.ReadElementContentAsString();
                r.Close();
                cambiaLabelTemporada();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            // <div>Icons made by <a href="http://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>

            //string startFolder = "@" + textoPathSeries.Text;

            // Take a snapshot of the file system.
            if (textoPathSeries.Text == "")
            {
                //crear label
                panelOpciones.Visible = true;
            }
            else
            {
                //antes eliminar todo de la vista previa
                if (panelVistaPrevia.Rows.Count > 0)
                    panelVistaPrevia.Rows.Clear();



                DirectoryInfo dir = new DirectoryInfo(textoPathSeries.Text);

                // This method assumes that the application has discovery permissions
                // for all folders under the specified path.
                IEnumerable<FileInfo> fileList = dir.GetFiles("*(*(*)*).*", SearchOption.AllDirectories);

                //Create the query
                IEnumerable<FileInfo> fileQuery =
                    from file in fileList
                    where file.Extension == ".srt"
                    orderby file.Name
                    select file;

                //filas tabla
                int pos = 0;
                string[] srtOriginalesFullName = new string[fileList.Count()];
                FileInfo archivoMKV;


                //Execute the query. This might write out a lot of files!
                foreach (FileInfo fi in fileQuery)
                {
                    //Console.WriteLine(fi.FullName);

                    

                    srtOriginalesFullName[pos] = fi.FullName;

                    archivoMKV = buscaMKV(fi.Name, dir);


                    panelVistaPrevia.Rows.Add();
                    panelVistaPrevia.Rows[pos].Cells[1].Value = fi.Name;

                    panelVistaPrevia.Rows[pos].Cells[3].Value = fi.Name.Substring(0, fi.Name.IndexOf("(") - 1) + fi.Extension;

                    panelVistaPrevia.Rows[0].Cells[0].Selected = false;

                    if (archivoMKV != null)
                    {
                        panelVistaPrevia.Rows[pos].Cells[4].Value = archivoMKV.Name;
                        panelVistaPrevia.Rows[pos].Cells[6].Value = renombraMKV(archivoMKV.Name, fi.Name.Substring(0, fi.Name.IndexOf("(") - 1));

                        panelVistaPrevia.Rows[pos].Cells[4].Selected = true;
                        panelVistaPrevia.Rows[pos].Cells[6].Selected = true;
                        panelVistaPrevia.Rows[pos].Cells[1].Selected = true;
                        panelVistaPrevia.Rows[pos].Cells[3].Selected = true;

                        ((DataGridViewCheckBoxCell)panelVistaPrevia.Rows[pos].Cells[0]).Value = true;
                        panelVistaPrevia.RefreshEdit();
                        panelVistaPrevia.Rows[pos].Cells[0].Selected = true;

                    }
                    else
                    { 
                        ((DataGridViewCheckBoxCell)panelVistaPrevia.Rows[pos].Cells[0]).Value = false;
                        panelVistaPrevia.Rows[pos].Cells[4].Value = "No se ha encontrado el video correspondiente";
                    }
                    pos++;
                }

            }
        }

        private object renombraMKV(string name1, string name2)
        {
            return name2 + ".mkv";
        }

        private FileInfo buscaMKV(string name, DirectoryInfo dir)
        {

            int numPalabra = 0;
            int posicionInicioPalabra = 0;
            string nameTemporal = name;
            string[] palabras = new string[nameTemporal.Length];

            bool continua = true;

            string numeroTemporada = "S";
            string numeroEpisodio = "E";

            do
            {
                palabras[numPalabra] = nameTemporal.Substring(posicionInicioPalabra, nameTemporal.IndexOf(' '));
                if (palabras[numPalabra][0] == '-')
                {
                    //separar por x y poner E y S
                    if (palabras[numPalabra-1].Substring(0, palabras[numPalabra-1].IndexOf("x")).Length == 1) 
                        numeroTemporada = numeroTemporada + "0" + palabras[numPalabra-1].Substring(0, palabras[numPalabra-1].IndexOf("x"));
                    else
                        numeroTemporada = numeroTemporada + palabras[numPalabra-1].Substring(0, palabras[numPalabra-1].IndexOf("x") - 1);

                    numeroEpisodio = numeroEpisodio + palabras[numPalabra - 1].Substring(palabras[numPalabra - 1].IndexOf("x")+1,palabras[numPalabra - 1].Length - palabras[numPalabra - 1].IndexOf("x")-1);

                    continua = false;

                }

                nameTemporal = nameTemporal.Substring(nameTemporal.IndexOf(' ')+1, nameTemporal.Length - nameTemporal.IndexOf(' ')-1);
                numPalabra++;
                

            } while (continua);

            string cadBusqueda = "*";
            int i = 0;

            while (i < numPalabra-3)
            { 
                cadBusqueda = cadBusqueda + palabras[i] + "*";
                i++;
            }
            cadBusqueda = cadBusqueda + "*" + numeroTemporada + numeroEpisodio + "*.*";
            //cadBusqueda = cadBusqueda + "*.*";

            IEnumerable<FileInfo> fileList = dir.GetFiles(cadBusqueda, SearchOption.AllDirectories);

            return fileList.FirstOrDefault();

        }

        private void bRun_Click(object sender, EventArgs e)
        {
            if (panelVistaPrevia.RowCount > 0)
            {
                int contadorModificadas = 0;



                //mostrar advertencia
                foreach (DataGridViewRow row in panelVistaPrevia.Rows)
                {
                    if ((bool)(((DataGridViewCheckBoxCell)row.Cells[0]).Value) == true)
                    {
                        if (mueveSRT(row))
                        {
                            contadorModificadas++;
                        }
                        if (mueveMKV(row))
                        {
                            contadorModificadas++;
                        }
                    }
                    else
                    {
                        //Console.WriteLine("no entra");
                    }
                }
            }
            else
            {
                //dialogo no hay filas, busca primero.
            }

            //TODO: Devolver contador modificadas.
            bBuscar_Click(sender,e);
        }

        private bool mueveMKV(DataGridViewRow row)
        {
            string sourceFile = "";
            string destFile = "";
            string targetPath = "";

            //buscar archivo (con path)
            DirectoryInfo dir = new DirectoryInfo(textoPathSeries.Text);
            FileInfo fileList = dir.GetFiles((string)row.Cells[4].Value, SearchOption.AllDirectories).FirstOrDefault();
            if (fileList != null)
            { 
                sourceFile = fileList.FullName;

                //objetivo
                targetPath = obtenerTargetPath((string)row.Cells[1].Value, fileList.DirectoryName);
                destFile = Path.Combine(targetPath, (string)row.Cells[6].Value);

                // To copy a folder's contents to a new location:
                // Create a new target folder, if necessary.
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                int contRenombre = 0;
                string destFileTemp = destFile;
                while (File.Exists(destFileTemp))
                {
                    destFileTemp = destFile + "_" + contRenombre.ToString();
                    contRenombre++;
                }

                destFile = destFileTemp;
                try
                {
                    File.Move(sourceFile, destFile);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        private bool mueveSRT(DataGridViewRow row)
        {
            string sourceFile = "";
            string destFile = "";
            string targetPath = "";

            //buscar archivo (con path)
            DirectoryInfo dir = new DirectoryInfo(textoPathSeries.Text);
            FileInfo fileList = dir.GetFiles((string)row.Cells[1].Value, SearchOption.AllDirectories).FirstOrDefault();
            sourceFile = fileList.FullName;

            //objetivo
            targetPath = obtenerTargetPath(fileList.Name, fileList.DirectoryName);
            destFile = Path.Combine(targetPath, (string)row.Cells[3].Value);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            int contRenombre = 0;
            string destFileTemp = destFile;
            while (File.Exists(destFileTemp))
            {
                destFileTemp = destFile.Substring(0,destFile.Count() - 4) + "_" + contRenombre.ToString() + ".srt";
                contRenombre++;
            }

            destFile = destFileTemp;
            try
            { 
                File.Move(sourceFile, destFile);
                return true;
            }
            catch
            {
                return false;
            }
                
        }

        private string obtenerTargetPath(string name, string orgPath)
        {
            string directorio = "";
            string nombreSerie = "";
            string temporadaSerie = "";
            if (textoCarpetaTemporada.Text == "")
            {
                directorio = orgPath;
            }
            else
            {
                nombreSerie = obtenerNombreSerie(name);
                temporadaSerie = obtenerTemporadaSerie(name);
                directorio = textoPathSeries.Text + @"\" + nombreSerie + @"\" + textoCarpetaTemporada.Text + " " + temporadaSerie + @"\" ;
            }
            
            return directorio;
        }

        private string obtenerTemporadaSerie(string name)
        {
            int numPalabra = 0;
            int posicionInicioPalabra = 0;
            string nameTemporal = name;
            string[] palabras = new string[nameTemporal.Length];

            bool continua = true;

            string numeroTemporada = "";

            do
            {
                palabras[numPalabra] = nameTemporal.Substring(posicionInicioPalabra, nameTemporal.IndexOf(' '));
                if (palabras[numPalabra][0] == '-')
                {
                    //separar por x y poner E y S
                    numeroTemporada = numeroTemporada + palabras[numPalabra - 1].Substring(0, palabras[numPalabra - 1].IndexOf("x"));
                    continua = false;

                }

                nameTemporal = nameTemporal.Substring(nameTemporal.IndexOf(' ') + 1, nameTemporal.Length - nameTemporal.IndexOf(' ') - 1);
                numPalabra++;

            } while (continua);

            return numeroTemporada;
        }

        private string obtenerNombreSerie(string name)
        {
            int numPalabra = 0;
            int posicionInicioPalabra = 0;
            string nameTemporal = name;
            string[] palabras = new string[nameTemporal.Length];

            bool continua = true;

            string nombreSerie = "";

            do
            {
                palabras[numPalabra] = nameTemporal.Substring(posicionInicioPalabra, nameTemporal.IndexOf(' '));
                if (palabras[numPalabra][0] == '-')
                {
                    //separar por x y poner E y S

                    for (int i = 0; i < numPalabra - 1; i++)
                    {
                        nombreSerie = nombreSerie + palabras[i] + " ";
                    }

                    //quitar el último espacio
                    nombreSerie = nombreSerie.Substring(0, nombreSerie.Length - 1);

                    continua = false;

                }

                nameTemporal = nameTemporal.Substring(nameTemporal.IndexOf(' ') + 1, nameTemporal.Length - nameTemporal.IndexOf(' ') - 1);
                numPalabra++;


            } while (continua);

            return nombreSerie;

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            leerConfig();
            panelOpciones.Visible = false;
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            //<div>Icons made by <a href="http://www.flaticon.com/authors/icomoon" title="Icomoon">Icomoon</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>
            Application.Exit();
        }

        private void dialogoBuscarCarpetaSeries_HelpRequest(object sender, EventArgs e)
        {
            //if (textoPathSeries.Text != "")
            //    dialogoBuscarCarpetaSeries.SelectedPath = textoPathSeries.Text;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            XmlWriter w = XmlWriter.Create("Config.xml");
            w.WriteStartElement("General_Config");
            w.WriteElementString("CarpetaSeries", textoPathSeries.Text);
            w.WriteElementString("CarpetaTemporada", textoCarpetaTemporada.Text);
            w.WriteEndElement();
            w.Close();
            panelOpciones.Visible = false;
        }

        private void bBuscarCarpetaSeries_Click(object sender, EventArgs e)
        {
            if (dialogoBuscarCarpetaSeries.ShowDialog() == DialogResult.OK)
            {
                textoPathSeries.Text = dialogoBuscarCarpetaSeries.SelectedPath;
            }
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = true;
        }

        private void textoCarpetaTemporada_TextChanged(object sender, EventArgs e)
        {
            cambiaLabelTemporada();
        }

        private void cambiaLabelTemporada()
        {
            if (textoCarpetaTemporada.Text == "")
            {
                labelSubcarpetaTemporadaResultado.Text = "Los videos se guardarán en la misma carpeta que los subtitulos";
            }
            else
            {
                labelSubcarpetaTemporadaResultado.Text = "Los videos se guardarán en [NombreDeSerie]\\" + textoCarpetaTemporada.Text + " [NumeroDeTemporada]";
            }
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.ShowDialog();
        }
    }
}
