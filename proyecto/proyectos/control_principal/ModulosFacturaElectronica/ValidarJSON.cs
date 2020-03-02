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


                switch (validarJson.ValidarJSON(Ruta_JSON)) {

                }

                

            }

        }


    }
}
