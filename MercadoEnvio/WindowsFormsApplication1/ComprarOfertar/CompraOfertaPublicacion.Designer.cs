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
            this.ComprarOfertar = new System.Windows.Forms.GroupBox();
            this.compraGroupBox = new System.Windows.Forms.GroupBox();
            this.envioCheckBox = new System.Windows.Forms.CheckBox();
            this.ofertaLabel = new System.Windows.Forms.Label();
            this.ofertarNumeric = new System.Windows.Forms.NumericUpDown();
            this.estadoPausadoLabel = new System.Windows.Forms.Label();
            this.cant_ofertaNumeric = new System.Windows.Forms.NumericUpDown();
            this.compraLabel = new System.Windows.Forms.Label();
            this.detallesGroupBox = new System.Windows.Forms.GroupBox();
            this.vendedorLabel = new System.Windows.Forms.Label();
            this.vendedorTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.rubroTextBox = new System.Windows.Forms.TextBox();
            this.rubroLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.infoPublicacionGroupBox = new System.Windows.Forms.GroupBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.precioLabel = new System.Windows.Forms.Label();
            this.vencimientoLabel = new System.Windows.Forms.Label();
            this.vencimientoDateTime = new System.Windows.Forms.DateTimePicker();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.comprarButton = new System.Windows.Forms.Button();
            this.opcionesGroupBox = new System.Windows.Forms.GroupBox();
            this.preguntarButton = new System.Windows.Forms.Button();
            this.ComprarOfertar.SuspendLayout();
            this.compraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofertarNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_ofertaNumeric)).BeginInit();
            this.detallesGroupBox.SuspendLayout();
            this.infoPublicacionGroupBox.SuspendLayout();
            this.opcionesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprarOfertar
            // 
            this.ComprarOfertar.Controls.Add(this.compraGroupBox);
            this.ComprarOfertar.Controls.Add(this.detallesGroupBox);
            this.ComprarOfertar.Controls.Add(this.infoPublicacionGroupBox);
            this.ComprarOfertar.Location = new System.Drawing.Point(18, 48);
            this.ComprarOfertar.Name = "ComprarOfertar";
            this.ComprarOfertar.Size = new System.Drawing.Size(984, 408);
            this.ComprarOfertar.TabIndex = 6;
            this.ComprarOfertar.TabStop = false;
            this.ComprarOfertar.Text = "Comprar/Ofertar Publicación";
            // 
            // compraGroupBox
            // 
            this.compraGroupBox.Controls.Add(this.envioCheckBox);
            this.compraGroupBox.Controls.Add(this.ofertaLabel);
            this.compraGroupBox.Controls.Add(this.ofertarNumeric);
            this.compraGroupBox.Controls.Add(this.estadoPausadoLabel);
            this.compraGroupBox.Controls.Add(this.cant_ofertaNumeric);
            this.compraGroupBox.Controls.Add(this.compraLabel);
            this.compraGroupBox.Location = new System.Drawing.Point(598, 136);
            this.compraGroupBox.Name = "compraGroupBox";
            this.compraGroupBox.Size = new System.Drawing.Size(379, 255);
            this.compraGroupBox.TabIndex = 20;
            this.compraGroupBox.TabStop = false;
            this.compraGroupBox.Text = "Compra";
            // 
            // envioCheckBox
            // 
            this.envioCheckBox.AutoSize = true;
            this.envioCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envioCheckBox.Location = new System.Drawing.Point(118, 191);
            this.envioCheckBox.Name = "envioCheckBox";
            this.envioCheckBox.Size = new System.Drawing.Size(138, 17);
            this.envioCheckBox.TabIndex = 6;
            this.envioCheckBox.Text = "Enviar a mi Domicio";
            this.envioCheckBox.UseVisualStyleBackColor = true;
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
            // ofertarNumeric
            // 
            this.ofertarNumeric.DecimalPlaces = 2;
            this.ofertarNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ofertarNumeric.Location = new System.Drawing.Point(156, 136);
            this.ofertarNumeric.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ofertarNumeric.Name = "ofertarNumeric";
            this.ofertarNumeric.Size = new System.Drawing.Size(130, 20);
            this.ofertarNumeric.TabIndex = 4;
            // 
            // estadoPausadoLabel
            // 
            this.estadoPausadoLabel.AutoSize = true;
            this.estadoPausadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPausadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.estadoPausadoLabel.Location = new System.Drawing.Point(57, 45);
            this.estadoPausadoLabel.Name = "estadoPausadoLabel";
            this.estadoPausadoLabel.Size = new System.Drawing.Size(268, 16);
            this.estadoPausadoLabel.TabIndex = 3;
            this.estadoPausadoLabel.Text = "La publicación se encuentra Pausada";
            this.estadoPausadoLabel.Visible = false;
            // 
            // cant_ofertaNumeric
            // 
            this.cant_ofertaNumeric.DecimalPlaces = 2;
            this.cant_ofertaNumeric.Location = new System.Drawing.Point(156, 99);
            this.cant_ofertaNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.cant_ofertaNumeric.Name = "cant_ofertaNumeric";
            this.cant_ofertaNumeric.Size = new System.Drawing.Size(130, 20);
            this.cant_ofertaNumeric.TabIndex = 2;
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
            // detallesGroupBox
            // 
            this.detallesGroupBox.Controls.Add(this.vendedorLabel);
            this.detallesGroupBox.Controls.Add(this.vendedorTextBox);
            this.detallesGroupBox.Controls.Add(this.tipoTextBox);
            this.detallesGroupBox.Controls.Add(this.rubroTextBox);
            this.detallesGroupBox.Controls.Add(this.rubroLabel);
            this.detallesGroupBox.Controls.Add(this.tipoLabel);
            this.detallesGroupBox.Controls.Add(this.codigoTextBox);
            this.detallesGroupBox.Controls.Add(this.codigoLabel);
            this.detallesGroupBox.Location = new System.Drawing.Point(7, 21);
            this.detallesGroupBox.Name = "detallesGroupBox";
            this.detallesGroupBox.Size = new System.Drawing.Size(970, 89);
            this.detallesGroupBox.TabIndex = 16;
            this.detallesGroupBox.TabStop = false;
            this.detallesGroupBox.Text = "Detalles";
            // 
            // vendedorLabel
            // 
            this.vendedorLabel.AutoSize = true;
            this.vendedorLabel.Location = new System.Drawing.Point(19, 22);
            this.vendedorLabel.Name = "vendedorLabel";
            this.vendedorLabel.Size = new System.Drawing.Size(53, 13);
            this.vendedorLabel.TabIndex = 26;
            this.vendedorLabel.Text = "Vendedor";
            // 
            // vendedorTextBox
            // 
            this.vendedorTextBox.Enabled = false;
            this.vendedorTextBox.Location = new System.Drawing.Point(22, 38);
            this.vendedorTextBox.Multiline = true;
            this.vendedorTextBox.Name = "vendedorTextBox";
            this.vendedorTextBox.Size = new System.Drawing.Size(190, 21);
            this.vendedorTextBox.TabIndex = 25;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Location = new System.Drawing.Point(237, 38);
            this.tipoTextBox.Multiline = true;
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(224, 21);
            this.tipoTextBox.TabIndex = 24;
            // 
            // rubroTextBox
            // 
            this.rubroTextBox.Enabled = false;
            this.rubroTextBox.Location = new System.Drawing.Point(485, 38);
            this.rubroTextBox.Multiline = true;
            this.rubroTextBox.Name = "rubroTextBox";
            this.rubroTextBox.Size = new System.Drawing.Size(312, 21);
            this.rubroTextBox.TabIndex = 23;
            // 
            // rubroLabel
            // 
            this.rubroLabel.AutoSize = true;
            this.rubroLabel.Location = new System.Drawing.Point(482, 22);
            this.rubroLabel.Name = "rubroLabel";
            this.rubroLabel.Size = new System.Drawing.Size(36, 13);
            this.rubroLabel.TabIndex = 22;
            this.rubroLabel.Text = "Rubro";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(234, 22);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(86, 13);
            this.tipoLabel.TabIndex = 13;
            this.tipoLabel.Text = "Tipo Publicación";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(819, 38);
            this.codigoTextBox.Multiline = true;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(128, 21);
            this.codigoTextBox.TabIndex = 20;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(816, 22);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(98, 13);
            this.codigoLabel.TabIndex = 19;
            this.codigoLabel.Text = "Código Publicación";
            // 
            // infoPublicacionGroupBox
            // 
            this.infoPublicacionGroupBox.Controls.Add(this.precioTextBox);
            this.infoPublicacionGroupBox.Controls.Add(this.precioLabel);
            this.infoPublicacionGroupBox.Controls.Add(this.vencimientoLabel);
            this.infoPublicacionGroupBox.Controls.Add(this.vencimientoDateTime);
            this.infoPublicacionGroupBox.Controls.Add(this.stockTextBox);
            this.infoPublicacionGroupBox.Controls.Add(this.stockLabel);
            this.infoPublicacionGroupBox.Controls.Add(this.descripcionTextBox);
            this.infoPublicacionGroupBox.Controls.Add(this.descripcionLabel);
            this.infoPublicacionGroupBox.Location = new System.Drawing.Point(7, 136);
            this.infoPublicacionGroupBox.Name = "infoPublicacionGroupBox";
            this.infoPublicacionGroupBox.Size = new System.Drawing.Size(572, 255);
            this.infoPublicacionGroupBox.TabIndex = 14;
            this.infoPublicacionGroupBox.TabStop = false;
            this.infoPublicacionGroupBox.Text = "Datos Publicación";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(414, 167);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(114, 20);
            this.precioTextBox.TabIndex = 27;
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
            // vencimientoLabel
            // 
            this.vencimientoLabel.AutoSize = true;
            this.vencimientoLabel.Location = new System.Drawing.Point(110, 211);
            this.vencimientoLabel.Name = "vencimientoLabel";
            this.vencimientoLabel.Size = new System.Drawing.Size(101, 13);
            this.vencimientoLabel.TabIndex = 25;
            this.vencimientoLabel.Text = "Fecha Vencimiento:";
            // 
            // vencimientoDateTime
            // 
            this.vencimientoDateTime.CustomFormat = "dd/MM/yyyy";
            this.vencimientoDateTime.Enabled = false;
            this.vencimientoDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vencimientoDateTime.Location = new System.Drawing.Point(223, 208);
            this.vencimientoDateTime.Name = "vencimientoDateTime";
            this.vencimientoDateTime.Size = new System.Drawing.Size(247, 20);
            this.vencimientoDateTime.TabIndex = 24;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(91, 168);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(114, 20);
            this.stockTextBox.TabIndex = 14;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(42, 171);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(38, 13);
            this.stockLabel.TabIndex = 13;
            this.stockLabel.Text = "Stock:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(15, 42);
            this.descripcionTextBox.MaxLength = 255;
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(540, 102);
            this.descripcionTextBox.TabIndex = 12;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(16, 26);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 11;
            this.descripcionLabel.Text = "Descripción";
            // 
            // comprarButton
            // 
            this.comprarButton.Location = new System.Drawing.Point(256, 47);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(222, 23);
            this.comprarButton.TabIndex = 0;
            this.comprarButton.Text = "Efectuar Operación";
            this.comprarButton.UseVisualStyleBackColor = true;
            this.comprarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcionesGroupBox
            // 
            this.opcionesGroupBox.Controls.Add(this.preguntarButton);
            this.opcionesGroupBox.Controls.Add(this.comprarButton);
            this.opcionesGroupBox.Location = new System.Drawing.Point(18, 472);
            this.opcionesGroupBox.Name = "opcionesGroupBox";
            this.opcionesGroupBox.Size = new System.Drawing.Size(984, 113);
            this.opcionesGroupBox.TabIndex = 7;
            this.opcionesGroupBox.TabStop = false;
            // 
            // preguntarButton
            // 
            this.preguntarButton.Location = new System.Drawing.Point(549, 47);
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
            this.Controls.Add(this.ComprarOfertar);
            this.Controls.Add(this.opcionesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraOfertaPublicacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CompraOfertaPublicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompraOfertaPublicacion_Load);
            this.ComprarOfertar.ResumeLayout(false);
            this.compraGroupBox.ResumeLayout(false);
            this.compraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofertarNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_ofertaNumeric)).EndInit();
            this.detallesGroupBox.ResumeLayout(false);
            this.detallesGroupBox.PerformLayout();
            this.infoPublicacionGroupBox.ResumeLayout(false);
            this.infoPublicacionGroupBox.PerformLayout();
            this.opcionesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComprarOfertar;
        private System.Windows.Forms.GroupBox detallesGroupBox;
        private System.Windows.Forms.Label rubroLabel;
        private System.Windows.Forms.GroupBox infoPublicacionGroupBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label vencimientoLabel;
        private System.Windows.Forms.DateTimePicker vencimientoDateTime;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.GroupBox opcionesGroupBox;
        private System.Windows.Forms.GroupBox compraGroupBox;
        private System.Windows.Forms.Label compraLabel;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox rubroTextBox;
        private System.Windows.Forms.NumericUpDown cant_ofertaNumeric;
        private System.Windows.Forms.Label ofertaLabel;
        private System.Windows.Forms.NumericUpDown ofertarNumeric;
        private System.Windows.Forms.Label estadoPausadoLabel;
        private System.Windows.Forms.CheckBox envioCheckBox;
        private System.Windows.Forms.Button preguntarButton;
        private System.Windows.Forms.Label vendedorLabel;
        private System.Windows.Forms.TextBox vendedorTextBox;
    }
}