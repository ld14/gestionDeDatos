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
    public partial class EliminarRolPage : Form
    {
        public EliminarRolPage()
        {
            InitializeComponent();
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Rol> roles = rolDao.obtenerRoles();


            foreach (Rol rol in roles)
            {
                RolesCombobox.Items.Add(rol.nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RolDaoImpl rolDao = new RolDaoImpl();
            string rolName = RolesCombobox.SelectedItem as string;
            Rol rol = rolDao.getRolByName(rolName);

            //CONSULTAR: actualmente la tabla RolUsuario tiene un campo 'activo', sin embargo este no se usa ya que la relación existe o no,
            //no se activa o desactiva, lo que se desactiva es el rol en la tabla 'Rol'. Preguntar a Rosa/Giselle
            rol.activo = false;
            rolDao.Update(rol);
            MessageBox.Show("Eliminación exitosa");
        }
    }
}
