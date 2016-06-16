namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class ModificarPublicacionPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.porcentajeValue = new System.Windows.Forms.Label();
            this.costoValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FechaVencimientoDateTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaIncioDateTimeTxt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CodigoPublicacionTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PreguntasCheckBox = new System.Windows.Forms.CheckBox();
            this.EnvioCheckBox = new System.Windows.Forms.CheckBox();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonPublicarP = new System.Windows.Forms.Button();
            this.botonFinalizar = new System.Windows.Forms.Button();
            this.botonPausar = new System.Windows.Forms.Button();
            this.botonPublicarN = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.labelInfoA = new System.Windows.Forms.Label();
            this.labelInfoB = new System.Windows.Forms.Label();
            this.botonPreguntas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Publicación";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.TextChanged += new System.EventHandler(this.tipoPubliChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoBox);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 493);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Publicación";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.porcentajeValue);
            this.groupBox6.Controls.Add(this.costoValue);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.visibilidadComboBox);
            this.groupBox6.Location = new System.Drawing.Point(542, 321);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 115);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Visibilidad";
            // 
            // porcentajeValue
            // 
            this.porcentajeValue.AutoSize = true;
            this.porcentajeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.porcentajeValue.Location = new System.Drawing.Point(357, 80);
            this.porcentajeValue.Name = "porcentajeValue";
            this.porcentajeValue.Size = new System.Drawing.Size(16, 13);
            this.porcentajeValue.TabIndex = 26;
            this.porcentajeValue.Text = "%";
            // 
            // costoValue
            // 
            this.costoValue.AutoSize = true;
            this.costoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.costoValue.Location = new System.Drawing.Point(130, 80);
            this.costoValue.Name = "costoValue";
            this.costoValue.Size = new System.Drawing.Size(14, 13);
            this.costoValue.TabIndex = 25;
            this.costoValue.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(259, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comisión por Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(48, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Costo Visibilidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Visibilidad";
            // 
            // visibilidadComboBox
            // 
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(65, 38);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(350, 21);
            this.visibilidadComboBox.TabIndex = 21;
            this.visibilidadComboBox.SelectedIndexChanged += new System.EventHandler(this.visibilidadChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FechaVencimientoDateTimeTxt);
            this.groupBox4.Controls.Add(this.PrecioTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.FechaIncioDateTimeTxt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.CodigoPublicacionTxt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.PreguntasCheckBox);
            this.groupBox4.Controls.Add(this.EnvioCheckBox);
            this.groupBox4.Controls.Add(this.stockTxt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.DescripcionTxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(18, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 389);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Publicación";
            // 
            // FechaVencimientoDateTimeTxt
            // 
            this.FechaVencimientoDateTimeTxt.CustomFormat = "dd/MM/yyyy";
            this.FechaVencimientoDateTimeTxt.Enabled = false;
            this.FechaVencimientoDateTimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientoDateTimeTxt.Location = new System.Drawing.Point(115, 318);
            this.FechaVencimientoDateTimeTxt.Name = "FechaVencimientoDateTimeTxt";
            this.FechaVencimientoDateTimeTxt.Size = new System.Drawing.Size(350, 20);
            this.FechaVencimientoDateTimeTxt.TabIndex = 28;
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(115, 174);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(114, 20);
            this.PrecioTxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "(Precio)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vence el";
            // 
            // FechaIncioDateTimeTxt
            // 
            this.FechaIncioDateTimeTxt.CustomFormat = "dd/MM/yyyy";
            this.FechaIncioDateTimeTxt.Enabled = false;
            this.FechaIncioDateTimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIncioDateTimeTxt.Location = new System.Drawing.Point(115, 281);
            this.FechaIncioDateTimeTxt.Name = "FechaIncioDateTimeTxt";
            this.FechaIncioDateTimeTxt.Size = new System.Drawing.Size(350, 20);
            this.FechaIncioDateTimeTxt.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha Inicio";
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
            this.label8.Text = "Código Publicación";
            // 
            // PreguntasCheckBox
            // 
            this.PreguntasCheckBox.AutoSize = true;
            this.PreguntasCheckBox.Location = new System.Drawing.Point(380, 214);
            this.PreguntasCheckBox.Name = "PreguntasCheckBox";
            this.PreguntasCheckBox.Size = new System.Drawing.Size(74, 17);
            this.PreguntasCheckBox.TabIndex = 16;
            this.PreguntasCheckBox.Text = "Preguntas";
            this.PreguntasCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnvioCheckBox
            // 
            this.EnvioCheckBox.AutoSize = true;
            this.EnvioCheckBox.Location = new System.Drawing.Point(291, 214);
            this.EnvioCheckBox.Name = "EnvioCheckBox";
            this.EnvioCheckBox.Size = new System.Drawing.Size(56, 17);
            this.EnvioCheckBox.TabIndex = 15;
            this.EnvioCheckBox.Text = "Envio ";
            this.EnvioCheckBox.UseVisualStyleBackColor = true;
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(115, 212);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(97, 20);
            this.stockTxt.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stock (unidades)";
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
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripción";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.RubroComboBox);
            this.groupBox5.Location = new System.Drawing.Point(542, 154);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 96);
            this.groupBox5.TabIndex = 28;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonPublicarP);
            this.groupBox2.Controls.Add(this.botonFinalizar);
            this.groupBox2.Controls.Add(this.botonPausar);
            this.groupBox2.Controls.Add(this.botonPublicarN);
            this.groupBox2.Controls.Add(this.botonGuardar);
            this.groupBox2.Location = new System.Drawing.Point(20, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 113);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // botonPublicarP
            // 
            this.botonPublicarP.Location = new System.Drawing.Point(398, 47);
            this.botonPublicarP.Name = "botonPublicarP";
            this.botonPublicarP.Size = new System.Drawing.Size(222, 23);
            this.botonPublicarP.TabIndex = 4;
            this.botonPublicarP.Text = "Publicar";
            this.botonPublicarP.UseVisualStyleBackColor = true;
            // 
            // botonFinalizar
            // 
            this.botonFinalizar.Location = new System.Drawing.Point(539, 47);
            this.botonFinalizar.Name = "botonFinalizar";
            this.botonFinalizar.Size = new System.Drawing.Size(222, 23);
            this.botonFinalizar.TabIndex = 3;
            this.botonFinalizar.Text = "Finalizar";
            this.botonFinalizar.UseVisualStyleBackColor = true;
            // 
            // botonPausar
            // 
            this.botonPausar.Location = new System.Drawing.Point(250, 47);
            this.botonPausar.Name = "botonPausar";
            this.botonPausar.Size = new System.Drawing.Size(222, 23);
            this.botonPausar.TabIndex = 2;
            this.botonPausar.Text = "Pausar";
            this.botonPausar.UseVisualStyleBackColor = true;
            // 
            // botonPublicarN
            // 
            this.botonPublicarN.Location = new System.Drawing.Point(539, 47);
            this.botonPublicarN.Name = "botonPublicarN";
            this.botonPublicarN.Size = new System.Drawing.Size(222, 23);
            this.botonPublicarN.TabIndex = 1;
            this.botonPublicarN.Text = "Publicar";
            this.botonPublicarN.UseVisualStyleBackColor = true;
            this.botonPublicarN.Click += new System.EventHandler(this.publicar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(250, 47);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(222, 23);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.botonPreguntas);
            this.infoBox.Controls.Add(this.labelInfoB);
            this.infoBox.Controls.Add(this.labelInfoA);
            this.infoBox.Location = new System.Drawing.Point(644, 29);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(242, 100);
            this.infoBox.TabIndex = 30;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Información Básica";
            // 
            // labelInfoA
            // 
            this.labelInfoA.AutoSize = true;
            this.labelInfoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoA.Location = new System.Drawing.Point(19, 26);
            this.labelInfoA.Name = "labelInfoA";
            this.labelInfoA.Size = new System.Drawing.Size(105, 13);
            this.labelInfoA.TabIndex = 0;
            this.labelInfoA.Text = "Unidades Vendidas: ";
            this.labelInfoA.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelInfoB
            // 
            this.labelInfoB.AutoSize = true;
            this.labelInfoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoB.Location = new System.Drawing.Point(19, 26);
            this.labelInfoB.Name = "labelInfoB";
            this.labelInfoB.Size = new System.Drawing.Size(72, 13);
            this.labelInfoB.TabIndex = 1;
            this.labelInfoB.Text = "Oferta Actual:";
            // 
            // botonPreguntas
            // 
            this.botonPreguntas.Location = new System.Drawing.Point(44, 59);
            this.botonPreguntas.Name = "botonPreguntas";
            this.botonPreguntas.Size = new System.Drawing.Size(159, 23);
            this.botonPreguntas.TabIndex = 2;
            this.botonPreguntas.Text = "Preguntas";
            this.botonPreguntas.UseVisualStyleBackColor = true;
            // 
            // ModificarPublicacionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPublicacionPage";
            this.Text = "ModificarPublicacionPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModificarPublicacionPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaIncioDateTimeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodigoPublicacionTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox PreguntasCheckBox;
        private System.Windows.Forms.CheckBox EnvioCheckBox;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonPublicarN;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label porcentajeValue;
        private System.Windows.Forms.Label costoValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RubroComboBox;
        private System.Windows.Forms.Button botonPublicarP;
        private System.Windows.Forms.Button botonFinalizar;
        private System.Windows.Forms.Button botonPausar;
        private System.Windows.Forms.DateTimePicker FechaVencimientoDateTimeTxt;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label labelInfoA;
        private System.Windows.Forms.Label labelInfoB;
        private System.Windows.Forms.Button botonPreguntas;
    }
}