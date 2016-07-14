namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class BusquedaVisibilidad
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activoRadioButton = new System.Windows.Forms.RadioButton();
            this.inactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.indistintoRadioButton = new System.Windows.Forms.RadioButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aceptarButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Location = new System.Drawing.Point(37, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 117);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activoRadioButton);
            this.groupBox1.Controls.Add(this.inactivoRadioButton);
            this.groupBox1.Controls.Add(this.indistintoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(353, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
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
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(66, 58);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(154, 20);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisibilidadDataGridViewTextBoxColumn,
            this.codigoVisibilidadDataGridViewTextBoxColumn,
            this.nombreVisibilidadDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.visibilidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 159);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // idVisibilidadDataGridViewTextBoxColumn
            // 
            this.idVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "idVisibilidad";
            this.idVisibilidadDataGridViewTextBoxColumn.HeaderText = "idVisibilidad";
            this.idVisibilidadDataGridViewTextBoxColumn.Name = "idVisibilidadDataGridViewTextBoxColumn";
            this.idVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVisibilidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoVisibilidadDataGridViewTextBoxColumn
            // 
            this.codigoVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "codigoVisibilidad";
            this.codigoVisibilidadDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoVisibilidadDataGridViewTextBoxColumn.Name = "codigoVisibilidadDataGridViewTextBoxColumn";
            this.codigoVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoVisibilidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // nombreVisibilidadDataGridViewTextBoxColumn
            // 
            this.nombreVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "nombreVisibilidad";
            this.nombreVisibilidadDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreVisibilidadDataGridViewTextBoxColumn.Name = "nombreVisibilidadDataGridViewTextBoxColumn";
            this.nombreVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreVisibilidadDataGridViewTextBoxColumn.Width = 140;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 80;
            // 
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "%";
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            this.porcentajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajeDataGridViewTextBoxColumn.Width = 52;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 80;
            // 
            // visibilidadBindingSource
            // 
            this.visibilidadBindingSource.DataSource = typeof(WindowsFormsApplication1.Visibilidad);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(218, 323);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(120, 23);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // BusquedaVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BusquedaVisibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Visibilidades";
            this.Load += new System.EventHandler(this.BusquedaVisibilidad_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton activoRadioButton;
        private System.Windows.Forms.RadioButton inactivoRadioButton;
        private System.Windows.Forms.RadioButton indistintoRadioButton;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource visibilidadBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button aceptarButton;
    }
}