namespace control_principal.ModulosFacturaElectronica
{
    partial class GenerarCertificado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTxtTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.txtNombrePFX = new AltoControls.AltoTextBox();
            this.txtTiempoValides = new AltoControls.AltoNMUpDown();
            this.txtLongitudBit = new AltoControls.AltoNMUpDown();
            this.txtPass = new AltoControls.AltoTextBox();
            this.txtNombreKey = new AltoControls.AltoTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar_PFX = new System.Windows.Forms.PictureBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar_PFX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTxtTitulo
            // 
            this.pnlTxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTxtTitulo.Controls.Add(this.panel1);
            this.pnlTxtTitulo.Controls.Add(this.label4);
            this.pnlTxtTitulo.Controls.Add(this.btn_cancelar);
            this.pnlTxtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxtTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTxtTitulo.Name = "pnlTxtTitulo";
            this.pnlTxtTitulo.Size = new System.Drawing.Size(863, 46);
            this.pnlTxtTitulo.TabIndex = 51;
            this.pnlTxtTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTxtTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 1);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(331, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label4.Size = new System.Drawing.Size(192, 32);
=======
            this.label4.Size = new System.Drawing.Size(173, 34);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label4.Size = new System.Drawing.Size(173, 34);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label4.Size = new System.Drawing.Size(173, 34);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label4.TabIndex = 27;
            this.label4.Text = "Generar PFX";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
            this.btn_cancelar.Location = new System.Drawing.Point(805, 3);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(49, 39);
            this.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // txtTiempoValides
            // 
            this.txtTiempoValides.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtTiempoValides.Location = new System.Drawing.Point(362, 329);
=======
            // txtNombrePFX
            // 
            this.txtNombrePFX.BackColor = System.Drawing.Color.Transparent;
            this.txtNombrePFX.Br = System.Drawing.Color.White;
            this.txtNombrePFX.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtNombrePFX.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePFX.Location = new System.Drawing.Point(364, 396);
            this.txtNombrePFX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePFX.Name = "txtNombrePFX";
            this.txtNombrePFX.Size = new System.Drawing.Size(389, 41);
            this.txtNombrePFX.TabIndex = 49;
            // 
            // txtTiempoValides
            // 
            this.txtTiempoValides.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtTiempoValides.Location = new System.Drawing.Point(364, 314);
<<<<<<< HEAD
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            // txtNombrePFX
            // 
            this.txtNombrePFX.BackColor = System.Drawing.Color.Transparent;
            this.txtNombrePFX.Br = System.Drawing.Color.White;
            this.txtNombrePFX.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtNombrePFX.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePFX.Location = new System.Drawing.Point(364, 396);
            this.txtNombrePFX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePFX.Name = "txtNombrePFX";
            this.txtNombrePFX.Size = new System.Drawing.Size(389, 41);
            this.txtNombrePFX.TabIndex = 49;
            // 
            // txtTiempoValides
            // 
            this.txtTiempoValides.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txtTiempoValides.Location = new System.Drawing.Point(364, 314);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.txtTiempoValides.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoValides.Name = "txtTiempoValides";
            this.txtTiempoValides.SignColor = System.Drawing.Color.White;
            this.txtTiempoValides.Size = new System.Drawing.Size(185, 57);
            this.txtTiempoValides.TabIndex = 48;
            this.txtTiempoValides.Value = 365D;
            // 
            // txtLongitudBit
            // 
            this.txtLongitudBit.Font = new System.Drawing.Font("Comic Sans MS", 12F);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtLongitudBit.Location = new System.Drawing.Point(362, 244);
=======
            this.txtLongitudBit.Location = new System.Drawing.Point(364, 229);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.txtLongitudBit.Location = new System.Drawing.Point(364, 229);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.txtLongitudBit.Location = new System.Drawing.Point(364, 229);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.txtLongitudBit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongitudBit.Name = "txtLongitudBit";
            this.txtLongitudBit.SignColor = System.Drawing.Color.White;
            this.txtLongitudBit.Size = new System.Drawing.Size(185, 57);
            this.txtLongitudBit.TabIndex = 47;
            this.txtLongitudBit.Value = 2048D;
            // 
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Br = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(364, 164);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(389, 41);
            this.txtPass.TabIndex = 46;
            // 
            // txtNombreKey
            // 
            this.txtNombreKey.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreKey.Br = System.Drawing.Color.White;
            this.txtNombreKey.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtNombreKey.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreKey.Location = new System.Drawing.Point(364, 94);
            this.txtNombreKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreKey.Name = "txtNombreKey";
            this.txtNombreKey.Size = new System.Drawing.Size(389, 41);
            this.txtNombreKey.TabIndex = 45;
            // 
<<<<<<< HEAD
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label12.Location = new System.Drawing.Point(753, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 31);
=======
            this.label12.Location = new System.Drawing.Point(755, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label12.Location = new System.Drawing.Point(755, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label12.Location = new System.Drawing.Point(755, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label12.TabIndex = 43;
            this.label12.Text = ".pfx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label13.Location = new System.Drawing.Point(44, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 31);
=======
            this.label13.Location = new System.Drawing.Point(61, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label13.Location = new System.Drawing.Point(61, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label13.Location = new System.Drawing.Point(61, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label13.TabIndex = 42;
            this.label13.Text = "Nombre  archivo PFX:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label11.Location = new System.Drawing.Point(554, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 31);
=======
            this.label11.Location = new System.Drawing.Point(556, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label11.Location = new System.Drawing.Point(556, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label11.Location = new System.Drawing.Point(556, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label11.TabIndex = 41;
            this.label11.Text = "bit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label10.Location = new System.Drawing.Point(753, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 31);
=======
            this.label10.Location = new System.Drawing.Point(755, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label10.Location = new System.Drawing.Point(755, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label10.Location = new System.Drawing.Point(755, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label10.TabIndex = 40;
            this.label10.Text = ".key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label8.Location = new System.Drawing.Point(554, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
=======
            this.label8.Location = new System.Drawing.Point(556, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label8.Location = new System.Drawing.Point(556, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label8.Location = new System.Drawing.Point(556, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label8.TabIndex = 39;
            this.label8.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(44, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 31);
=======
            this.label6.Location = new System.Drawing.Point(61, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label6.Location = new System.Drawing.Point(61, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label6.Location = new System.Drawing.Point(61, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label6.TabIndex = 38;
            this.label6.Text = "Tiempo de valides:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(44, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 31);
=======
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label3.TabIndex = 37;
            this.label3.Text = "Logitud de llave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 31);
=======
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre de llave RSA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(44, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
=======
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label1.TabIndex = 35;
            this.label1.Text = "Contraseña llave:";
            // 
            // btnGenerar_PFX
            // 
            this.btnGenerar_PFX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar_PFX.Image = global::control_principal.Properties.Resources.generarpfx;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnGenerar_PFX.Location = new System.Drawing.Point(310, 516);
=======
            this.btnGenerar_PFX.Location = new System.Drawing.Point(305, 516);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnGenerar_PFX.Location = new System.Drawing.Point(305, 516);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnGenerar_PFX.Location = new System.Drawing.Point(305, 516);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.btnGenerar_PFX.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar_PFX.Name = "btnGenerar_PFX";
            this.btnGenerar_PFX.Size = new System.Drawing.Size(244, 94);
            this.btnGenerar_PFX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGenerar_PFX.TabIndex = 50;
            this.btnGenerar_PFX.TabStop = false;
            this.btnGenerar_PFX.MouseEnter += new System.EventHandler(this.btnGenerar_PFX_MouseEnter);
            this.btnGenerar_PFX.MouseLeave += new System.EventHandler(this.btnGenerar_PFX_MouseLeave);
            // 
            // GenerarCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(863, 660);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.Controls.Add(this.txtNombrePFX);
            this.Controls.Add(this.btnVisibilidadPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombreKey);
=======
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.btnGenerar_PFX);
            this.Controls.Add(this.txtNombrePFX);
            this.Controls.Add(this.txtTiempoValides);
            this.Controls.Add(this.txtLongitudBit);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombreKey);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarCertificado";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarCertificado";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar_PFX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnGenerar_PFX;
        private AltoControls.AltoTextBox txtNombrePFX;
        private AltoControls.AltoNMUpDown txtTiempoValides;
        private AltoControls.AltoNMUpDown txtLongitudBit;
        private AltoControls.AltoTextBox txtPass;
        private AltoControls.AltoTextBox txtNombreKey;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}