using ModulosfacturaElectronica.ClasesValidacion;
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
    public partial class ValidarJSON : Form
    {
        public string Ruta_JSON { get; set; } = null;

        public ValidarJSON()
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_JSON_Click(object sender, EventArgs e)
        {
            string RutaJson = BuscarRutaDocumento();
            lblRutaJSON.Text = RutaJson;
            Ruta_JSON = RutaJson;
        }

        private void btnValidarJson_Click(object sender, EventArgs e)
        {
            if (Ruta_JSON != null && Ruta_JSON != "")
            {
                FirmaElectronica validarJson = new FirmaElectronica();


                switch (validarJson.ValidarJSON(Ruta_JSON))
                {
                    case 0:
                        MessageBox.Show("El JSON es valido, el contenido no ha sufrido cambios", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("El archivo que selecciono no es un JSON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 2:
                        MessageBox.Show("Error al tratar de encontrar el archivo xslt", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("Version de comprobate invalida, verifique que la version sea (3.3 ó 3.2) del comprobante", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 4:
                        MessageBox.Show("El JSON es invalido, su contenido ha sido modificado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 5:
                        MessageBox.Show("Error al validarce el JSON", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

            }
            else {
                MessageBox.Show("Seleccione un archivo JSON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }


    }
}
