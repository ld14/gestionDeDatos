using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class EliminarVisibilidadPage : Form
    {
        public EliminarVisibilidadPage()
        {
            InitializeComponent();
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> visibilidades = visibilidadDao.obtenerVisibilidades();
            foreach (Visibilidad visibilidad in visibilidades)
            {
                VisibilidadesCombobox.Items.Add(visibilidad.nombreVisibilidad);
            }
        }

        private void EliminarVisibilidadPage_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string visibilidadSeleccionada = VisibilidadesCombobox.SelectedItem.ToString();
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Publicacion> publicaciones = visibilidadDao.obtenerPublicacionesSegunVisibilidad(visibilidadSeleccionada);
            if (publicaciones.Count > 0)
            {
                MessageBox.Show("No se permite eliminar visibilidades que tengan publicaciones asociadas. Cantidad publicaciones: " + publicaciones.Count);
            }
            else
            {
                Visibilidad visibilidad = visibilidadDao.getVisibilidadByName(visibilidadSeleccionada);
                visibilidad.activo = false;
                visibilidadDao.Update(visibilidad);
                MessageBox.Show("Eliminación de visibilidad exitosa");
            }
        }
    }
}
