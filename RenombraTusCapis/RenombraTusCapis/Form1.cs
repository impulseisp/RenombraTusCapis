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

                    }
                    else
                        panelVistaPrevia.Rows[pos].Cells[4].Value = "No se ha encontrado el video correspondiente";
                    pos++;
                }



                // Create and execute a new query by using the previous 
                // query as a starting point. fileQuery is not 
                // executed again until the call to Last()

                /* var newestFile =
                    (from file in fileQuery
                     orderby file.CreationTime
                     select new { file.FullName, file.CreationTime })
                    .Last();

                Console.WriteLine("\r\nThe newest .txt file is {0}. Creation time: {1}",
                    newestFile.FullName, newestFile.CreationTime);*/

                // Keep the console window open in debug mode.
                /* Console.WriteLine("Press any key to exit");
                Console.ReadKey(); */
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
    }
}
