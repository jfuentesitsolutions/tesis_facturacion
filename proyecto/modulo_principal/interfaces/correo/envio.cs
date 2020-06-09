using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitarios;

namespace interfaces.correo
{
    public partial class envio : Form
    {
        string rutaArchivo = "";
        string rutaArchivo2 = "";
        bool enviado = false;

        public string RutaArchivo
        {
            get
            {
                return rutaArchivo;
            }

            set
            {
                rutaArchivo = value;
            }
        }

        public bool Enviado
        {
            get
            {
                return enviado;
            }

            set
            {
                enviado = value;
            }
        }

        public string RutaArchivo2
        {
            get
            {
                return rutaArchivo2;
            }

            set
            {
                rutaArchivo2 = value;
            }
        }

        public envio()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validando()
        {
            bool valido = false;
            error.Clear();

            if (txtCorreo.Text.Length == 0)
            {
                error.SetError(txtCorreo, "Tienes que colocar un correo");
                valido = true;
            }
            if (!validarCorreo(txtCorreo.Text))
            {
                error.SetError(txtCorreo, "EL correo no es valido");
                valido = true;
            }


            return valido;
        }
        private bool validarCorreo(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensa = "";
            if (!validando())
            {
                if (txtMensaje.Text.Length == 0)
                {
                    mensa = "Hola buen dia esta es la factura generada por el sistema de emision de factura gracias";
                }
                else
                {
                    mensa = txtMensaje.Text;
                }

                envio_correo corre = new envio_correo("vfjhovanyitsolutions@gmail.com", "Fuentes2019", mensa, "Factura electrónica", txtCorreo.Text, rutaArchivo, rutaArchivo2+".pdf");

                using (espera_datos.splash_espera fe = new espera_datos.splash_espera())
                {
                    fe.Validando = corre.enviar;
                    fe.Tipo_operacio = 3;

                    if (fe.ShowDialog() == DialogResult.OK)
                    {
                        if (fe.Creado)
                        {
                            MessageBox.Show("El correo fue enviado con exito", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.enviado = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo enviar el correo", "Correo no enviado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
