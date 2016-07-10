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
    public partial class AltaRolUsuarioPage : Form
    {
        public AltaRolUsuarioPage()
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
            
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Rol> roles = rolDao.obtenerRoles();
            bool rolExistente = false;

            foreach (Rol rolA in roles)
            {
                if (rolA.nombre == RolNombreTxt.Text)
                {
                    rolExistente = true;
                    break;
                }
                else {
                    rolExistente = false;
                }
            }

            if (RolNombreTxt.Text == "")
            {
                MessageBox.Show("Se debe ingresar un nombre de rol");
            }
            else
            {
                if (rolExistente)
                {
                    MessageBox.Show("Rol existente, debe ingresar un nombre nuevo");
                }
                else
                {
                    rol.nombre = RolNombreTxt.Text;
                    rol.FuncionesLst = new List<Funciones>();

                    var funciones = FuncionalidadesChkLst.CheckedItems.Cast<Funciones>();
                    foreach (Funciones func in funciones)
                    {
                        rol.FuncionesLst.Add(func);
                    }

                    rolDao.Add(rol);
                    MessageBox.Show("Creacion de Rol exitosa");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolNombreTxt.Text = null;
            RolActivoChk.Checked = false;

            for (int d = 0; d < FuncionalidadesChkLst.Items.Count; d++)
            {
                FuncionalidadesChkLst.SetItemChecked(d, false);
            }
        }

    }
}
