namespace control_principal.ModulosFacturaElectronica
{
    partial class PrincipalModulosFacturaElec
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
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnValidarJSON = new System.Windows.Forms.Button();
            this.btnGenerarJson = new System.Windows.Forms.Button();
            this.pnlGenerarCertificado = new System.Windows.Forms.Panel();
            this.btnGenerarCertificado = new System.Windows.Forms.Button();
            this.pnlFirmarPDF = new System.Windows.Forms.Panel();
            this.btnFirmarPDF = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnValidarPDF = new System.Windows.Forms.Button();
            this.pnlXMLtoPDF = new System.Windows.Forms.Panel();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.pnlValidarXML = new System.Windows.Forms.Panel();
            this.btnValidarXml = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlShowO = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlGenerarCertificado.SuspendLayout();
            this.pnlFirmarPDF.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlXMLtoPDF.SuspendLayout();
            this.pnlValidarXML.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlShowO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlBarraTitulo.Controls.Add(this.label1);
            this.pnlBarraTitulo.Controls.Add(this.btnMenu);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1249, 55);
            this.pnlBarraTitulo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::control_principal.Properties.Resources.Menu1;
            this.btnMenu.Location = new System.Drawing.Point(11, 9);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 36);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlMenuLateral.Controls.Add(this.btnValidarJSON);
            this.pnlMenuLateral.Controls.Add(this.btnGenerarJson);
            this.pnlMenuLateral.Controls.Add(this.pnlGenerarCertificado);
            this.pnlMenuLateral.Controls.Add(this.pnlFirmarPDF);
            this.pnlMenuLateral.Controls.Add(this.panel4);
            this.pnlMenuLateral.Controls.Add(this.pnlXMLtoPDF);
            this.pnlMenuLateral.Controls.Add(this.pnlValidarXML);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 55);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(380, 695);
            this.pnlMenuLateral.TabIndex = 12;
            // 
            // btnValidarJSON
            // 
            this.btnValidarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarJSON.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValidarJSON.FlatAppearance.BorderSize = 0;
            this.btnValidarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarJSON.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnValidarJSON.Image = global::control_principal.Properties.Resources.validar32;
            this.btnValidarJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarJSON.Location = new System.Drawing.Point(0, 566);
            this.btnValidarJSON.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarJSON.Name = "btnValidarJSON";
            this.btnValidarJSON.Padding = new System.Windows.Forms.Padding(20, 0, 137, 0);
            this.btnValidarJSON.Size = new System.Drawing.Size(380, 80);
            this.btnValidarJSON.TabIndex = 14;
            this.btnValidarJSON.Text = "Validar JSON";
            this.btnValidarJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarJSON.UseVisualStyleBackColor = true;
            this.btnValidarJSON.Click += new System.EventHandler(this.btnValidarJSON_Click);
            // 
            // btnGenerarJson
            // 
            this.btnGenerarJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarJson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarJson.FlatAppearance.BorderSize = 0;
            this.btnGenerarJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarJson.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenerarJson.Image = global::control_principal.Properties.Resources.json;
            this.btnGenerarJson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarJson.Location = new System.Drawing.Point(0, 486);
            this.btnGenerarJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarJson.Name = "btnGenerarJson";
            this.btnGenerarJson.Padding = new System.Windows.Forms.Padding(20, 0, 128, 0);
            this.btnGenerarJson.Size = new System.Drawing.Size(380, 80);
            this.btnGenerarJson.TabIndex = 1;
            this.btnGenerarJson.Text = "Generar JSON";
            this.btnGenerarJson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarJson.UseVisualStyleBackColor = true;
            this.btnGenerarJson.Click += new System.EventHandler(this.btnGenerarJson_Click);
            // 
            // pnlGenerarCertificado
            // 
            this.pnlGenerarCertificado.Controls.Add(this.btnGenerarCertificado);
            this.pnlGenerarCertificado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenerarCertificado.Location = new System.Drawing.Point(0, 406);
            this.pnlGenerarCertificado.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGenerarCertificado.Name = "pnlGenerarCertificado";
            this.pnlGenerarCertificado.Size = new System.Drawing.Size(380, 80);
            this.pnlGenerarCertificado.TabIndex = 12;
            // 
            // btnGenerarCertificado
            // 
            this.btnGenerarCertificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnGenerarCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCertificado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerarCertificado.FlatAppearance.BorderSize = 0;
            this.btnGenerarCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCertificado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenerarCertificado.Image = global::control_principal.Properties.Resources.certificado32;
            this.btnGenerarCertificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCertificado.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarCertificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCertificado.Name = "btnGenerarCertificado";
            this.btnGenerarCertificado.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.btnGenerarCertificado.Size = new System.Drawing.Size(380, 80);
            this.btnGenerarCertificado.TabIndex = 10;
            this.btnGenerarCertificado.Text = "Generar Certificado";
            this.btnGenerarCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCertificado.UseVisualStyleBackColor = false;
            this.btnGenerarCertificado.Click += new System.EventHandler(this.btnGenerarCertificado_Click);
            // 
            // pnlFirmarPDF
            // 
            this.pnlFirmarPDF.Controls.Add(this.btnFirmarPDF);
            this.pnlFirmarPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFirmarPDF.Location = new System.Drawing.Point(0, 326);
            this.pnlFirmarPDF.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFirmarPDF.Name = "pnlFirmarPDF";
            this.pnlFirmarPDF.Size = new System.Drawing.Size(380, 80);
            this.pnlFirmarPDF.TabIndex = 12;
            // 
            // btnFirmarPDF
            // 
            this.btnFirmarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnFirmarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmarPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirmarPDF.FlatAppearance.BorderSize = 0;
            this.btnFirmarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmarPDF.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFirmarPDF.Image = global::control_principal.Properties.Resources.firmar32;
            this.btnFirmarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmarPDF.Location = new System.Drawing.Point(0, 0);
            this.btnFirmarPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirmarPDF.Name = "btnFirmarPDF";
            this.btnFirmarPDF.Padding = new System.Windows.Forms.Padding(21, 0, 152, 0);
            this.btnFirmarPDF.Size = new System.Drawing.Size(380, 80);
            this.btnFirmarPDF.TabIndex = 8;
            this.btnFirmarPDF.Text = "Firmar PDF";
            this.btnFirmarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmarPDF.UseVisualStyleBackColor = false;
            this.btnFirmarPDF.Click += new System.EventHandler(this.btnFirmarPDF_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnValidarPDF);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 80);
            this.panel4.TabIndex = 12;
            // 
            // btnValidarPDF
            // 
            this.btnValidarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnValidarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidarPDF.FlatAppearance.BorderSize = 0;
            this.btnValidarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarPDF.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnValidarPDF.Image = global::control_principal.Properties.Resources.validar32;
            this.btnValidarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarPDF.Location = new System.Drawing.Point(0, 0);
            this.btnValidarPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarPDF.Name = "btnValidarPDF";
            this.btnValidarPDF.Padding = new System.Windows.Forms.Padding(16, 0, 149, 0);
            this.btnValidarPDF.Size = new System.Drawing.Size(380, 80);
            this.btnValidarPDF.TabIndex = 9;
            this.btnValidarPDF.Text = "Validar PDF";
            this.btnValidarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarPDF.UseVisualStyleBackColor = false;
            this.btnValidarPDF.Click += new System.EventHandler(this.btnValidarPDF_Click);
            // 
            // pnlXMLtoPDF
            // 
            this.pnlXMLtoPDF.Controls.Add(this.btnGenerarPDF);
            this.pnlXMLtoPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLtoPDF.Location = new System.Drawing.Point(0, 166);
            this.pnlXMLtoPDF.Margin = new System.Windows.Forms.Padding(4);
            this.pnlXMLtoPDF.Name = "pnlXMLtoPDF";
            this.pnlXMLtoPDF.Size = new System.Drawing.Size(380, 80);
            this.pnlXMLtoPDF.TabIndex = 12;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenerarPDF.Image = global::control_principal.Properties.Resources.pdf32;
            this.btnGenerarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPDF.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Padding = new System.Windows.Forms.Padding(20, 0, 140, 0);
            this.btnGenerarPDF.Size = new System.Drawing.Size(380, 80);
            this.btnGenerarPDF.TabIndex = 7;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // pnlValidarXML
            // 
            this.pnlValidarXML.Controls.Add(this.btnValidarXml);
            this.pnlValidarXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValidarXML.Location = new System.Drawing.Point(0, 86);
            this.pnlValidarXML.Margin = new System.Windows.Forms.Padding(4);
            this.pnlValidarXML.Name = "pnlValidarXML";
            this.pnlValidarXML.Size = new System.Drawing.Size(380, 80);
            this.pnlValidarXML.TabIndex = 12;
            // 
            // btnValidarXml
            // 
            this.btnValidarXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnValidarXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidarXml.FlatAppearance.BorderSize = 0;
            this.btnValidarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarXml.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnValidarXml.Image = global::control_principal.Properties.Resources.validar32;
            this.btnValidarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarXml.Location = new System.Drawing.Point(0, 0);
            this.btnValidarXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarXml.Name = "btnValidarXml";
            this.btnValidarXml.Padding = new System.Windows.Forms.Padding(16, 0, 144, 0);
            this.btnValidarXml.Size = new System.Drawing.Size(380, 80);
            this.btnValidarXml.TabIndex = 6;
            this.btnValidarXml.Text = "Validar XML ";
            this.btnValidarXml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarXml.UseVisualStyleBackColor = false;
            this.btnValidarXml.Click += new System.EventHandler(this.btnValidarXml_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlLogo.Controls.Add(this.pnlLinea);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.pictureBox5);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(380, 86);
            this.pnlLogo.TabIndex = 12;
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.White;
            this.pnlLinea.Location = new System.Drawing.Point(9, 78);
            this.pnlLinea.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(363, 1);
            this.pnlLinea.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Factura Electronica";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::control_principal.Properties.Resources.logo2;
            this.pictureBox5.Location = new System.Drawing.Point(8, 14);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pnlShowO
            // 
            this.pnlShowO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlShowO.Controls.Add(this.pictureBox1);
            this.pnlShowO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowO.Location = new System.Drawing.Point(380, 55);
            this.pnlShowO.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShowO.Name = "pnlShowO";
            this.pnlShowO.Size = new System.Drawing.Size(869, 695);
            this.pnlShowO.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::control_principal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(195, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PrincipalModulosFacturaElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 750);
            this.Controls.Add(this.pnlShowO);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalModulosFacturaElec";
            this.Text = "PrincipalModulosFacturaElec";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlGenerarCertificado.ResumeLayout(false);
            this.pnlFirmarPDF.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlXMLtoPDF.ResumeLayout(false);
            this.pnlValidarXML.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlShowO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnValidarJSON;
        private System.Windows.Forms.Button btnGenerarJson;
        private System.Windows.Forms.Panel pnlGenerarCertificado;
        private System.Windows.Forms.Button btnGenerarCertificado;
        private System.Windows.Forms.Panel pnlFirmarPDF;
        private System.Windows.Forms.Button btnFirmarPDF;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnValidarPDF;
        private System.Windows.Forms.Panel pnlXMLtoPDF;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Panel pnlValidarXML;
        private System.Windows.Forms.Button btnValidarXml;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlShowO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}