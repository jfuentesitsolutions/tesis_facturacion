﻿using System;
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

        Action accion;

        Func<List<DataTable>> funcion;

        private void splash_espera_Shown(object sender, EventArgs e)
        {
            
            Task.Factory.StartNew(Funcion).ContinueWith((t) => taskCompleted());
        }

        private void taskCompleted()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
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
