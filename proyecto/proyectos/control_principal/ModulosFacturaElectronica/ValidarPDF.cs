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

                    var certificado = new Certificado(@"C:\Users\Mario\Desktop\certificado_mape.pfx", "1234");
                    var notario = new Notario(certificado);

                    //string rutaDoc = BuscarRutaDocumento();

                    var documentoValido = notario.CertificarDocumento(@Ruta_PDF);

                    if (documentoValido)
                    {
                        MessageBox.Show("Documento firmado no ha sufrido modificaciones", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("El documento ha sido modificado, y no pudo validarse", "Alerta", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Selecione primero un PDF firmado", "Alerta", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("EL documento no se pudo validar", "Error", MessageBoxButtons.OK);
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
