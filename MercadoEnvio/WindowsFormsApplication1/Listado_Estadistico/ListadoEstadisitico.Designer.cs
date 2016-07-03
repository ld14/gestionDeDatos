namespace WindowsFormsApplication1.Listado_Estadistico
{
    partial class ListadoEstadisitico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEstadisitico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TrimestreCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reporteSelect = new System.Windows.Forms.ComboBox();
            this.anioSelect = new System.Windows.Forms.ComboBox();
            this.CantEstrellasLabel = new System.Windows.Forms.Label();
            this.labelCantCompras = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupoRubros = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.grupoVisibilidad = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grupoRubros.SuspendLayout();
            this.grupoVisibilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.reporteSelect);
            this.groupBox1.Controls.Add(this.anioSelect);
            this.groupBox1.Controls.Add(this.CantEstrellasLabel);
            this.groupBox1.Controls.Add(this.labelCantCompras);
            this.groupBox1.Location = new System.Drawing.Point(23, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TrimestreCombo);
            this.groupBox3.Location = new System.Drawing.Point(314, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 67);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trimestre Comprendido entre";
            // 
            // TrimestreCombo
            // 
            this.TrimestreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrimestreCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrimestreCombo.FormattingEnabled = true;
            this.TrimestreCombo.Items.AddRange(new object[] {
            "Primer trimestre (enero - marzo)",
            "Segundo trimestre (abril - junio)",
            "Tercer trimestre (julio - septiembre)",
            "Cuarto trimestre (octubre - diciembre)"});
            this.TrimestreCombo.Location = new System.Drawing.Point(22, 29);
            this.TrimestreCombo.Name = "TrimestreCombo";
            this.TrimestreCombo.Size = new System.Drawing.Size(223, 21);
            this.TrimestreCombo.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reporteSelect
            // 
            this.reporteSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reporteSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reporteSelect.FormattingEnabled = true;
            this.reporteSelect.Items.AddRange(new object[] {
            "Vendedores con mayor cantidad de productos no vendidos",
            "Clientes con mayor cantidad de productos comprados",
            "Vendedores con mayor cantidad de facturas",
            "Vendedores con mayor monto facturado"});
            this.reporteSelect.Location = new System.Drawing.Point(83, 115);
            this.reporteSelect.Name = "reporteSelect";
            this.reporteSelect.Size = new System.Drawing.Size(722, 21);
            this.reporteSelect.TabIndex = 10;
            this.reporteSelect.SelectedIndexChanged += new System.EventHandler(this.reporteSelect_SelectedIndexChanged);
            // 
            // anioSelect
            // 
            this.anioSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anioSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anioSelect.FormattingEnabled = true;
            this.anioSelect.Location = new System.Drawing.Point(83, 55);
            this.anioSelect.Name = "anioSelect";
            this.anioSelect.Size = new System.Drawing.Size(206, 21);
            this.anioSelect.TabIndex = 7;
            // 
            // CantEstrellasLabel
            // 
            this.CantEstrellasLabel.AutoSize = true;
            this.CantEstrellasLabel.Location = new System.Drawing.Point(80, 88);
            this.CantEstrellasLabel.Name = "CantEstrellasLabel";
            this.CantEstrellasLabel.Size = new System.Drawing.Size(68, 13);
            this.CantEstrellasLabel.TabIndex = 6;
            this.CantEstrellasLabel.Text = "Tipo de Filtro";
            // 
            // labelCantCompras
            // 
            this.labelCantCompras.AutoSize = true;
            this.labelCantCompras.Location = new System.Drawing.Point(80, 29);
            this.labelCantCompras.Name = "labelCantCompras";
            this.labelCantCompras.Size = new System.Drawing.Size(29, 13);
            this.labelCantCompras.TabIndex = 1;
            this.labelCantCompras.Text = "Año ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(23, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 325);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(949, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(956, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // grupoRubros
            // 
            this.grupoRubros.Controls.Add(this.label9);
            this.grupoRubros.Controls.Add(this.RubroComboBox);
            this.grupoRubros.Location = new System.Drawing.Point(30, 272);
            this.grupoRubros.Name = "grupoRubros";
            this.grupoRubros.Size = new System.Drawing.Size(435, 96);
            this.grupoRubros.TabIndex = 17;
            this.grupoRubros.TabStop = false;
            this.grupoRubros.Text = "Rubros";
            this.grupoRubros.Visible = false;
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
            this.RubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RubroComboBox.FormattingEnabled = true;
            this.RubroComboBox.Location = new System.Drawing.Point(65, 38);
            this.RubroComboBox.Name = "RubroComboBox";
            this.RubroComboBox.Size = new System.Drawing.Size(350, 21);
            this.RubroComboBox.TabIndex = 21;
            // 
            // grupoVisibilidad
            // 
            this.grupoVisibilidad.Controls.Add(this.label12);
            this.grupoVisibilidad.Controls.Add(this.visibilidadComboBox);
            this.grupoVisibilidad.Location = new System.Drawing.Point(502, 272);
            this.grupoVisibilidad.Name = "grupoVisibilidad";
            this.grupoVisibilidad.Size = new System.Drawing.Size(435, 115);
            this.grupoVisibilidad.TabIndex = 18;
            this.grupoVisibilidad.TabStop = false;
            this.grupoVisibilidad.Text = "Visibilidad";
            this.grupoVisibilidad.Visible = false;
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
            this.visibilidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visibilidadComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(65, 38);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(350, 21);
            this.visibilidadComboBox.TabIndex = 21;
            // 
            // ListadoEstadisitico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.grupoVisibilidad);
            this.Controls.Add(this.grupoRubros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoEstadisitico";
            this.Text = "ListadoEstadisitico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListadoEstadisitico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grupoRubros.ResumeLayout(false);
            this.grupoRubros.PerformLayout();
            this.grupoVisibilidad.ResumeLayout(false);
            this.grupoVisibilidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox reporteSelect;
        private System.Windows.Forms.ComboBox anioSelect;
        private System.Windows.Forms.Label CantEstrellasLabel;
        private System.Windows.Forms.Label labelCantCompras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TrimestreCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grupoRubros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RubroComboBox;
        private System.Windows.Forms.GroupBox grupoVisibilidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
    }
}