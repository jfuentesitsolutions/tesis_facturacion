namespace control_principal.ModulosFacturaElectronica
{
    partial class FirmarPDF
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
            this.lblRutaPDF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaGuardarPDFirmado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraPFX = new AltoControls.AltoTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelecionarCarpetaGuardar = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.btnFIrmar_PDF = new System.Windows.Forms.PictureBox();
            this.btnBuscar_PDF = new System.Windows.Forms.PictureBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarCarpetaGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFIrmar_PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_PDF)).BeginInit();
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
            this.pnlTxtTitulo.Name = "pnlTxtTitulo";
            this.pnlTxtTitulo.Size = new System.Drawing.Size(642, 37);
            this.pnlTxtTitulo.TabIndex = 39;
            this.pnlTxtTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTxtTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 1);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Firmar PDF";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ruta:";
            // 
            // lblRutaPDF
            // 
            this.lblRutaPDF.Enabled = false;
            this.lblRutaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaPDF.Location = new System.Drawing.Point(94, 186);
            this.lblRutaPDF.Multiline = true;
            this.lblRutaPDF.Name = "lblRutaPDF";
            this.lblRutaPDF.Size = new System.Drawing.Size(527, 73);
            this.lblRutaPDF.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecione PDF :";
            // 
            // txtRutaGuardarPDFirmado
            // 
            this.txtRutaGuardarPDFirmado.Enabled = false;
            this.txtRutaGuardarPDFirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaGuardarPDFirmado.Location = new System.Drawing.Point(94, 338);
            this.txtRutaGuardarPDFirmado.Multiline = true;
            this.txtRutaGuardarPDFirmado.Name = "txtRutaGuardarPDFirmado";
            this.txtRutaGuardarPDFirmado.Size = new System.Drawing.Size(527, 68);
            this.txtRutaGuardarPDFirmado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Selecione la ruta donde se guardara el pdf firmado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ruta:";
            // 
            // txtContraPFX
            // 
            this.txtContraPFX.BackColor = System.Drawing.Color.Transparent;
            this.txtContraPFX.Br = System.Drawing.Color.White;
            this.txtContraPFX.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtContraPFX.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraPFX.Location = new System.Drawing.Point(340, 77);
            this.txtContraPFX.Name = "txtContraPFX";
            this.txtContraPFX.Size = new System.Drawing.Size(281, 33);
            this.txtContraPFX.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Contraseña de almacen PFX:";
            // 
            // btnSelecionarCarpetaGuardar
            // 
            this.btnSelecionarCarpetaGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarCarpetaGuardar.Image = global::control_principal.Properties.Resources.folder2;
            this.btnSelecionarCarpetaGuardar.Location = new System.Drawing.Point(575, 273);
            this.btnSelecionarCarpetaGuardar.Name = "btnSelecionarCarpetaGuardar";
            this.btnSelecionarCarpetaGuardar.Size = new System.Drawing.Size(46, 40);
            this.btnSelecionarCarpetaGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelecionarCarpetaGuardar.TabIndex = 54;
            this.btnSelecionarCarpetaGuardar.TabStop = false;
            this.btnSelecionarCarpetaGuardar.Click += new System.EventHandler(this.btnSelecionarCarpetaGuardar_Click);
            this.btnSelecionarCarpetaGuardar.MouseEnter += new System.EventHandler(this.btnSelecionarCarpetaGuardar_MouseEnter);
            this.btnSelecionarCarpetaGuardar.MouseLeave += new System.EventHandler(this.btnSelecionarCarpetaGuardar_MouseLeave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.cerrar1;
            this.btn_cancelar.Location = new System.Drawing.Point(599, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(37, 32);
            this.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // btnFIrmar_PDF
            // 
            this.btnFIrmar_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf;
            this.btnFIrmar_PDF.Location = new System.Drawing.Point(264, 422);
            this.btnFIrmar_PDF.Name = "btnFIrmar_PDF";
            this.btnFIrmar_PDF.Size = new System.Drawing.Size(102, 41);
            this.btnFIrmar_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFIrmar_PDF.TabIndex = 36;
            this.btnFIrmar_PDF.TabStop = false;
            this.btnFIrmar_PDF.Click += new System.EventHandler(this.btnFIrmar_PDF_Click);
            this.btnFIrmar_PDF.MouseEnter += new System.EventHandler(this.btnFIrmar_PDF_MouseEnter);
            this.btnFIrmar_PDF.MouseLeave += new System.EventHandler(this.btnFIrmar_PDF_MouseLeave);
            // 
            // btnBuscar_PDF
            // 
            this.btnBuscar_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_PDF.Location = new System.Drawing.Point(208, 118);
            this.btnBuscar_PDF.Name = "btnBuscar_PDF";
            this.btnBuscar_PDF.Size = new System.Drawing.Size(46, 40);
            this.btnBuscar_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_PDF.TabIndex = 34;
            this.btnBuscar_PDF.TabStop = false;
            this.btnBuscar_PDF.Click += new System.EventHandler(this.btnBuscar_PDF_Click);
            this.btnBuscar_PDF.MouseEnter += new System.EventHandler(this.btnBuscar_PDF_MouseEnter);
            this.btnBuscar_PDF.MouseLeave += new System.EventHandler(this.btnBuscar_PDF_MouseLeave);
            // 
            // FirmarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(642, 479);
            this.Controls.Add(this.txtContraPFX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRutaGuardarPDFirmado);
            this.Controls.Add(this.btnSelecionarCarpetaGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaPDF);
            this.Controls.Add(this.btnFIrmar_PDF);
            this.Controls.Add(this.btnBuscar_PDF);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirmarPDF";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmarPDF";
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarCarpetaGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFIrmar_PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_PDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTxtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRutaPDF;
        private System.Windows.Forms.PictureBox btnFIrmar_PDF;
        private System.Windows.Forms.PictureBox btn_cancelar;
        private System.Windows.Forms.PictureBox btnBuscar_PDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaGuardarPDFirmado;
        private System.Windows.Forms.PictureBox btnSelecionarCarpetaGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox txtContraPFX;
        private System.Windows.Forms.Label label6;
    }
}