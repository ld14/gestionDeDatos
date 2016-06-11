namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublicacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarOfertarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeCompraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMMenu,
            this.PublicacionMenu,
            this.comprarOfertarMenu,
            this.historialDeCompraMenu,
            this.facturacionToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aBMMenu
            // 
            this.aBMMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolToolStripMenuItem,
            this.rubroToolStripMenuItem,
            this.visibToolStripMenuItem});
            this.aBMMenu.Name = "aBMMenu";
            resources.ApplyResources(this.aBMMenu, "aBMMenu");
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            resources.ApplyResources(this.usuarioToolStripMenuItem, "usuarioToolStripMenuItem");
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            resources.ApplyResources(this.altaToolStripMenuItem, "altaToolStripMenuItem");
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            resources.ApplyResources(this.rolToolStripMenuItem, "rolToolStripMenuItem");
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // rubroToolStripMenuItem
            // 
            this.rubroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1});
            this.rubroToolStripMenuItem.Name = "rubroToolStripMenuItem";
            resources.ApplyResources(this.rubroToolStripMenuItem, "rubroToolStripMenuItem");
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            resources.ApplyResources(this.nuevoToolStripMenuItem1, "nuevoToolStripMenuItem1");
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // visibToolStripMenuItem
            // 
            this.visibToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem});
            this.visibToolStripMenuItem.Name = "visibToolStripMenuItem";
            resources.ApplyResources(this.visibToolStripMenuItem, "visibToolStripMenuItem");
            this.visibToolStripMenuItem.Click += new System.EventHandler(this.visibToolStripMenuItem_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            resources.ApplyResources(this.nuevaToolStripMenuItem, "nuevaToolStripMenuItem");
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // PublicacionMenu
            // 
            this.PublicacionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem1,
            this.modificacionToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.PublicacionMenu.Name = "PublicacionMenu";
            resources.ApplyResources(this.PublicacionMenu, "PublicacionMenu");
            // 
            // nuevaToolStripMenuItem1
            // 
            this.nuevaToolStripMenuItem1.Name = "nuevaToolStripMenuItem1";
            resources.ApplyResources(this.nuevaToolStripMenuItem1, "nuevaToolStripMenuItem1");
            this.nuevaToolStripMenuItem1.Click += new System.EventHandler(this.nuevaToolStripMenuItem1_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            resources.ApplyResources(this.modificacionToolStripMenuItem, "modificacionToolStripMenuItem");
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            resources.ApplyResources(this.buscarToolStripMenuItem, "buscarToolStripMenuItem");
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // comprarOfertarMenu
            // 
            this.comprarOfertarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1});
            this.comprarOfertarMenu.Name = "comprarOfertarMenu";
            resources.ApplyResources(this.comprarOfertarMenu, "comprarOfertarMenu");
            this.comprarOfertarMenu.Click += new System.EventHandler(this.comprarOfertarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            resources.ApplyResources(this.buscarToolStripMenuItem1, "buscarToolStripMenuItem1");
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // historialDeCompraMenu
            // 
            this.historialDeCompraMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem2});
            this.historialDeCompraMenu.Name = "historialDeCompraMenu";
            resources.ApplyResources(this.historialDeCompraMenu, "historialDeCompraMenu");
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            resources.ApplyResources(this.buscarToolStripMenuItem2, "buscarToolStripMenuItem2");
            this.buscarToolStripMenuItem2.Click += new System.EventHandler(this.buscarToolStripMenuItem2_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem3});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            resources.ApplyResources(this.facturacionToolStripMenuItem, "facturacionToolStripMenuItem");
            // 
            // buscarToolStripMenuItem3
            // 
            this.buscarToolStripMenuItem3.Name = "buscarToolStripMenuItem3";
            resources.ApplyResources(this.buscarToolStripMenuItem3, "buscarToolStripMenuItem3");
            this.buscarToolStripMenuItem3.Click += new System.EventHandler(this.buscarToolStripMenuItem3_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            resources.ApplyResources(this.estadisticasToolStripMenuItem, "estadisticasToolStripMenuItem");
            
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublicacionMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarOfertarMenu;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialDeCompraMenu;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;


    }
}

