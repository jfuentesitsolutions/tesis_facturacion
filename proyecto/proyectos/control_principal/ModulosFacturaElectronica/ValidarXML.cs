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
    public partial class ValidarXML : Form
    {
        private string Ruta_XML { get;  set; }
        private FirmaElectronica _firma = new FirmaElectronica();

        public ValidarXML()
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

        private void btnBuscar_XML_Click(object sender, EventArgs e)
        {
            string RutaXML = BuscarRutaDocumento();
            lblRutaXML.Text = RutaXML;
            Ruta_XML = RutaXML;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidar_XML_Click(object sender, EventArgs e)
        {
          

            if (Ruta_XML != null && Ruta_XML != "")
            {

                switch (_firma.VerificarXML(Ruta_XML)) {
                    case 0:
                           MessageBox.Show("El XML es valido, el contenido no ha tenido cambios", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                           
                    case 1:
                            MessageBox.Show("La ubicacion del archivo XSLT es incorrecta, o el tipo de archivo seleccionado es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                                   
                    case 2:
                            MessageBox.Show("El archivo XML selecionado es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;        
                           
                    case 3:
                            MessageBox.Show("El XML es invalido, su contenido ha sido modificado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;              
                        
                    case 4:
                            MessageBox.Show("Error al validar el xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                           
                    default:
                            MessageBox.Show("Indice de error invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            
                        
                }

            }
            else
            {
                MessageBox.Show("Seleccione un XML", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnValidar_XML_MouseEnter(object sender, EventArgs e)
        {
            this.btnValidar_XML.Image = global::control_principal.Properties.Resources.validar_xml2;
        }

        private void btnValidar_XML_MouseLeave(object sender, EventArgs e)
        {
            this.btnValidar_XML.Image = global::control_principal.Properties.Resources.validar_xml;
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
