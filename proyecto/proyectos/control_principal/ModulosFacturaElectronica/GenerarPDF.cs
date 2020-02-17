using FirmarPDF;
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
    public partial class GenerarPDF : Form
    {
        public string Ruta_XML { get; private set; }
        public string Ruta_SelectPDF { get; private set; }

        public GenerarPDF()
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

        private string RutaSelecionadaParaPDF()
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

        private void btnSelecionarRuta_Click(object sender, EventArgs e)
        {
            string RutaSelectPDF = RutaSelecionadaParaPDF();
            txtRutaSelecionadaPDF.Text = RutaSelectPDF;
            Ruta_SelectPDF = RutaSelectPDF;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_PDF_Click(object sender, EventArgs e)
        {
          
            if (Ruta_XML != null && Ruta_XML != "" && Ruta_SelectPDF != null && Ruta_SelectPDF != "" &&
                txtNombrePDF.Text != null && txtNombrePDF.Text != "")
            {
                GenerarXMLtoPDF _generarPDF = new GenerarXMLtoPDF(Ruta_XML,txtNombrePDF.Text, Ruta_SelectPDF);

                if (_generarPDF.CrearPDF())
                {
                    MessageBox.Show("El PDF se realizo con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al crear el PDF", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                int opcion = 0;

                if (Ruta_XML == null || Ruta_XML == "") { opcion = 1; } else {
                    if (Ruta_SelectPDF == null || Ruta_SelectPDF == "") { opcion = 2; } else {
                        if (txtNombrePDF.Text == null || txtNombrePDF.Text == "") { opcion = 3; }
                    }
                }               
              
                switch (opcion) {
                    case 1: {
                            MessageBox.Show("Debe selecionar un .xml", "Alerta", MessageBoxButtons.OK);
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Debe selecionar un nombre para el pdf", "Alerta", MessageBoxButtons.OK);
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show("Debe selecionar una ruta para guardar el pdf", "Alerta", MessageBoxButtons.OK);
                            break;
                        }
                }
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

        private void btnSelecionarRuta_MouseEnter(object sender, EventArgs e)
        {
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnSelecionarRuta_MouseLeave(object sender, EventArgs e)
        {
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void btnCrear_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF2;
        }

        private void btnCrear_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF1;
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
