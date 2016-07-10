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
    public partial class AltaVisibilidadPage : Form
    {
        public AltaVisibilidadPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = "";
            if (VisibilidadNombreTxt.Text != "")
            {
                nombre = VisibilidadNombreTxt.Text;
            }
            else 
            {
                MessageBox.Show("Se debe ingresar el nombre de la visibilidad");
                return;
            }
            Double costo = 0;
            if(VisibilidadCostoTxt.Text != "")
            {
                costo = Convert.ToDouble(VisibilidadCostoTxt.Text);
            }
            else
            {
                MessageBox.Show("Se debe ingresar el costo de la visibilidad");
                return;
            }

            Double porcentaje = (Double)porcentajeNumeric.Value / 100;

            Visibilidad visibilidad = new Visibilidad();
            visibilidad.nombreVisibilidad = nombre;
            visibilidad.costo = costo;
            visibilidad.porcentaje = porcentaje;
            visibilidad.activo = activoCheckBox.Checked;
            VisibilidadDaoImpl visibilidadDaoImp = new VisibilidadDaoImpl();
            visibilidadDaoImp.Add(visibilidad);
            MessageBox.Show("Se creo una nueva visibilidad");
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisibilidadNombreTxt.Text = "";
            porcentajeNumeric.Value = 0;
            VisibilidadCostoTxt.Text = "";
        }
    }
}

     
