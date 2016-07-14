namespace WindowsFormsApplication1.ABM_Rol
{
    partial class BusquedaRol
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UsuarioLst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionesLst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indistintoRadioButton = new System.Windows.Forms.RadioButton();
            this.activoRadioButton = new System.Windows.Forms.RadioButton();
            this.inactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRolDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.UsuarioLst,
            this.FuncionesLst});
            this.dataGridView1.DataSource = this.rolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 145);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // idRolDataGridViewTextBoxColumn
            // 
            this.idRolDataGridViewTextBoxColumn.DataPropertyName = "idRol";
            this.idRolDataGridViewTextBoxColumn.HeaderText = "ID Rol";
            this.idRolDataGridViewTextBoxColumn.Name = "idRolDataGridViewTextBoxColumn";
            this.idRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idRolDataGridViewTextBoxColumn.Width = 60;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.Width = 140;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activoDataGridViewCheckBoxColumn.Width = 70;
            // 
            // UsuarioLst
            // 
            this.UsuarioLst.DataPropertyName = "UsuarioLst";
            this.UsuarioLst.HeaderText = "UsuarioLst";
            this.UsuarioLst.Name = "UsuarioLst";
            this.UsuarioLst.ReadOnly = true;
            this.UsuarioLst.Visible = false;
            // 
            // FuncionesLst
            // 
            this.FuncionesLst.DataPropertyName = "FuncionesLst";
            this.FuncionesLst.HeaderText = "FuncionesLst";
            this.FuncionesLst.Name = "FuncionesLst";
            this.FuncionesLst.ReadOnly = true;
            this.FuncionesLst.Visible = false;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(WindowsFormsApplication1.Rol);
            // 
            // indistintoRadioButton
            // 
            this.indistintoRadioButton.AutoSize = true;
            this.indistintoRadioButton.Checked = true;
            this.indistintoRadioButton.Location = new System.Drawing.Point(19, 18);
            this.indistintoRadioButton.Name = "indistintoRadioButton";
            this.indistintoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.indistintoRadioButton.TabIndex = 1;
            this.indistintoRadioButton.TabStop = true;
            this.indistintoRadioButton.Text = "Indistinto";
            this.indistintoRadioButton.UseVisualStyleBackColor = true;
            this.indistintoRadioButton.CheckedChanged += new System.EventHandler(this.indistintoRadioButton_CheckedChanged);
            // 
            // activoRadioButton
            // 
            this.activoRadioButton.AutoSize = true;
            this.activoRadioButton.Location = new System.Drawing.Point(19, 41);
            this.activoRadioButton.Name = "activoRadioButton";
            this.activoRadioButton.Size = new System.Drawing.Size(55, 17);
            this.activoRadioButton.TabIndex = 2;
            this.activoRadioButton.Text = "Activo";
            this.activoRadioButton.UseVisualStyleBackColor = true;
            this.activoRadioButton.CheckedChanged += new System.EventHandler(this.activoRadioButton_CheckedChanged);
            // 
            // inactivoRadioButton
            // 
            this.inactivoRadioButton.AutoSize = true;
            this.inactivoRadioButton.Location = new System.Drawing.Point(19, 64);
            this.inactivoRadioButton.Name = "inactivoRadioButton";
            this.inactivoRadioButton.Size = new System.Drawing.Size(63, 17);
            this.inactivoRadioButton.TabIndex = 3;
            this.inactivoRadioButton.Text = "Inactivo";
            this.inactivoRadioButton.UseVisualStyleBackColor = true;
            this.inactivoRadioButton.CheckedChanged += new System.EventHandler(this.inactivoRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activoRadioButton);
            this.groupBox1.Controls.Add(this.inactivoRadioButton);
            this.groupBox1.Controls.Add(this.indistintoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(34, 57);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(154, 20);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Búsqueda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // BusquedaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BusquedaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Roles";
            this.Load += new System.EventHandler(this.BusquedaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionesLst;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.RadioButton indistintoRadioButton;
        private System.Windows.Forms.RadioButton activoRadioButton;
        private System.Windows.Forms.RadioButton inactivoRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}