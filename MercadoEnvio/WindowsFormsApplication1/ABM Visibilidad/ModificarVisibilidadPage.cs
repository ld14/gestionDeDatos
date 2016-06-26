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
    public partial class ModificarVisibilidadPage : Form
    {
        public ModificarVisibilidadPage()
        {
            InitializeComponent();
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> visibilidades = visibilidadDao.obtenerVisibilidades();
            foreach (Visibilidad visibilidad in visibilidades)
            {
                VisibilidadesCombobox.Items.Add(visibilidad.nombreVisibilidad);
            }
        }

        private void VisibilidadesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
             string visibilidadName = VisibilidadesCombobox.SelectedItem as string;
            Visibilidad visibilidad = visibilidadDao.getVisibilidadByName(visibilidadName);
            this.VisibilidadPorcentajeTxt.Text = Convert.ToString(visibilidad.porcentaje); 
            this.VisibilidadCostoTxt.Text = Convert.ToString(visibilidad.costo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string visibilidadName = VisibilidadesCombobox.SelectedItem as string;

            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            Visibilidad visibilidad = visibilidadDao.getVisibilidadByName(visibilidadName);

            Double porcentaje = Convert.ToDouble(VisibilidadPorcentajeTxt.Text);
            Double costo = Convert.ToDouble(VisibilidadCostoTxt.Text);

            Visibilidad nuevaVisibilidad = new Visibilidad();

            nuevaVisibilidad.nombreVisibilidad = visibilidadName;
            nuevaVisibilidad.porcentaje = porcentaje;
            nuevaVisibilidad.costo = costo;
            nuevaVisibilidad.idVisibilidad = visibilidad.idVisibilidad;
            nuevaVisibilidad.codigoVisibilidad = visibilidad.codigoVisibilidad;
            
            visibilidadDao.Update(nuevaVisibilidad);
            MessageBox.Show("Visibilidad modificada con éxito");
               
        }
        }
    
}
