using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class RolUsuarioPage : Form
    {
        public RolUsuarioPage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FuncionalidadesChkLst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RolUsuarioPage_Load(object sender, EventArgs e)
        {
            //FuncionalidadesChkLst
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();

            FuncionalidadesChkLst.DataSource = rubroLts;
            FuncionalidadesChkLst.DisplayMember = "descripcion";
            FuncionalidadesChkLst.ValueMember = "idRubro";            
        }
    }
}
