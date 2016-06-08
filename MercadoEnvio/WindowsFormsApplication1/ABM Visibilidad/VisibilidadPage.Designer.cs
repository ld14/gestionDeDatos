namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class VisibilidadPage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VisibilidadPorcentajeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VisibilidadCostoTxt = new System.Windows.Forms.TextBox();
            this.VisibilidadCodigotxt = new System.Windows.Forms.TextBox();
            this.VisibilidadNombreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(18, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 474);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visibilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VisibilidadPorcentajeTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.VisibilidadCostoTxt);
            this.groupBox3.Controls.Add(this.VisibilidadCodigotxt);
            this.groupBox3.Controls.Add(this.VisibilidadNombreTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 453);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Visibilidad";
            // 
            // VisibilidadPorcentajeTxt
            // 
            this.VisibilidadPorcentajeTxt.Location = new System.Drawing.Point(450, 262);
            this.VisibilidadPorcentajeTxt.MaxLength = 21;
            this.VisibilidadPorcentajeTxt.Name = "VisibilidadPorcentajeTxt";
            this.VisibilidadPorcentajeTxt.Size = new System.Drawing.Size(240, 20);
            this.VisibilidadPorcentajeTxt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Porcentaje";
            // 
            // VisibilidadCostoTxt
            // 
            this.VisibilidadCostoTxt.Location = new System.Drawing.Point(450, 230);
            this.VisibilidadCostoTxt.MaxLength = 21;
            this.VisibilidadCostoTxt.Name = "VisibilidadCostoTxt";
            this.VisibilidadCostoTxt.Size = new System.Drawing.Size(240, 20);
            this.VisibilidadCostoTxt.TabIndex = 18;
            // 
            // VisibilidadCodigotxt
            // 
            this.VisibilidadCodigotxt.Location = new System.Drawing.Point(450, 201);
            this.VisibilidadCodigotxt.MaxLength = 18;
            this.VisibilidadCodigotxt.Name = "VisibilidadCodigotxt";
            this.VisibilidadCodigotxt.Size = new System.Drawing.Size(240, 20);
            this.VisibilidadCodigotxt.TabIndex = 17;
            // 
            // VisibilidadNombreTxt
            // 
            this.VisibilidadNombreTxt.Location = new System.Drawing.Point(450, 171);
            this.VisibilidadNombreTxt.MaxLength = 50;
            this.VisibilidadNombreTxt.Name = "VisibilidadNombreTxt";
            this.VisibilidadNombreTxt.Size = new System.Drawing.Size(240, 20);
            this.VisibilidadNombreTxt.TabIndex = 16;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo Visibilidad";
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
            this.groupBox2.Location = new System.Drawing.Point(18, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // VisibilidadPage
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
            this.Name = "VisibilidadPage";
            this.Text = "VisibilidadPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox VisibilidadPorcentajeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VisibilidadCostoTxt;
        private System.Windows.Forms.TextBox VisibilidadCodigotxt;
        private System.Windows.Forms.TextBox VisibilidadNombreTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}