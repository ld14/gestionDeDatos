using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class ABMVisibilidadPage : Form
    {
        public ABMVisibilidadPage()
        {
            InitializeComponent();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            if (!validaciones_formulario()) return;

            Visibilidad visibilidad = new Visibilidad();
            visibilidad.nombreVisibilidad = nombreTextBox.Text;
            visibilidad.costo = Convert.ToDouble(costoTextBox.Text);
            visibilidad.porcentaje = (Double)porcentajeNumeric.Value / 100;
            visibilidad.activo = activoCheckBox.Checked;

            VisibilidadDaoImpl visibilidadDaoImp = new VisibilidadDaoImpl();
            visibilidadDaoImp.Add(visibilidad);
            MessageBox.Show("Se creo una nueva visibilidad con exito.");
            this.Close();
        }

        public bool validaciones_formulario()
        {
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("Se debe ingresar el nombre de la visibilidad");
                return false;
            }

            if (!Regex.IsMatch(costoTextBox.Text, @"(^(\d)+(,(\d)+)?)$"))
            {
                MessageBox.Show("El campo Costo Fijo solo admite un número decimal");
                return false;
            }

            return true;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = "";
            porcentajeNumeric.Value = 0;
            costoTextBox.Text = "";
            this.Tag = null;
            codigoTextBox.Text = "";
            crearButton.Enabled = true;
            modificarButton.Enabled = false;
            activoCheckBox.Checked = false;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            using (BusquedaVisibilidad busquedaVisibilidadForm = new BusquedaVisibilidad())
            {
                if (busquedaVisibilidadForm.ShowDialog() == DialogResult.OK)
                {
                    this.Tag = busquedaVisibilidadForm.visibilidadSeleccionada as Visibilidad;
                    codigoTextBox.Text = busquedaVisibilidadForm.visibilidadSeleccionada.codigoVisibilidad.ToString();
                    nombreTextBox.Text = busquedaVisibilidadForm.visibilidadSeleccionada.nombreVisibilidad;
                    costoTextBox.Text = busquedaVisibilidadForm.visibilidadSeleccionada.costo.ToString();
                    porcentajeNumeric.Value = (Decimal)busquedaVisibilidadForm.visibilidadSeleccionada.porcentaje * 100;
                    activoCheckBox.Checked = busquedaVisibilidadForm.visibilidadSeleccionada.activo;
                    
                    crearButton.Enabled = false;
                    modificarButton.Enabled = true;
                }
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (!validaciones_formulario()) return;

            Visibilidad visibilidad = this.Tag as Visibilidad;
            visibilidad.nombreVisibilidad = nombreTextBox.Text;
            visibilidad.costo = Convert.ToDouble(costoTextBox.Text);
            visibilidad.porcentaje = (Double)porcentajeNumeric.Value / 100;
            visibilidad.activo = activoCheckBox.Checked;

            VisibilidadDaoImpl visibilidadDaoImp = new VisibilidadDaoImpl();
            visibilidadDaoImp.Update(visibilidad);
            MessageBox.Show("Se modificó la visibilidad con exito.");
            this.Close();
        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (modificarButton.Enabled && !activoCheckBox.Checked)
            {
                Visibilidad vis = this.Tag as Visibilidad;
                PublicacionNormalDaoImpl pnDAO = new PublicacionNormalDaoImpl();

                IList<Publicacion> pubList = pnDAO.GetByVisibilidad(vis.idVisibilidad);
                if (pubList.Count > 0)
                {
                    MessageBox.Show("ERROR: La visibilidad esta en uso. No se puede inhabilitar la misma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activoCheckBox.Checked = true;
                }
            }
        }

    }
}

     
