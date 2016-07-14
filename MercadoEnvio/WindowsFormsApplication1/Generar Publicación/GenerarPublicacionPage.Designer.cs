using System;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class GenerarPublicacionPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.estado = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.botonPreguntas = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.Gratis = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.porcentajeValue = new System.Windows.Forms.Label();
            this.costoValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vencimientoBox = new System.Windows.Forms.ComboBox();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaIncioDateTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PreguntasCheckBox = new System.Windows.Forms.CheckBox();
            this.EnvioCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescripcionPublicacionTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoPubliSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxEstado);
            this.groupBox1.Controls.Add(this.infoBox);
            this.groupBox1.Controls.Add(this.Gratis);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TipoPubliSelect);
            this.groupBox1.Location = new System.Drawing.Point(18, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 493);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Publicación";
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.estado);
            this.groupBoxEstado.Location = new System.Drawing.Point(648, 247);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(219, 61);
            this.groupBoxEstado.TabIndex = 33;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Visible = false;
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.Teal;
            this.estado.Location = new System.Drawing.Point(3, 11);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(212, 45);
            this.estado.TabIndex = 32;
            this.estado.Text = "Estado Actual: ";
            this.estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.botonPreguntas);
            this.infoBox.Controls.Add(this.labelInfo);
            this.infoBox.Location = new System.Drawing.Point(637, 25);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(242, 100);
            this.infoBox.TabIndex = 31;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Información Básica";
            this.infoBox.Visible = false;
            // 
            // botonPreguntas
            // 
            this.botonPreguntas.Location = new System.Drawing.Point(43, 59);
            this.botonPreguntas.Name = "botonPreguntas";
            this.botonPreguntas.Size = new System.Drawing.Size(159, 23);
            this.botonPreguntas.TabIndex = 2;
            this.botonPreguntas.Text = "Preguntas";
            this.botonPreguntas.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(19, 26);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "INFO:";
            // 
            // Gratis
            // 
            this.Gratis.AutoSize = true;
            this.Gratis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gratis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Gratis.Location = new System.Drawing.Point(536, 67);
            this.Gratis.Name = "Gratis";
            this.Gratis.Size = new System.Drawing.Size(438, 16);
            this.Gratis.TabIndex = 18;
            this.Gratis.Text = "Usted posee una publicación libre de comisiones por ser usuario nuevo.";
            this.Gratis.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.porcentajeValue);
            this.groupBox6.Controls.Add(this.costoValue);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.visibilidadComboBox);
            this.groupBox6.Location = new System.Drawing.Point(536, 318);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 115);
            this.groupBox6.TabIndex = 17;
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
            this.porcentajeValue.Size = new System.Drawing.Size(23, 13);
            this.porcentajeValue.TabIndex = 26;
            this.porcentajeValue.Text = "0%";
            // 
            // costoValue
            // 
            this.costoValue.AutoSize = true;
            this.costoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.costoValue.Location = new System.Drawing.Point(130, 80);
            this.costoValue.Name = "costoValue";
            this.costoValue.Size = new System.Drawing.Size(21, 13);
            this.costoValue.TabIndex = 25;
            this.costoValue.Text = "$0";
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
            this.label12.Location = new System.Drawing.Point(9, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Visibilidad";
            // 
            // visibilidadComboBox
            // 
            this.visibilidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(68, 38);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(350, 21);
            this.visibilidadComboBox.TabIndex = 21;
            this.visibilidadComboBox.SelectedIndexChanged += new System.EventHandler(this.visibilidad_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.RubroComboBox);
            this.groupBox5.Location = new System.Drawing.Point(536, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 96);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rubros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Rubro";
            // 
            // RubroComboBox
            // 
            this.RubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroComboBox.FormattingEnabled = true;
            this.RubroComboBox.Location = new System.Drawing.Point(65, 38);
            this.RubroComboBox.Name = "RubroComboBox";
            this.RubroComboBox.Size = new System.Drawing.Size(350, 21);
            this.RubroComboBox.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stock);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.vencimientoBox);
            this.groupBox4.Controls.Add(this.PrecioTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.FechaIncioDateTime);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.PreguntasCheckBox);
            this.groupBox4.Controls.Add(this.EnvioCheckBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.DescripcionPublicacionTxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(18, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 389);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Publicación";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(115, 212);
            this.stock.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(97, 20);
            this.stock.TabIndex = 30;
            this.stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(235, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(72, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "*";
            // 
            // vencimientoBox
            // 
            this.vencimientoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vencimientoBox.FormattingEnabled = true;
            this.vencimientoBox.Items.AddRange(new object[] {
            "7 Días",
            "14 Días",
            "21 Días",
            "28 Días"});
            this.vencimientoBox.Location = new System.Drawing.Point(115, 319);
            this.vencimientoBox.Name = "vencimientoBox";
            this.vencimientoBox.Size = new System.Drawing.Size(350, 21);
            this.vencimientoBox.TabIndex = 23;
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
            this.label1.Location = new System.Drawing.Point(10, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vencimiento en";
            // 
            // FechaIncioDateTime
            // 
            this.FechaIncioDateTime.CustomFormat = "dd/MM/yyyy";
            this.FechaIncioDateTime.Enabled = false;
            this.FechaIncioDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIncioDateTime.Location = new System.Drawing.Point(115, 281);
            this.FechaIncioDateTime.Name = "FechaIncioDateTime";
            this.FechaIncioDateTime.Size = new System.Drawing.Size(350, 20);
            this.FechaIncioDateTime.TabIndex = 22;
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
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(392, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stock (unidades)";
            // 
            // DescripcionPublicacionTxt
            // 
            this.DescripcionPublicacionTxt.Location = new System.Drawing.Point(8, 58);
            this.DescripcionPublicacionTxt.MaxLength = 255;
            this.DescripcionPublicacionTxt.Multiline = true;
            this.DescripcionPublicacionTxt.Name = "DescripcionPublicacionTxt";
            this.DescripcionPublicacionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescripcionPublicacionTxt.Size = new System.Drawing.Size(484, 102);
            this.DescripcionPublicacionTxt.TabIndex = 12;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo Publicación";
            // 
            // TipoPubliSelect
            // 
            this.TipoPubliSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPubliSelect.FormattingEnabled = true;
            this.TipoPubliSelect.Items.AddRange(new object[] {
            "Compra Inmediata",
            "Subasta"});
            this.TipoPubliSelect.Location = new System.Drawing.Point(18, 49);
            this.TipoPubliSelect.Name = "TipoPubliSelect";
            this.TipoPubliSelect.Size = new System.Drawing.Size(501, 21);
            this.TipoPubliSelect.TabIndex = 12;
            this.TipoPubliSelect.SelectedIndexChanged += new System.EventHandler(this.tipoPublicacion_SelectedIndexChanged);
            this.TipoPubliSelect.Enter += new System.EventHandler(this.tipoPublicacion_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(18, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Publicar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // GenerarPublicacionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerarPublicacionPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GenerarPublicacionPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenerarPublicacionPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEstado.ResumeLayout(false);
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoPubliSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RubroComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaIncioDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox PreguntasCheckBox;
        private System.Windows.Forms.CheckBox EnvioCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescripcionPublicacionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costoValue;
        private System.Windows.Forms.Label porcentajeValue;
        private System.Windows.Forms.ComboBox vencimientoBox;
        private Label Gratis;
        private Label label6;
        private NumericUpDown stock;
        private Label label13;
        private Label estado;
        private GroupBox infoBox;
        private Button botonPreguntas;
        private Label labelInfo;
        private GroupBox groupBoxEstado;
    }
}