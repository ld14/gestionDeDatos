﻿namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class BusquedaUsuario
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
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.mailClienteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empresaGroupBox = new System.Windows.Forms.GroupBox();
            this.mailEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cuitTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clienteRadioButton = new System.Windows.Forms.RadioButton();
            this.empresaRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.usuariosEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuarioLst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionesLst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.empresaGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.mailClienteTextBox);
            this.clienteGroupBox.Controls.Add(this.label4);
            this.clienteGroupBox.Controls.Add(this.dniTextBox);
            this.clienteGroupBox.Controls.Add(this.label3);
            this.clienteGroupBox.Controls.Add(this.apellidoTextBox);
            this.clienteGroupBox.Controls.Add(this.label2);
            this.clienteGroupBox.Controls.Add(this.nombreTextBox);
            this.clienteGroupBox.Controls.Add(this.label1);
            this.clienteGroupBox.Location = new System.Drawing.Point(16, 12);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(433, 95);
            this.clienteGroupBox.TabIndex = 8;
            this.clienteGroupBox.TabStop = false;
            // 
            // mailClienteTextBox
            // 
            this.mailClienteTextBox.Location = new System.Drawing.Point(266, 59);
            this.mailClienteTextBox.Name = "mailClienteTextBox";
            this.mailClienteTextBox.Size = new System.Drawing.Size(145, 20);
            this.mailClienteTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(101, 59);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(104, 20);
            this.dniTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nro Documento";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(266, 24);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(145, 20);
            this.apellidoTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(64, 24);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(141, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.clienteGroupBox);
            this.groupBox2.Controls.Add(this.empresaGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 117);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Búsqueda";
            // 
            // empresaGroupBox
            // 
            this.empresaGroupBox.Controls.Add(this.mailEmpresaTextBox);
            this.empresaGroupBox.Controls.Add(this.label5);
            this.empresaGroupBox.Controls.Add(this.cuitTextBox);
            this.empresaGroupBox.Controls.Add(this.label6);
            this.empresaGroupBox.Controls.Add(this.razonSocialTextBox);
            this.empresaGroupBox.Controls.Add(this.label8);
            this.empresaGroupBox.Location = new System.Drawing.Point(16, 12);
            this.empresaGroupBox.Name = "empresaGroupBox";
            this.empresaGroupBox.Size = new System.Drawing.Size(433, 95);
            this.empresaGroupBox.TabIndex = 13;
            this.empresaGroupBox.TabStop = false;
            // 
            // mailEmpresaTextBox
            // 
            this.mailEmpresaTextBox.Location = new System.Drawing.Point(258, 59);
            this.mailEmpresaTextBox.Name = "mailEmpresaTextBox";
            this.mailEmpresaTextBox.Size = new System.Drawing.Size(145, 20);
            this.mailEmpresaTextBox.TabIndex = 11;
            this.mailEmpresaTextBox.TextChanged += new System.EventHandler(this.mailEmpresaTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // cuitTextBox
            // 
            this.cuitTextBox.Location = new System.Drawing.Point(63, 59);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(129, 20);
            this.cuitTextBox.TabIndex = 9;
            this.cuitTextBox.TextChanged += new System.EventHandler(this.cuitTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CUIT";
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.Location = new System.Drawing.Point(118, 24);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(256, 20);
            this.razonSocialTextBox.TabIndex = 5;
            this.razonSocialTextBox.TextChanged += new System.EventHandler(this.razonSocialTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Razón Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clienteRadioButton);
            this.groupBox1.Controls.Add(this.empresaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(466, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // clienteRadioButton
            // 
            this.clienteRadioButton.AutoSize = true;
            this.clienteRadioButton.Location = new System.Drawing.Point(19, 50);
            this.clienteRadioButton.Name = "clienteRadioButton";
            this.clienteRadioButton.Size = new System.Drawing.Size(57, 17);
            this.clienteRadioButton.TabIndex = 2;
            this.clienteRadioButton.Text = "Cliente";
            this.clienteRadioButton.UseVisualStyleBackColor = true;
            this.clienteRadioButton.CheckedChanged += new System.EventHandler(this.clienteRadioButton_CheckedChanged);
            // 
            // empresaRadioButton
            // 
            this.empresaRadioButton.AutoSize = true;
            this.empresaRadioButton.Checked = true;
            this.empresaRadioButton.Location = new System.Drawing.Point(19, 22);
            this.empresaRadioButton.Name = "empresaRadioButton";
            this.empresaRadioButton.Size = new System.Drawing.Size(66, 17);
            this.empresaRadioButton.TabIndex = 1;
            this.empresaRadioButton.TabStop = true;
            this.empresaRadioButton.Text = "Empresa";
            this.empresaRadioButton.UseVisualStyleBackColor = true;
            this.empresaRadioButton.CheckedChanged += new System.EventHandler(this.empresaRadioButton_CheckedChanged);
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
            this.UsuarioLst,
            this.FuncionesLst,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.extraRow});
            this.dataGridView1.DataSource = this.usuariosEmpresaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 163);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usuariosEmpresaBindingSource
            // 
            this.usuariosEmpresaBindingSource.DataSource = typeof(WindowsFormsApplication1.ABM_Usuario.UsuariosEmpresa);
            // 
            // usuariosClienteBindingSource
            // 
            this.usuariosClienteBindingSource.DataSource = typeof(WindowsFormsApplication1.ABM_Usuario.UsuariosCliente);
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
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "razonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "razonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraRow
            // 
            this.extraRow.HeaderText = "extraRow";
            this.extraRow.Name = "extraRow";
            this.extraRow.ReadOnly = true;
            // 
            // BusquedaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BusquedaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaUsuario";
            this.Load += new System.EventHandler(this.BusquedaUsuario_Load);
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.empresaGroupBox.ResumeLayout(false);
            this.empresaGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.TextBox mailClienteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton clienteRadioButton;
        private System.Windows.Forms.RadioButton empresaRadioButton;
        private System.Windows.Forms.GroupBox empresaGroupBox;
        private System.Windows.Forms.TextBox mailEmpresaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cuitTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuariosEmpresaBindingSource;
        private System.Windows.Forms.BindingSource usuariosClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionesLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraRow;
    }
}