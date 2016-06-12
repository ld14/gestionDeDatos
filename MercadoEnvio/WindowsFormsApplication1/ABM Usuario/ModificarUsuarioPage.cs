using System;
using NHibernate;
using WindowsFormsApplication1.Entity.Utils;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificarUsuarioPage : Form
    {
        public ModificarUsuarioPage()
        {
            InitializeComponent();
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
           IEnumerator<Rol> rolUser = SessionAttribute.user.RolesLst.GetEnumerator();
           rolUser.MoveNext();

           if (rolUser.Current.nombre == "Cliente")
           {
               ClienteGroup.Visible = true;
               EmpresaGroup.Visible = false;

           }
           else
           {
               EmpresaGroup.Visible = true;
               ClienteGroup.Visible = false;

           }
           
        }
    }
}
