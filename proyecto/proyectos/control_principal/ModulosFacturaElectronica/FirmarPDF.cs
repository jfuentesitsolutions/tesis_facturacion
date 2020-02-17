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
    public partial class FirmarPDF : Form
    {
        private string Ruta_PDF { get; set; } = null;

        public FirmarPDF()
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

        private void btnFIrmar_PDF_Click(object sender, EventArgs e)
        {
            try
            {


                if (Ruta_PDF != null && Ruta_PDF != "")
                {

                    var certificado = new Certificado(@"C:\Users\Mario\Desktop\certificado_mape.pfx", "1234");
                    var firmante = new Firmante(certificado);
                    firmante.Firmar(Ruta_PDF, @"C:\Users\Mario\Desktop\Documento-firmado.pdf");

                    MessageBox.Show("El documento fue firmado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Selecione un ruta del documento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            catch
            {
                MessageBox.Show("No pudo firmarse el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void btnFIrmar_PDF_MouseEnter(object sender, EventArgs e)
        {
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf2;
        }

        private void btnFIrmar_PDF_MouseLeave(object sender, EventArgs e)
        {
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return22;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return2;
        }

        private void FirmarPDF_Load(object sender, EventArgs e)
        {

        }
    }
}
