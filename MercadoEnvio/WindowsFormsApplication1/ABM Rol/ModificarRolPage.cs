using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class ModificarRolPage : Form
    {
        public ModificarRolPage()
        {
            InitializeComponent();
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Rol> roles = rolDao.obtenerRoles();


            foreach (Rol rol in roles)
            {
                RolesCombobox.Items.Add(rol.nombre);
            }
        }
        public void ModificarRolPage_Load(object sender, EventArgs e)
        {
            
        }

        public void selecciondeRol(object sender, EventArgs e)
        {
            //FuncionalidadesChkLst
            RolDaoImpl rolDao = new RolDaoImpl();
           
            IList<Rol> roles = rolDao.obtenerRoles();

            String nombre = RolesCombobox.SelectedItem.ToString();
            Rol rol = roles.Single(x => x.nombre == nombre);
           
            IList<Funciones> funcPorRol = rolDao.obtenerFuncionesPorRol(rol.idRol);
            //FuncionalidadesCompletas del sistema
             IList<Funciones> func = rolDao.obtenerFunciones();
             FuncionalidadesChkLst.DataSource = func;
             FuncionalidadesChkLst.DisplayMember = "nombre";
             FuncionalidadesChkLst.ValueMember = "idFunciones";
             this.RolActivoChk.Checked = rol.activo;

             for (int d = 0; d < FuncionalidadesChkLst.Items.Count;d++ )
             {
                 FuncionalidadesChkLst.SetItemChecked(d, false);
             }
          
            int i = 0;
            int j = 0;
            foreach  (Funciones fun in func)
            {
                if (fun.nombre == funcPorRol[i].nombre)
                {
                    FuncionalidadesChkLst.SetItemChecked(j, true);
                    i++;
                }
                j++;
                if (i == funcPorRol.Count)
                {
                    break;
                }
            }
        }
    }
    
}
