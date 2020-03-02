using FirmarPDF;
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

namespace control_principal.ModulosFacturaElectronica
{
    public partial class ValidarPDF : Form
    {
        private string Ruta_PDF { get; set; } = null;

        public ValidarPDF()
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
        private void btnBuscar_PDF_Click(object sender, EventArgs e)
        {
            string RutaPDF = BuscarRutaDocumento();
            lblRutaPDF.Text = RutaPDF;
            Ruta_PDF = RutaPDF;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnValidarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (@Ruta_PDF != null && @Ruta_PDF != "")
                {

                    var certificado = new ValidarCertificado(Directory.GetCurrentDirectory() + "\\..\\..\\..\\ArchivosFacturaElectronica\\certificado_mape.pfx", "1234");
                    var validarPDF = new ValidacionPDF(certificado);

                    //string rutaDoc = BuscarRutaDocumento();

                    int documentoValido = validarPDF.ValidarDocumentoPDF(@Ruta_PDF);

                    switch (documentoValido) {
                        case 0:
                            MessageBox.Show("El archivo PDF es valido, y no ha sido modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 1:
                            MessageBox.Show("El archivo PDF ha sido modificado, y no pudo validarse", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case 2:
                            MessageBox.Show("El archivo selecionado no en un PDF, Selecione un archivo PDF", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case 3:
                            MessageBox.Show("El archivo PDF selecionado no esta firmado, Selecione un PDF que este firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        default:
                            MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;


                    }

                }
                else
                {
                    MessageBox.Show("Selecione primero un archivo PDF firmado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al validar el archivo PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnBuscar_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder22;
        }

        private void btnBuscar_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder2;
        }

        private void brnValidarPDF_MouseEnter(object sender, EventArgs e)
        {
            this.brnValidarPDF.Image = global::control_principal.Properties.Resources.validarpdf2;
        }

        private void brnValidarPDF_MouseLeave(object sender, EventArgs e)
        {
            this.brnValidarPDF.Image = global::control_principal.Properties.Resources.validarpdf;
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
