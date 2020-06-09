using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace espera_datos
{
    public partial class splash_espera : Form
    {
        public splash_espera()
        {
            InitializeComponent();
        }
        private int tipo_operacio=0;
        string titulo;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public Action Accion
        {
            get
            {
                return accion;
            }

            set
            {
                accion = value;
            }
        }

        public Func<List<DataTable>> Funcion
        {
            get
            {
                return funcion;
            }

            set
            {
                funcion = value;
            }
        }

        public int Tipo_operacio
        {
            get
            {
                return tipo_operacio;
            }

            set
            {
                tipo_operacio = value;
            }
        }

        public Func<List<bool>> Funcion_listo
        {
            get
            {
                return funcion_listo;
            }

            set
            {
                funcion_listo = value;
            }
        }

        public Func<int> Funcion_verificar
        {
            get
            {
                return funcion_verificar;
            }

            set
            {
                funcion_verificar = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public bool Creado
        {
            get
            {
                return creado;
            }

            set
            {
                creado = value;
            }
        }

        public DataTable Datos
        {
            get
            {
                return datos;
            }

            set
            {
                datos = value;
            }
        }

        public List<DataTable> Datos_varios
        {
            get
            {
                return datos_varios;
            }

            set
            {
                datos_varios = value;
            }
        }

        public Func<bool> Validando
        {
            get
            {
                return validando;
            }

            set
            {
                validando = value;
            }
        }

    

        Action accion;

        Func<List<DataTable>> funcion;
        Func<List<bool>> funcion_listo;
        Func<int> funcion_verificar;
        Func<bool> validando;
        int numero = 1;
        bool creado = false;
        DataTable datos = null;
        List<DataTable> datos_varios = null;


        private void splash_espera_Shown(object sender, EventArgs e)
        {
            switch (tipo_operacio)
            {
                case 0:
                    {
                        Task.Factory.StartNew(Funcion).ContinueWith((t) => taskCompleted(t.Result[0], t.Result));
                        break;
                    }
                case 1:
                    {
                        Task.Factory.StartNew(Funcion_listo).ContinueWith((t) => taskCompleted1(t.Result[0]));
                        break;
                    }
                case 2:
                    {
                        Task.Factory.StartNew(Funcion_verificar).ContinueWith((t) => taskCompleted2(t.Result));
                        break;
                    }
                case 3:
                    {
                        Task.Factory.StartNew(validando).ContinueWith((t) => taskCompleted3(t.Result));
                        break;
                    }

            }
            
        }

        private void taskCompleted3(bool r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    creado = r;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted2(int r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    numero = r;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted1(bool r)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    creado = r;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void taskCompleted(DataTable d, List<DataTable> da)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    datos_varios = da;
                    datos = d;
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }
         
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splash_espera_Load(object sender, EventArgs e)
        {
            
        }
    }
}
