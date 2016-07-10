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
            Double costo =0;
            if(VisibilidadCostoTxt.Text != "")
            {
                costo = Convert.ToDouble(VisibilidadCostoTxt.Text);
            }
            else
            {
                MessageBox.Show("Se debe ingresar el costo de la visibilidad");
                return;
            }

            Double porcentaje = Convert.ToDouble(VisibilidadPorcentajeTxt.Text);
            if(VisibilidadPorcentajeTxt.Text!="")
            {
                porcentaje = Convert.ToDouble(VisibilidadPorcentajeTxt.Text);
            }
            else
            {
                MessageBox.Show("Se debe ingresar el porcentaje de la visibilidad");
                
            }

            Visibilidad visibilidad = new Visibilidad();
            visibilidad.nombreVisibilidad=nombre;
            visibilidad.costo=costo;
            visibilidad.porcentaje=porcentaje;
            visibilidad.activo = true;
            VisibilidadDaoImpl visibilidadDaoImp = new VisibilidadDaoImpl();
            visibilidadDaoImp.Add(visibilidad);
            MessageBox.Show("Se creo una nueva visibilidad");
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisibilidadNombreTxt.Text = "";
            VisibilidadPorcentajeTxt.Text = "";
            VisibilidadCostoTxt.Text = "";
        }
    }
}

     
