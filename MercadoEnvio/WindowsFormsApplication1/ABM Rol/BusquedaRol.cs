using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class BusquedaRol : Form
    {
        public BusquedaRol()
        {
            InitializeComponent();
        }

        public short estado = -1;
        public Rol rolSelecccionado = null;

        private void BusquedaRol_Load(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            rolSelecccionado = dataGridView1.CurrentRow.DataBoundItem as Rol;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public void disparar_evento()
        {
            RolDaoImpl rDAO = new RolDaoImpl();
            IList<Rol> rolesList = rDAO.GetByCriteria(estado, nombreTextBox.Text);

            rolBindingSource.Clear();
            foreach (Rol rol in rolesList)
            {
                rolBindingSource.Add(rol);
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void indistintoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (indistintoRadioButton.Checked == true)
            {
                estado = -1;
                disparar_evento();
            }
        }

        private void activoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (activoRadioButton.Checked == true)
            {
                estado = 0;
                disparar_evento();
            }
        }

        private void inactivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inactivoRadioButton.Checked == true)
            {
                estado = 1;
                disparar_evento();
            }
        }
    }
}
