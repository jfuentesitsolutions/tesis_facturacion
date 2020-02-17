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
    public partial class PrincipalModulosFacturaElec : Form
    {
        private Form FormularioActivo = null;

        public PrincipalModulosFacturaElec()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlShowO.Controls.Add(formulario);
            pnlShowO.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }



        private void btnValidarXml_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ValidarXML());
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new GenerarPDF());
        }

        private void btnValidarPDF_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ValidarPDF());
        }

        private void btnFirmarPDF_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FirmarPDF());
        }

        private void btnGenerarCertificado_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new GenerarCertificado());
        }

        private void btnGenerarJson_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new GenerarJSON());
        }

        private void btnValidarJSON_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new ValidarJSON());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuLateral.Width == 428)
            {
                pnlMenuLateral.Width = 0;
                //pnlLinea.Width = 53;
            }
            else
            {
                pnlMenuLateral.Width = 428;
              //  pnlLinea.Width = 272;
            }
        }


    }
}
