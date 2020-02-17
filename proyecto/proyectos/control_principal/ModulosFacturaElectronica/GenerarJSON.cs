using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_principal.ModulosFacturaElectronica
{
    public partial class GenerarJSON : Form
    {
        public string Ruta_XML { get; private set; } = null;
        public string Ruta_SelectJSON { get; private set; } = null;

        public GenerarJSON()
        {
            InitializeComponent();
        }

        private string BuscarRutaDocumento()
        {
            //Crear cuadro de seleccionar archivo
            OpenFileDialog Carpeta = new OpenFileDialog();

            //verifica si un archivo ha sido selecionado
            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                //Archivo que hemos seleccionado               
                return Carpeta.FileName;
            }
            else
            {
                return "";
            }

        }

        private string RutaSelecionadaParaJSON()
        {
            //Crear cuadro de seleccionar archivo
            FolderBrowserDialog Carpeta = new FolderBrowserDialog();

            //verifica si un archivo ha sido selecionado
            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                //Archivo que hemos seleccionado               
                return Carpeta.SelectedPath;
            }
            else
            {
                return "";
            }

        }

        private void btnBuscar_XML_Click(object sender, EventArgs e)
        {
            string RutaXML = BuscarRutaDocumento();
            lblRutaXML.Text = RutaXML;
            Ruta_XML = RutaXML;
        }

        private void btnSlecionarRutaJSON_Click(object sender, EventArgs e)
        {
            string RutaSelectJSON = RutaSelecionadaParaJSON();
            txtRutaJSON.Text = RutaSelectJSON;
            Ruta_SelectJSON = RutaSelectJSON;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearJson_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ruta_XML != null && Ruta_XML != "" && Ruta_SelectJSON != null && Ruta_SelectJSON != "" &&
                    txtNombreJSON.Text != null && txtNombreJSON.Text != "")
                {

                    System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                    doc.Load(Ruta_XML);

                    string json = JsonConvert.SerializeXmlNode(doc);

                    System.IO.File.WriteAllText(Ruta_SelectJSON+@"\"+ txtNombreJSON.Text + ".json", json);

                    MessageBox.Show("El archivo JSON se genero con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    if (Ruta_XML == null || Ruta_XML == "")
                    {
                        MessageBox.Show("Selecione un archivo XML", "Alerta", MessageBoxButtons.OK);
                    }
                    else {
                        if (txtNombreJSON.Text == null || txtNombreJSON.Text == "")
                        {
                            MessageBox.Show("Debe escribir un nombre para el archivo JSON", "Alerta", MessageBoxButtons.OK);
                        }
                        else {
                            if (Ruta_SelectJSON == null || Ruta_SelectJSON == "")
                            {
                                MessageBox.Show("Selecione una ruta para guardar el JSON", "Alerta", MessageBoxButtons.OK);
                            }
                        }
                    }

                

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al generar el archivo JSON", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnBuscar_XML_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_XML_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnSlecionarRutaJSON_MouseEnter(object sender, EventArgs e)
        {
            this.btnSlecionarRutaJSON.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnSlecionarRutaJSON_MouseLeave(object sender, EventArgs e)
        {
            this.btnSlecionarRutaJSON.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnCrearJson_MouseEnter(object sender, EventArgs e)
        {
            this.btnCrearJson.Image = global::control_principal.Properties.Resources.crearJson2;
        }

        private void btnCrearJson_MouseLeave(object sender, EventArgs e)
        {
            this.btnCrearJson.Image = global::control_principal.Properties.Resources.crearJson;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return22;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return2;
        }
    }
}
