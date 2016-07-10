namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class ModificarVisibilidadPage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.VisibilidadesCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VisibilidadCostoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.porcentajeNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(20, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 474);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visibilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.porcentajeNumeric);
            this.groupBox3.Controls.Add(this.activoCheckBox);
            this.groupBox3.Controls.Add(this.VisibilidadesCombobox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.VisibilidadCostoTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 453);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Visibilidad";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(455, 283);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.activoCheckBox.TabIndex = 23;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // VisibilidadesCombobox
            // 
            this.VisibilidadesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisibilidadesCombobox.FormattingEnabled = true;
            this.VisibilidadesCombobox.Location = new System.Drawing.Point(450, 169);
            this.VisibilidadesCombobox.Name = "VisibilidadesCombobox";
            this.VisibilidadesCombobox.Size = new System.Drawing.Size(240, 21);
            this.VisibilidadesCombobox.TabIndex = 22;
            this.VisibilidadesCombobox.SelectedIndexChanged += new System.EventHandler(this.VisibilidadesCombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Porcentaje";
            // 
            // VisibilidadCostoTxt
            // 
            this.VisibilidadCostoTxt.Location = new System.Drawing.Point(450, 229);
            this.VisibilidadCostoTxt.MaxLength = 21;
            this.VisibilidadCostoTxt.Name = "VisibilidadCostoTxt";
            this.VisibilidadCostoTxt.Size = new System.Drawing.Size(240, 20);
            this.VisibilidadCostoTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Visibilidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(20, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // porcentajeNumeric
            // 
            this.porcentajeNumeric.DecimalPlaces = 1;
            this.porcentajeNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.porcentajeNumeric.Location = new System.Drawing.Point(450, 199);
            this.porcentajeNumeric.Name = "porcentajeNumeric";
            this.porcentajeNumeric.Size = new System.Drawing.Size(240, 20);
            this.porcentajeNumeric.TabIndex = 24;
            // 
            // ModificarVisibilidadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarVisibilidadPage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VisibilidadCostoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox VisibilidadesCombobox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.NumericUpDown porcentajeNumeric;
    }
}