using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class GenerarPublicacionPage : Form
    {

        public GenerarPublicacionPage()
        {
            InitializeComponent();
            
            //----------------------Campos seccion Estados-------------------------------------------//
            // NOTA: ESTO HAY QUE REFACTORIZARLO POR EL WF DE ESTADOS.
            EstadoPublicacionDaoDaoImpl estadosDao = new EstadoPublicacionDaoDaoImpl();
            IList<Estadopublicacion> estadosPublicacionLts = estadosDao.darEstados();

            //Setup data binding
            EstadoComboBox.DataSource = estadosPublicacionLts;
            EstadoComboBox.DisplayMember = "nombre";
            EstadoComboBox.ValueMember = "idEstadoPublicacion";

            //----------------------Campos seccion Rol-----------------------------------------------//
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Rol> rolDaoLts = rolDao.darRolActivo();

            RubroComboBox.DataSource = rolDaoLts;
            RubroComboBox.DisplayMember = "nombre";
            RubroComboBox.ValueMember = "idRol";

            //----------------------Campos seccion Visibilidad --------------------------------------//
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();

            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "idVisibilidad";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
            //MessageBox.Show(selectedEstado.nombre, "caption goes here");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
            MessageBox.Show(selectedEstado.nombre, "caption goes here");
        }

        private void RubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
