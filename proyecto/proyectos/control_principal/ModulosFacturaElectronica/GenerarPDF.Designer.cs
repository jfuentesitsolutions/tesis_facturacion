namespace control_principal.ModulosFacturaElectronica
{
    partial class GenerarPDF
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRutaXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePDF = new AltoControls.AltoTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRutaSelecionadaPDF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelecionarRuta = new System.Windows.Forms.PictureBox();
            this.btnCrear_PDF = new System.Windows.Forms.PictureBox();
            this.btnBuscar_XML = new System.Windows.Forms.PictureBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear_PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).BeginInit();
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
            this.pnlTxtTitulo.TabIndex = 39;
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
            this.label4.Location = new System.Drawing.Point(337, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label4.Size = new System.Drawing.Size(193, 32);
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
            this.label4.Text = "Generar PDF";
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
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
=======
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ruta XML:";
            // 
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(251, 160);
            this.lblRutaXML.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaXML.Multiline = true;
            this.lblRutaXML.Name = "lblRutaXML";
<<<<<<< HEAD
            this.lblRutaXML.Size = new System.Drawing.Size(750, 55);
=======
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ruta XML:";
            // 
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(251, 160);
            this.lblRutaXML.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaXML.Multiline = true;
            this.lblRutaXML.Name = "lblRutaXML";
            this.lblRutaXML.Size = new System.Drawing.Size(519, 67);
<<<<<<< HEAD
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.lblRutaXML.Size = new System.Drawing.Size(519, 67);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.lblRutaXML.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(53, 100);
=======
            this.label1.Location = new System.Drawing.Point(103, 93);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 33;
<<<<<<< HEAD
            this.label1.Text = "Buscar XML(factura) :";
=======
            this.label1.Location = new System.Drawing.Point(103, 93);
            this.label1.Name = "label1";
=======
            this.label1.Location = new System.Drawing.Point(103, 93);
            this.label1.Name = "label1";
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 33;
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label1.Text = "Selecione XML(factura) :";
            // 
            // txtNombrePDF
            // 
            this.txtNombrePDF.BackColor = System.Drawing.Color.Transparent;
            this.txtNombrePDF.Br = System.Drawing.Color.White;
            this.txtNombrePDF.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtNombrePDF.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePDF.Location = new System.Drawing.Point(335, 253);
            this.txtNombrePDF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePDF.Name = "txtNombrePDF";
            this.txtNombrePDF.Size = new System.Drawing.Size(369, 41);
            this.txtNombrePDF.TabIndex = 48;
<<<<<<< HEAD
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(53, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
=======
            this.label3.Location = new System.Drawing.Point(103, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label3.Location = new System.Drawing.Point(103, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.label3.Location = new System.Drawing.Point(103, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre del pdf : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(53, 364);
=======
            this.label5.Location = new System.Drawing.Point(103, 338);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(548, 33);
            this.label5.TabIndex = 49;
            this.label5.Text = "Selecione la ruta donde se guardara el pdf : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ruta PDF:";
            // 
            // txtRutaSelecionadaPDF
            // 
            this.txtRutaSelecionadaPDF.Enabled = false;
            this.txtRutaSelecionadaPDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaSelecionadaPDF.Location = new System.Drawing.Point(248, 402);
            this.txtRutaSelecionadaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaSelecionadaPDF.Multiline = true;
            this.txtRutaSelecionadaPDF.Name = "txtRutaSelecionadaPDF";
            this.txtRutaSelecionadaPDF.Size = new System.Drawing.Size(519, 72);
            this.txtRutaSelecionadaPDF.TabIndex = 51;
            // 
<<<<<<< HEAD
=======
            this.label5.Location = new System.Drawing.Point(103, 338);
            this.label5.Name = "label5";
=======
            this.label5.Location = new System.Drawing.Point(103, 338);
            this.label5.Name = "label5";
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
            this.label5.Size = new System.Drawing.Size(548, 33);
            this.label5.TabIndex = 49;
            this.label5.Text = "Selecione la ruta donde se guardara el pdf : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ruta PDF:";
            // 
            // txtRutaSelecionadaPDF
            // 
            this.txtRutaSelecionadaPDF.Enabled = false;
            this.txtRutaSelecionadaPDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaSelecionadaPDF.Location = new System.Drawing.Point(248, 402);
            this.txtRutaSelecionadaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaSelecionadaPDF.Multiline = true;
            this.txtRutaSelecionadaPDF.Name = "txtRutaSelecionadaPDF";
            this.txtRutaSelecionadaPDF.Size = new System.Drawing.Size(519, 72);
            this.txtRutaSelecionadaPDF.TabIndex = 51;
            // 
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(708, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 33);
            this.label7.TabIndex = 53;
            this.label7.Text = ".pdf";
            // 
<<<<<<< HEAD
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            // btnSelecionarRuta
            // 
            this.btnSelecionarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarRuta.Image = global::control_principal.Properties.Resources.folder2;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnSelecionarRuta.Location = new System.Drawing.Point(748, 356);
=======
            this.btnSelecionarRuta.Location = new System.Drawing.Point(658, 322);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnSelecionarRuta.Location = new System.Drawing.Point(658, 322);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnSelecionarRuta.Location = new System.Drawing.Point(658, 322);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.btnSelecionarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarRuta.Name = "btnSelecionarRuta";
            this.btnSelecionarRuta.Size = new System.Drawing.Size(61, 49);
            this.btnSelecionarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelecionarRuta.TabIndex = 50;
            this.btnSelecionarRuta.TabStop = false;
            this.btnSelecionarRuta.Click += new System.EventHandler(this.btnSelecionarRuta_Click);
            this.btnSelecionarRuta.MouseEnter += new System.EventHandler(this.btnSelecionarRuta_MouseEnter);
            this.btnSelecionarRuta.MouseLeave += new System.EventHandler(this.btnSelecionarRuta_MouseLeave);
            // 
            // btnCrear_PDF
            // 
            this.btnCrear_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear_PDF.Image = global::control_principal.Properties.Resources.crearPDF1;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnCrear_PDF.Location = new System.Drawing.Point(309, 517);
=======
            this.btnCrear_PDF.Location = new System.Drawing.Point(301, 539);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnCrear_PDF.Location = new System.Drawing.Point(301, 539);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnCrear_PDF.Location = new System.Drawing.Point(301, 539);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.btnCrear_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear_PDF.Name = "btnCrear_PDF";
            this.btnCrear_PDF.Size = new System.Drawing.Size(244, 94);
            this.btnCrear_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrear_PDF.TabIndex = 36;
            this.btnCrear_PDF.TabStop = false;
            this.btnCrear_PDF.Click += new System.EventHandler(this.btnCrear_PDF_Click);
            this.btnCrear_PDF.MouseEnter += new System.EventHandler(this.btnCrear_PDF_MouseEnter);
            this.btnCrear_PDF.MouseLeave += new System.EventHandler(this.btnCrear_PDF_MouseLeave);
            // 
            // btnBuscar_XML
            // 
            this.btnBuscar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnBuscar_XML.Location = new System.Drawing.Point(382, 89);
=======
            this.btnBuscar_XML.Location = new System.Drawing.Point(437, 82);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnBuscar_XML.Location = new System.Drawing.Point(437, 82);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.btnBuscar_XML.Location = new System.Drawing.Point(437, 82);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.btnBuscar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_XML.Name = "btnBuscar_XML";
            this.btnBuscar_XML.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_XML.TabIndex = 35;
            this.btnBuscar_XML.TabStop = false;
            this.btnBuscar_XML.Click += new System.EventHandler(this.btnBuscar_XML_Click);
            this.btnBuscar_XML.MouseEnter += new System.EventHandler(this.btnBuscar_XML_MouseEnter);
            this.btnBuscar_XML.MouseLeave += new System.EventHandler(this.btnBuscar_XML_MouseLeave);
            // 
            // GenerarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(863, 631);
=======
=======
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
            this.ClientSize = new System.Drawing.Size(863, 660);
            this.Controls.Add(this.label7);
>>>>>>> parent of 307fd4a... envio de archivos por correo y reparacion de pdf
=======
            this.ClientSize = new System.Drawing.Size(863, 660);
            this.Controls.Add(this.label7);
>>>>>>> parent of 543427e... gusrdar las rutas de los archivos(pdf,xml,json) en la base de datos
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRutaSelecionadaPDF);
            this.Controls.Add(this.btnSelecionarRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombrePDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaXML);
            this.Controls.Add(this.btnCrear_PDF);
            this.Controls.Add(this.btnBuscar_XML);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarPDF";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarPDF";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear_PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaXML;
        private System.Windows.Forms.PictureBox btnCrear_PDF;
        private System.Windows.Forms.PictureBox btnBuscar_XML;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox txtNombrePDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnSelecionarRuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRutaSelecionadaPDF;
        private System.Windows.Forms.Label label7;
    }
}