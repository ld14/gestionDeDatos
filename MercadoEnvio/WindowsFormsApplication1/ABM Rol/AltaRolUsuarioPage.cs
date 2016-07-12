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

        public IList<Funciones> func = new List<Funciones>();

        private void RolUsuarioPage_Load(object sender, EventArgs e)
        {
            //FuncionalidadesChkLst
            RolDaoImpl rolDao = new RolDaoImpl();
            func = rolDao.obtenerFunciones();

            FuncionalidadesChkLst.DataSource = func;
            FuncionalidadesChkLst.DisplayMember = "nombre";
            FuncionalidadesChkLst.ValueMember = "idFunciones";            
        }

        private void crear_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("Se debe ingresar un nombre de rol");
                return;
            }
            // Validar que tenga almenos una funcion seleccionada
            // Preguntar por activo

            Rol rol = new Rol();
            rol.nombre = nombreTextBox.Text;
            rol.activo = RolActivoChk.Checked;
            rol.UsuarioLst = new List<Usuario>();
            rol.FuncionesLst = new List<Funciones>();
            
            var funciones = FuncionalidadesChkLst.CheckedItems.Cast<Funciones>();

            if (funciones.Count() == 0)
            {
                MessageBox.Show("Se debe seleccionar al menos una funcionalidad");
                return;
            }
            foreach (Funciones func in funciones)
            {
                rol.FuncionesLst.Add(func);
            }

            RolDaoImpl rDAO = new RolDaoImpl();
            rDAO.Add(rol);
            
            MessageBox.Show("Creación de Rol exitosa");
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            using (BusquedaRol busquedaRolForm = new BusquedaRol())
            {
                if (busquedaRolForm.ShowDialog() == DialogResult.OK)
                {
                    this.Tag = busquedaRolForm.rolSelecccionado;

                    idRolTextBox.Text = busquedaRolForm.rolSelecccionado.idRol.ToString();
                    nombreTextBox.Text = busquedaRolForm.rolSelecccionado.nombre;
                    RolActivoChk.Checked = busquedaRolForm.rolSelecccionado.activo;

                    RolDaoImpl rDAO = new RolDaoImpl();
                    IList<Funciones> funcPorRol = rDAO.obtenerFuncionesPorRol(busquedaRolForm.rolSelecccionado.idRol);

                    for (int d = 0; d < FuncionalidadesChkLst.Items.Count; d++)
                    {
                        FuncionalidadesChkLst.SetItemChecked(d, false);
                    }

                    int i = 0;
                    int j = 0;
                    foreach (Funciones fun in func)
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

                    crearButton.Enabled = false;
                    modificarButton.Enabled = true;
                }
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = null;
            RolActivoChk.Checked = false;
            idRolTextBox.Text = null;

            crearButton.Enabled = true;
            modificarButton.Enabled = false;

            for (int d = 0; d < FuncionalidadesChkLst.Items.Count; d++)
            {
                FuncionalidadesChkLst.SetItemChecked(d, false);
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("Se debe ingresar un nombre de rol");
                return;
            }
            // Validar que tenga almenos una funcion seleccionada

            if (MessageBox.Show("Advertencia: Inhabilitar el rol hará que todos los usuarios ya asignados a este rol no puedan acceder al sistema", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Rol rol = this.Tag as Rol;

            //Cargar datos del form
            rol.nombre = nombreTextBox.Text;
            rol.activo = RolActivoChk.Checked;
            rol.FuncionesLst = new List<Funciones>();

            var funciones = FuncionalidadesChkLst.CheckedItems.Cast<Funciones>();

            if (funciones.Count() == 0)
            {
                MessageBox.Show("Se debe seleccionar al menos una funcionalidad");
                return;
            }
            foreach (Funciones func in funciones)
            {
                rol.FuncionesLst.Add(func);
            }

            //Actualizar rol
            RolDaoImpl rDAO = new RolDaoImpl();
            rDAO.Update(rol);

            MessageBox.Show("Modificación de Rol exitosa");
            this.Close();
        }
    }
}
