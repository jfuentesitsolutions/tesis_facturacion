﻿namespace control_principal.ModulosFacturaElectronica
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
            this.btnFIrmar_PDF = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.btnBuscar_PDF = new System.Windows.Forms.PictureBox();
            this.pnlTxtTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFIrmar_PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_PDF)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(305, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 57);
            this.label4.TabIndex = 27;
            this.label4.Text = "Firmar PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ruta:";
            // 
            // lblRutaPDF
            // 
            this.lblRutaPDF.Enabled = false;
            this.lblRutaPDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaPDF.Location = new System.Drawing.Point(205, 238);
            this.lblRutaPDF.Margin = new System.Windows.Forms.Padding(4);
            this.lblRutaPDF.Multiline = true;
            this.lblRutaPDF.Name = "lblRutaPDF";
            this.lblRutaPDF.Size = new System.Drawing.Size(519, 131);
            this.lblRutaPDF.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecione PDF :";
            // 
            // btnFIrmar_PDF
            // 
            this.btnFIrmar_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFIrmar_PDF.Image = global::control_principal.Properties.Resources.firmarpdf;
            this.btnFIrmar_PDF.Location = new System.Drawing.Point(352, 464);
            this.btnFIrmar_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnFIrmar_PDF.Name = "btnFIrmar_PDF";
            this.btnFIrmar_PDF.Size = new System.Drawing.Size(175, 71);
            this.btnFIrmar_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFIrmar_PDF.TabIndex = 36;
            this.btnFIrmar_PDF.TabStop = false;
            this.btnFIrmar_PDF.Click += new System.EventHandler(this.btnFIrmar_PDF_Click);
            this.btnFIrmar_PDF.MouseEnter += new System.EventHandler(this.btnFIrmar_PDF_MouseEnter);
            this.btnFIrmar_PDF.MouseLeave += new System.EventHandler(this.btnFIrmar_PDF_MouseLeave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Image = global::control_principal.Properties.Resources.return2;
            this.btn_cancelar.Location = new System.Drawing.Point(991, 545);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(63, 57);
            this.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // btnBuscar_PDF
            // 
            this.btnBuscar_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_PDF.Image = global::control_principal.Properties.Resources.folder2;
            this.btnBuscar_PDF.Location = new System.Drawing.Point(541, 159);
            this.btnBuscar_PDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_PDF.Name = "btnBuscar_PDF";
            this.btnBuscar_PDF.Size = new System.Drawing.Size(61, 49);
            this.btnBuscar_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_PDF.TabIndex = 34;
            this.btnBuscar_PDF.TabStop = false;
            this.btnBuscar_PDF.Click += new System.EventHandler(this.btnBuscar_PDF_Click);
            this.btnBuscar_PDF.MouseEnter += new System.EventHandler(this.btnBuscar_PDF_MouseEnter);
            this.btnBuscar_PDF.MouseLeave += new System.EventHandler(this.btnBuscar_PDF_MouseLeave);
            // 
            // FirmarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.pnlTxtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaPDF);
            this.Controls.Add(this.btnFIrmar_PDF);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnBuscar_PDF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirmarPDF";
            this.Text = "FirmarPDF";
            this.Load += new System.EventHandler(this.FirmarPDF_Load);
            this.pnlTxtTitulo.ResumeLayout(false);
            this.pnlTxtTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFIrmar_PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
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
    }
}