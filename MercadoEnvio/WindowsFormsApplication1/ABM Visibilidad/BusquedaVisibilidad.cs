using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class BusquedaVisibilidad : Form
    {
        public BusquedaVisibilidad()
        {
            InitializeComponent();
        }

        public short estado = -1;
        public Visibilidad visibilidadSeleccionada = null;

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            visibilidadSeleccionada = dataGridView1.CurrentRow.DataBoundItem as Visibilidad;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void BusquedaVisibilidad_Load(object sender, EventArgs e)
        {
            disparar_evento();
        }

        public void disparar_evento()
        {
            VisibilidadDaoImpl vDAO = new VisibilidadDaoImpl();
            IList<Visibilidad> visibilidadList = vDAO.GetByCriteria(estado, nombreTextBox.Text);

            visibilidadBindingSource.Clear();
            foreach (Visibilidad visibilidad in visibilidadList)
            {
                visibilidadBindingSource.Add(visibilidad);
            }
        }

        private void indistintoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            estado = -1;
            disparar_evento();
        }

        private void activoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            estado = 0;
            disparar_evento();
        }

        private void inactivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            estado = 1;
            disparar_evento();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }
    }
}
