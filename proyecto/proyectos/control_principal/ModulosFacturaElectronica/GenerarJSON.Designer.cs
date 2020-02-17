namespace control_principal.ModulosFacturaElectronica
{
    partial class GenerarJSON
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRutaXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutaJSON = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSlecionarRutaJSON = new System.Windows.Forms.PictureBox();
            this.btnBuscar_XML = new System.Windows.Forms.PictureBox();
            this.btnCrearJson = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreJSON = new AltoControls.AltoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlecionarRutaJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTxtTitulo
            // 
            this.pnlTxtTitulo.Controls.Add(this.panel1);
            this.pnlTxtTitulo.Controls.Add(this.label4);
            this.pnlTxtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTxtTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTxtTitulo.Name = "pnlTxtTitulo";
            this.pnlTxtTitulo.Size = new System.Drawing.Size(1067, 79);
            this.pnlTxtTitulo.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 1);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 57);
            this.label4.TabIndex = 27;
            this.label4.Text = "Generar JSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ruta XML:";
            // 
            // lblRutaXML
            // 
            this.lblRutaXML.Enabled = false;
            this.lblRutaXML.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaXML.Location = new System.Drawing.Point(255, 203);
            this.lblRutaXML.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaXML.Multiline = true;
            this.lblRutaXML.Name = "lblRutaXML";
            this.lblRutaXML.Size = new System.Drawing.Size(519, 70);
            this.lblRutaXML.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Selecione XML(factura) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ruta JSON:";
            // 
            // txtRutaJSON
            // 
            this.txtRutaJSON.Enabled = false;
            this.txtRutaJSON.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaJSON.Location = new System.Drawing.Point(255, 438);
            this.txtRutaJSON.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaJSON.Multiline = true;
            this.txtRutaJSON.Name = "txtRutaJSON";
            this.txtRutaJSON.Size = new System.Drawing.Size(519, 70);
            this.txtRutaJSON.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "Seleccione la ruta donde se gusrdara el JSON :";
            // 
            // btnSlecionarRutaJSON
            // 
            this.btnSlecionarRutaJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlecionarRutaJSON.Image = global::control_principal.Properties.Resources.folder2;
            this.btnSlecionarRutaJSON.Location = new System.Drawing.Point(685, 366);
            this.btnSlecionarRutaJSON.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlecionarRutaJSON.Name = "btnSlecionarRutaJSON";
            this.btnSlecionarRutaJSON.Size = new System.Drawing.Size(61, 49);
            this.btnSlecionarRutaJSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlecionarRutaJSON.TabIndex = 41;
            this.btnSlecionarRutaJSON.TabStop = false;
            this.btnSlecionarRutaJSON.Click += new System.EventHandler(this.btnSlecionarRutaJSON_Click);
            this.btnSlecionarRutaJSON.MouseEnter += new System.EventHandler(this.btnSlecionarRutaJSON_MouseEnter);
            this.btnSlecionarRutaJSON.MouseLeave += new System.EventHandler(this.btnSlecionarRutaJSON_MouseLeave);
            // 
            // btnBuscar_XML
            // 
            this.btnBuscar_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_XML.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_XML.Location = new System.Drawing.Point(427, 140);
            this.btnBuscar_XML.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_XML.Name = "btnBuscar_XML";
            this.btnBuscar_XML.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_XML.TabIndex = 36;
            this.btnBuscar_XML.TabStop = false;
            this.btnBuscar_XML.Click += new System.EventHandler(this.btnBuscar_XML_Click);
            this.btnBuscar_XML.MouseEnter += new System.EventHandler(this.btnBuscar_XML_MouseEnter);
            this.btnBuscar_XML.MouseLeave += new System.EventHandler(this.btnBuscar_XML_MouseLeave);
            // 
            // btnCrearJson
            // 
            this.btnCrearJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearJson.Image = global::control_principal.Properties.Resources.crearJson;
            this.btnCrearJson.Location = new System.Drawing.Point(396, 527);
            this.btnCrearJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearJson.Name = "btnCrearJson";
            this.btnCrearJson.Size = new System.Drawing.Size(184, 69);
            this.btnCrearJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrearJson.TabIndex = 34;
            this.btnCrearJson.TabStop = false;
            this.btnCrearJson.Click += new System.EventHandler(this.btnCrearJson_Click);
            this.btnCrearJson.MouseEnter += new System.EventHandler(this.btnCrearJson_MouseEnter);
            this.btnCrearJson.MouseLeave += new System.EventHandler(this.btnCrearJson_MouseLeave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return2;
            this.btn_cancelar.Location = new System.Drawing.Point(973, 533);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(63, 57);
            this.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nombre del JSON: ";
            // 
            // txtNombreJSON
            // 
            this.txtNombreJSON.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreJSON.Br = System.Drawing.Color.White;
            this.txtNombreJSON.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtNombreJSON.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreJSON.Location = new System.Drawing.Point(339, 305);
            this.txtNombreJSON.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreJSON.Name = "txtNombreJSON";
            this.txtNombreJSON.Size = new System.Drawing.Size(371, 41);
            this.txtNombreJSON.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(713, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 33);
            this.label7.TabIndex = 47;
            this.label7.Text = ".json ";
            // 
            // GenerarJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1067, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreJSON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRutaJSON);
            this.Controls.Add(this.btnSlecionarRutaJSON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaXML);
            this.Controls.Add(this.btnBuscar_XML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearJson);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarJSON";
            this.Text = "GenerarJSON";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlecionarRutaJSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaXML;
        private System.Windows.Forms.PictureBox btnBuscar_XML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCrearJson;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutaJSON;
        private System.Windows.Forms.PictureBox btnSlecionarRutaJSON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private AltoControls.AltoTextBox txtNombreJSON;
        private System.Windows.Forms.Label label7;
    }
}