using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

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
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Funciones> func = rolDao.obtenerFunciones();

            FuncionalidadesChkLst.DataSource = func;
            FuncionalidadesChkLst.DisplayMember = "nombre";
            FuncionalidadesChkLst.ValueMember = "idFunciones";            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.activo = RolActivoChk.Checked;
            rol.nombre = RolNombreTxt.Text;
            rol.FuncionesLst = new List<Funciones>();

            var funciones = FuncionalidadesChkLst.CheckedItems.Cast<Funciones>();
            foreach (Funciones func in funciones)
            {
                rol.FuncionesLst.Add(func);
            }

            RolDaoImpl rolDao = new RolDaoImpl();
            rolDao.Add(rol);
        }
    }
}
