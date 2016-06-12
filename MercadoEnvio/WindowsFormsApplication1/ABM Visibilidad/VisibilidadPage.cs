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
    public partial class VisibilidadPage : Form
    {
        public VisibilidadPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = VisibilidadNombreTxt.Text;
            Double costo = Convert.ToDouble(VisibilidadCostoTxt.Text);
            Double porcentaje = Convert.ToDouble(VisibilidadPorcentajeTxt.Text);

            Visibilidad visibilidad = new Visibilidad();
            visibilidad.nombreVisibilidad=nombre;
            visibilidad.costo=costo;
            visibilidad.porcentaje=porcentaje;
            VisibilidadDaoImpl visibilidadDaoImp = new VisibilidadDaoImpl();
            visibilidadDaoImp.Add(visibilidad);
 
        }
    }
}

     
