namespace WindowsFormsApplication1.ABM_Rol
{
    partial class AltaRolUsuarioPage
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
            this.crearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FuncionalidadesChkLst = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idRolTextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.RolActivoChk = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modificarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(236, 37);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(222, 23);
            this.crearButton.TabIndex = 0;
            this.crearButton.Text = "Crear";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(20, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM Rol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FuncionalidadesChkLst);
            this.groupBox4.Location = new System.Drawing.Point(396, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 431);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionalidades";
            // 
            // FuncionalidadesChkLst
            // 
            this.FuncionalidadesChkLst.FormattingEnabled = true;
            this.FuncionalidadesChkLst.Items.AddRange(new object[] {
            "ABMs",
            "Publicacion",
            "Compra/Oferta",
            "Historial Compra",
            "Facturacion",
            "Estadisticas",
            "Mostrar Mis Datos",
            "Calificar"});
            this.FuncionalidadesChkLst.Location = new System.Drawing.Point(13, 21);
            this.FuncionalidadesChkLst.Name = "FuncionalidadesChkLst";
            this.FuncionalidadesChkLst.Size = new System.Drawing.Size(560, 394);
            this.FuncionalidadesChkLst.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.limpiarButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.idRolTextBox);
            this.groupBox3.Controls.Add(this.buscarButton);
            this.groupBox3.Controls.Add(this.RolActivoChk);
            this.groupBox3.Controls.Add(this.nombreTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(9, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 431);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rol";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(80, 368);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(222, 23);
            this.limpiarButton.TabIndex = 1;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Rol";
            // 
            // idRolTextBox
            // 
            this.idRolTextBox.Enabled = false;
            this.idRolTextBox.Location = new System.Drawing.Point(81, 49);
            this.idRolTextBox.Name = "idRolTextBox";
            this.idRolTextBox.Size = new System.Drawing.Size(86, 20);
            this.idRolTextBox.TabIndex = 8;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(282, 100);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 7;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscar_Click);
            // 
            // RolActivoChk
            // 
            this.RolActivoChk.AutoSize = true;
            this.RolActivoChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolActivoChk.Location = new System.Drawing.Point(239, 49);
            this.RolActivoChk.Name = "RolActivoChk";
            this.RolActivoChk.Size = new System.Drawing.Size(65, 21);
            this.RolActivoChk.TabIndex = 6;
            this.RolActivoChk.Text = "Activo";
            this.RolActivoChk.UseVisualStyleBackColor = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(81, 102);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(181, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modificarButton);
            this.groupBox2.Controls.Add(this.crearButton);
            this.groupBox2.Location = new System.Drawing.Point(20, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // modificarButton
            // 
            this.modificarButton.Enabled = false;
            this.modificarButton.Location = new System.Drawing.Point(519, 37);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(222, 23);
            this.modificarButton.TabIndex = 1;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // AltaRolUsuarioPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRolUsuarioPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RolUsuarioPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RolUsuarioPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox FuncionalidadesChkLst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox RolActivoChk;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idRolTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button modificarButton;
    }
}