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
            this.SubastaOpciones = new System.Windows.Forms.GroupBox();
            this.PrecioActualTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ValorOferta = new System.Windows.Forms.TextBox();
            this.CompraDatos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadComprada = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaVencimientoDateTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.CodigoPublicacionTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SubastaOpciones.SuspendLayout();
            this.CompraDatos.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 389);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra Seleccionada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SubastaOpciones
            // 
            this.SubastaOpciones.Controls.Add(this.PrecioActualTxt);
            this.SubastaOpciones.Controls.Add(this.label7);
            this.SubastaOpciones.Controls.Add(this.label12);
            this.SubastaOpciones.Controls.Add(this.ValorOferta);
            this.SubastaOpciones.Location = new System.Drawing.Point(81, 100);
            this.SubastaOpciones.Name = "SubastaOpciones";
            this.SubastaOpciones.Size = new System.Drawing.Size(429, 197);
            this.SubastaOpciones.TabIndex = 19;
            this.SubastaOpciones.TabStop = false;
            this.SubastaOpciones.Text = "Oferta Subasta";
            // 
            // PrecioActualTxt
            // 
            this.PrecioActualTxt.Enabled = false;
            this.PrecioActualTxt.Location = new System.Drawing.Point(143, 20);
            this.PrecioActualTxt.Name = "PrecioActualTxt";
            this.PrecioActualTxt.Size = new System.Drawing.Size(272, 20);
            this.PrecioActualTxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio Actual de Venta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Subasta";
            // 
            // ValorOferta
            // 
            this.ValorOferta.Location = new System.Drawing.Point(144, 60);
            this.ValorOferta.Name = "ValorOferta";
            this.ValorOferta.Size = new System.Drawing.Size(271, 20);
            this.ValorOferta.TabIndex = 4;
            // 
            // CompraDatos
            // 
            this.CompraDatos.Controls.Add(this.label5);
            this.CompraDatos.Controls.Add(this.CantidadComprada);
            this.CompraDatos.Location = new System.Drawing.Point(534, 151);
            this.CompraDatos.Name = "CompraDatos";
            this.CompraDatos.Size = new System.Drawing.Size(435, 189);
            this.CompraDatos.TabIndex = 20;
            this.CompraDatos.TabStop = false;
            this.CompraDatos.Text = "Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad de Productos";
            // 
            // CantidadComprada
            // 
            this.CantidadComprada.FormattingEnabled = true;
            this.CantidadComprada.Location = new System.Drawing.Point(144, 62);
            this.CantidadComprada.Name = "CantidadComprada";
            this.CantidadComprada.Size = new System.Drawing.Size(271, 21);
            this.CantidadComprada.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.RubroComboBox);
            this.groupBox5.Location = new System.Drawing.Point(534, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 96);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rubros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Rubro";
            // 
            // RubroComboBox
            // 
            this.RubroComboBox.FormattingEnabled = true;
            this.RubroComboBox.Location = new System.Drawing.Point(65, 38);
            this.RubroComboBox.Name = "RubroComboBox";
            this.RubroComboBox.Size = new System.Drawing.Size(350, 21);
            this.RubroComboBox.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SubastaOpciones);
            this.groupBox4.Controls.Add(this.PrecioTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.fechaVencimientoDateTimeTxt);
            this.groupBox4.Controls.Add(this.CodigoPublicacionTxt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.stockTxt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.DescripcionTxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(18, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 255);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Publicacion";
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(269, 171);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(114, 20);
            this.PrecioTxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha Vencimiento";
            // 
            // fechaVencimientoDateTimeTxt
            // 
            this.fechaVencimientoDateTimeTxt.Location = new System.Drawing.Point(115, 206);
            this.fechaVencimientoDateTimeTxt.Name = "fechaVencimientoDateTimeTxt";
            this.fechaVencimientoDateTimeTxt.Size = new System.Drawing.Size(377, 20);
            this.fechaVencimientoDateTimeTxt.TabIndex = 24;
            // 
            // CodigoPublicacionTxt
            // 
            this.CodigoPublicacionTxt.Enabled = false;
            this.CodigoPublicacionTxt.Location = new System.Drawing.Point(392, 23);
            this.CodigoPublicacionTxt.Name = "CodigoPublicacionTxt";
            this.CodigoPublicacionTxt.Size = new System.Drawing.Size(100, 20);
            this.CodigoPublicacionTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Codigo Publicacion";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(75, 171);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(114, 20);
            this.stockTxt.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stock";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(8, 58);
            this.DescripcionTxt.MaxLength = 255;
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(484, 102);
            this.DescripcionTxt.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Publicacion";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Efectuar Operacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(18, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // CompraOfertaPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.ControlBox = false;
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
            this.groupBox1.PerformLayout();
            this.SubastaOpciones.ResumeLayout(false);
            this.SubastaOpciones.PerformLayout();
            this.CompraDatos.ResumeLayout(false);
            this.CompraDatos.PerformLayout();
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
        private System.Windows.Forms.ComboBox RubroComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimeTxt;
        private System.Windows.Forms.TextBox CodigoPublicacionTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox SubastaOpciones;
        private System.Windows.Forms.TextBox PrecioActualTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ValorOferta;
        private System.Windows.Forms.GroupBox CompraDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CantidadComprada;
    }
}