namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class CompraOfertaPublicacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompraDatos = new System.Windows.Forms.GroupBox();
            this.envioCheck = new System.Windows.Forms.CheckBox();
            this.ofertaLabel = new System.Windows.Forms.Label();
            this.ofertaValue = new System.Windows.Forms.NumericUpDown();
            this.estadoPausa = new System.Windows.Forms.Label();
            this.cant_oferta = new System.Windows.Forms.NumericUpDown();
            this.compraLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vendedorBox = new System.Windows.Forms.TextBox();
            this.tipoPubBox = new System.Windows.Forms.TextBox();
            this.rubroBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigoPubBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.precioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaVencimientoDateTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.preguntarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.CompraDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_oferta)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompraDatos);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(18, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 408);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra Seleccionada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CompraDatos
            // 
            this.CompraDatos.Controls.Add(this.envioCheck);
            this.CompraDatos.Controls.Add(this.ofertaLabel);
            this.CompraDatos.Controls.Add(this.ofertaValue);
            this.CompraDatos.Controls.Add(this.estadoPausa);
            this.CompraDatos.Controls.Add(this.cant_oferta);
            this.CompraDatos.Controls.Add(this.compraLabel);
            this.CompraDatos.Location = new System.Drawing.Point(598, 136);
            this.CompraDatos.Name = "CompraDatos";
            this.CompraDatos.Size = new System.Drawing.Size(379, 255);
            this.CompraDatos.TabIndex = 20;
            this.CompraDatos.TabStop = false;
            this.CompraDatos.Text = "Compra";
            // 
            // envioCheck
            // 
            this.envioCheck.AutoSize = true;
            this.envioCheck.Enabled = false;
            this.envioCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envioCheck.Location = new System.Drawing.Point(118, 191);
            this.envioCheck.Name = "envioCheck";
            this.envioCheck.Size = new System.Drawing.Size(138, 17);
            this.envioCheck.TabIndex = 6;
            this.envioCheck.Text = "Enviar a mi Domicio";
            this.envioCheck.UseVisualStyleBackColor = true;
            // 
            // ofertaLabel
            // 
            this.ofertaLabel.AutoSize = true;
            this.ofertaLabel.Location = new System.Drawing.Point(98, 140);
            this.ofertaLabel.Name = "ofertaLabel";
            this.ofertaLabel.Size = new System.Drawing.Size(39, 13);
            this.ofertaLabel.TabIndex = 5;
            this.ofertaLabel.Text = "Ofertar";
            // 
            // ofertaValue
            // 
            this.ofertaValue.DecimalPlaces = 2;
            this.ofertaValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ofertaValue.Location = new System.Drawing.Point(156, 136);
            this.ofertaValue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ofertaValue.Name = "ofertaValue";
            this.ofertaValue.Size = new System.Drawing.Size(130, 20);
            this.ofertaValue.TabIndex = 4;
            // 
            // estadoPausa
            // 
            this.estadoPausa.AutoSize = true;
            this.estadoPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPausa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.estadoPausa.Location = new System.Drawing.Point(57, 45);
            this.estadoPausa.Name = "estadoPausa";
            this.estadoPausa.Size = new System.Drawing.Size(268, 16);
            this.estadoPausa.TabIndex = 3;
            this.estadoPausa.Text = "La publicación se encuentra Pausada";
            this.estadoPausa.Visible = false;
            // 
            // cant_oferta
            // 
            this.cant_oferta.Location = new System.Drawing.Point(156, 99);
            this.cant_oferta.Name = "cant_oferta";
            this.cant_oferta.Size = new System.Drawing.Size(130, 20);
            this.cant_oferta.TabIndex = 2;
            // 
            // compraLabel
            // 
            this.compraLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compraLabel.Location = new System.Drawing.Point(57, 103);
            this.compraLabel.Name = "compraLabel";
            this.compraLabel.Size = new System.Drawing.Size(80, 13);
            this.compraLabel.TabIndex = 1;
            this.compraLabel.Text = "Mejor Oferta";
            this.compraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.vendedorBox);
            this.groupBox5.Controls.Add(this.tipoPubBox);
            this.groupBox5.Controls.Add(this.rubroBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.codigoPubBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(7, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(970, 89);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vendedor";
            // 
            // vendedorBox
            // 
            this.vendedorBox.Enabled = false;
            this.vendedorBox.Location = new System.Drawing.Point(22, 38);
            this.vendedorBox.Multiline = true;
            this.vendedorBox.Name = "vendedorBox";
            this.vendedorBox.Size = new System.Drawing.Size(190, 21);
            this.vendedorBox.TabIndex = 25;
            // 
            // tipoPubBox
            // 
            this.tipoPubBox.Enabled = false;
            this.tipoPubBox.Location = new System.Drawing.Point(237, 38);
            this.tipoPubBox.Multiline = true;
            this.tipoPubBox.Name = "tipoPubBox";
            this.tipoPubBox.Size = new System.Drawing.Size(224, 21);
            this.tipoPubBox.TabIndex = 24;
            // 
            // rubroBox
            // 
            this.rubroBox.Enabled = false;
            this.rubroBox.Location = new System.Drawing.Point(485, 38);
            this.rubroBox.Multiline = true;
            this.rubroBox.Name = "rubroBox";
            this.rubroBox.Size = new System.Drawing.Size(312, 21);
            this.rubroBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Rubro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Publicación";
            // 
            // codigoPubBox
            // 
            this.codigoPubBox.Enabled = false;
            this.codigoPubBox.Location = new System.Drawing.Point(819, 38);
            this.codigoPubBox.Multiline = true;
            this.codigoPubBox.Name = "codigoPubBox";
            this.codigoPubBox.Size = new System.Drawing.Size(128, 21);
            this.codigoPubBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Código Publicación";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PrecioTxt);
            this.groupBox4.Controls.Add(this.precioLabel);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.fechaVencimientoDateTimeTxt);
            this.groupBox4.Controls.Add(this.stockTxt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.DescripcionTxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(7, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 255);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Publicación";
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(414, 167);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.ReadOnly = true;
            this.PrecioTxt.Size = new System.Drawing.Size(114, 20);
            this.PrecioTxt.TabIndex = 27;
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Location = new System.Drawing.Point(328, 170);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(70, 13);
            this.precioLabel.TabIndex = 26;
            this.precioLabel.Text = "Precio Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha Vencimiento:";
            // 
            // fechaVencimientoDateTimeTxt
            //
            this.fechaVencimientoDateTimeTxt.CustomFormat = "dd/MM/yyyy";
            this.fechaVencimientoDateTimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaVencimientoDateTimeTxt.Enabled = false;
            this.fechaVencimientoDateTimeTxt.Location = new System.Drawing.Point(223, 208);
            this.fechaVencimientoDateTimeTxt.Name = "fechaVencimientoDateTimeTxt";
            this.fechaVencimientoDateTimeTxt.Size = new System.Drawing.Size(247, 20);
            this.fechaVencimientoDateTimeTxt.TabIndex = 24;
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(91, 168);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.ReadOnly = true;
            this.stockTxt.Size = new System.Drawing.Size(114, 20);
            this.stockTxt.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stock:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(15, 42);
            this.DescripcionTxt.MaxLength = 255;
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.ReadOnly = true;
            this.DescripcionTxt.Size = new System.Drawing.Size(540, 102);
            this.DescripcionTxt.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripción";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(267, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Efectuar Operación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preguntarButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(18, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // preguntarButton
            // 
            this.preguntarButton.Enabled = false;
            this.preguntarButton.Location = new System.Drawing.Point(555, 47);
            this.preguntarButton.Name = "preguntarButton";
            this.preguntarButton.Size = new System.Drawing.Size(222, 23);
            this.preguntarButton.TabIndex = 1;
            this.preguntarButton.Text = "Preguntar al Vendedor";
            this.preguntarButton.UseVisualStyleBackColor = true;
            // 
            // CompraOfertaPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraOfertaPublicacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CompraOfertaPublicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompraOfertaPublicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.CompraDatos.ResumeLayout(false);
            this.CompraDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_oferta)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimeTxt;
        private System.Windows.Forms.TextBox codigoPubBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox CompraDatos;
        private System.Windows.Forms.Label compraLabel;
        private System.Windows.Forms.TextBox tipoPubBox;
        private System.Windows.Forms.TextBox rubroBox;
        private System.Windows.Forms.NumericUpDown cant_oferta;
        private System.Windows.Forms.Label ofertaLabel;
        private System.Windows.Forms.NumericUpDown ofertaValue;
        private System.Windows.Forms.Label estadoPausa;
        private System.Windows.Forms.CheckBox envioCheck;
        private System.Windows.Forms.Button preguntarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vendedorBox;
    }
}