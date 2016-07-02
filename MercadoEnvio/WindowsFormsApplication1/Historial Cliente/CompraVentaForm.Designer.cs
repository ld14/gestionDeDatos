namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class CompraVentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraVentaForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subastaL = new System.Windows.Forms.Label();
            this.compraL = new System.Windows.Forms.Label();
            this.splitCompra = new System.Windows.Forms.Splitter();
            this.splitSubasta = new System.Windows.Forms.Splitter();
            this.compSinCalificar = new System.Windows.Forms.Label();
            this.compEfectuadas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subGanadas = new System.Windows.Forms.Label();
            this.subParticipadas = new System.Windows.Forms.Label();
            this.montoTotal = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.estrellasDadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(221, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Location = new System.Drawing.Point(26, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 338);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subastaL);
            this.panel1.Controls.Add(this.compraL);
            this.panel1.Controls.Add(this.splitCompra);
            this.panel1.Controls.Add(this.splitSubasta);
            this.panel1.Location = new System.Drawing.Point(788, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 38);
            this.panel1.TabIndex = 4;
            // 
            // subastaL
            // 
            this.subastaL.AutoSize = true;
            this.subastaL.Location = new System.Drawing.Point(4, 10);
            this.subastaL.Name = "subastaL";
            this.subastaL.Size = new System.Drawing.Size(65, 16);
            this.subastaL.TabIndex = 3;
            this.subastaL.Text = "Subastas";
            this.subastaL.Click += new System.EventHandler(this.subastaClick);
            // 
            // compraL
            // 
            this.compraL.AutoSize = true;
            this.compraL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraL.Location = new System.Drawing.Point(109, 10);
            this.compraL.Name = "compraL";
            this.compraL.Size = new System.Drawing.Size(63, 16);
            this.compraL.TabIndex = 2;
            this.compraL.Text = "Compras";
            this.compraL.Click += new System.EventHandler(this.compraClick);
            // 
            // splitCompra
            // 
            this.splitCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCompra.Enabled = false;
            this.splitCompra.Location = new System.Drawing.Point(88, 0);
            this.splitCompra.Name = "splitCompra";
            this.splitCompra.Size = new System.Drawing.Size(88, 36);
            this.splitCompra.TabIndex = 4;
            this.splitCompra.TabStop = false;
            // 
            // splitSubasta
            // 
            this.splitSubasta.Enabled = false;
            this.splitSubasta.Location = new System.Drawing.Point(0, 0);
            this.splitSubasta.Name = "splitSubasta";
            this.splitSubasta.Size = new System.Drawing.Size(88, 36);
            this.splitSubasta.TabIndex = 5;
            this.splitSubasta.TabStop = false;
            // 
            // compSinCalificar
            // 
            this.compSinCalificar.AutoSize = true;
            this.compSinCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compSinCalificar.Location = new System.Drawing.Point(695, 158);
            this.compSinCalificar.Name = "compSinCalificar";
            this.compSinCalificar.Size = new System.Drawing.Size(138, 16);
            this.compSinCalificar.TabIndex = 3;
            this.compSinCalificar.Text = "Compras sin calificar: ";
            // 
            // compEfectuadas
            // 
            this.compEfectuadas.AutoSize = true;
            this.compEfectuadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compEfectuadas.Location = new System.Drawing.Point(695, 126);
            this.compEfectuadas.Name = "compEfectuadas";
            this.compEfectuadas.Size = new System.Drawing.Size(139, 16);
            this.compEfectuadas.TabIndex = 1;
            this.compEfectuadas.Text = "Compras efectuadas: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subGanadas);
            this.groupBox1.Controls.Add(this.subParticipadas);
            this.groupBox1.Controls.Add(this.montoTotal);
            this.groupBox1.Controls.Add(this.nombreUsuario);
            this.groupBox1.Controls.Add(this.estrellasDadas);
            this.groupBox1.Controls.Add(this.compSinCalificar);
            this.groupBox1.Controls.Add(this.compEfectuadas);
            this.groupBox1.Location = new System.Drawing.Point(26, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de Compras y Estadisticas";
            // 
            // subGanadas
            // 
            this.subGanadas.AutoSize = true;
            this.subGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGanadas.Location = new System.Drawing.Point(695, 72);
            this.subGanadas.Name = "subGanadas";
            this.subGanadas.Size = new System.Drawing.Size(128, 16);
            this.subGanadas.TabIndex = 14;
            this.subGanadas.Text = "Subastas ganadas: ";
            // 
            // subParticipadas
            // 
            this.subParticipadas.AutoSize = true;
            this.subParticipadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subParticipadas.Location = new System.Drawing.Point(695, 39);
            this.subParticipadas.Name = "subParticipadas";
            this.subParticipadas.Size = new System.Drawing.Size(149, 16);
            this.subParticipadas.TabIndex = 13;
            this.subParticipadas.Text = "Subastas participadas: ";
            // 
            // montoTotal
            // 
            this.montoTotal.AutoSize = true;
            this.montoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotal.Location = new System.Drawing.Point(99, 145);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Size = new System.Drawing.Size(174, 16);
            this.montoTotal.TabIndex = 12;
            this.montoTotal.Text = "Monto total comprado: $";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Location = new System.Drawing.Point(47, 51);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            this.nombreUsuario.Size = new System.Drawing.Size(448, 21);
            this.nombreUsuario.TabIndex = 11;
            this.nombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estrellasDadas
            // 
            this.estrellasDadas.AutoSize = true;
            this.estrellasDadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estrellasDadas.Location = new System.Drawing.Point(99, 107);
            this.estrellasDadas.Name = "estrellasDadas";
            this.estrellasDadas.Size = new System.Drawing.Size(125, 16);
            this.estrellasDadas.TabIndex = 6;
            this.estrellasDadas.Text = "Estrellas dadas: ";
            // 
            // CompraVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraVentaForm";
            this.Text = "CompraVentaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompraVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label compSinCalificar;
        private System.Windows.Forms.Label compEfectuadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Label estrellasDadas;
        private System.Windows.Forms.Label subGanadas;
        private System.Windows.Forms.Label subParticipadas;
        private System.Windows.Forms.Label montoTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label subastaL;
        private System.Windows.Forms.Splitter splitCompra;
        private System.Windows.Forms.Label compraL;
        private System.Windows.Forms.Splitter splitSubasta;
    }
}