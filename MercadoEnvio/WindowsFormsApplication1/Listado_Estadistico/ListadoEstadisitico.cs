using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class ListadoEstadisitico : Form
    {

        public ListadoEstadisitico()
        {
            InitializeComponent();
        }

        private void ListadoEstadisitico_Load(object sender, EventArgs e)
        {
            string[] monthNames = (new System.Globalization.CultureInfo("es-AR")).DateTimeFormat.MonthNames;

            List<labelValue> lstAnio = new List<labelValue>();
            for (int i = 2010; i <= 2016; i++)
            {
                labelValue lb = new labelValue();
                lb.value = Convert.ToString(i);
                lb.label = Convert.ToString(i);
                lstAnio.Add(lb);
            }

            int count = 1;
            List<labelValue> mesesInicialLts = new List<labelValue>();
            List<labelValue> mesesFinalLts = new List<labelValue>();
            foreach (string mes in monthNames)
            {
                labelValue lb = new labelValue();
                lb.value = Convert.ToString(count);
                lb.label = mes;
                count++;
                mesesInicialLts.Add(lb);
                mesesFinalLts.Add(lb);
            }

            anioSelect.DataSource = lstAnio;
            anioSelect.DisplayMember = "label";
            anioSelect.ValueMember = "value";

            MesInitCombo.DataSource = mesesInicialLts;
              MesInitCombo.DisplayMember = "label";
              MesInitCombo.ValueMember = "value";

              mesFinSelect.DataSource = mesesFinalLts;
            mesFinSelect.DisplayMember = "label";
            mesFinSelect.ValueMember = "value";

        }

        private class labelValue
        {
            public string value { get; set; }
            public string label { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32((anioSelect.SelectedItem as labelValue).value);
            int mesInicial = Convert.ToInt32((MesInitCombo.SelectedItem as labelValue).value);
            int mesFinal = Convert.ToInt32((mesFinSelect.SelectedItem as labelValue).value);
            

            if (mesInicial > mesFinal)
            {
                MessageBox.Show("No puede elegir un mes final mayor a un mes inicial");
                return;
            }

            if ((mesFinal - mesInicial) != 2)
            {
                MessageBox.Show("No puede elegir un periodo menor o mayor a tres meses");
                return;
            }
            
            string fechaInicial = generarFecha(mesInicial,anio,true);
            string fechaFinal = generarFecha(mesFinal, anio, true);

            DateTime dateFechaInicial =   DateUtils.convertirStringEnFecha(fechaInicial);
            DateTime dateFechaFin = DateUtils.convertirStringEnFecha(fechaFinal);

            if (reporteSelect.Text.Equals("Vendedores con mayor cantidad de productos no vendidos")) {
                EstadisticaVendedoresDaoImpl estaVendImpl = new EstadisticaVendedoresDaoImpl();
                IList<EstadisticasVendedoresGrilla> resultado = estaVendImpl.darEstadisticasVendedores(dateFechaInicial, dateFechaFin, 1);
            }
           
            /*Vendedores con mayor cantidad de productos no vendidos
            Vendedores con mayor cantidad de facturas
            Vendedores con mayor monto facturado
            Clientes con mayor cantidad de productos comprados*/
            MessageBox.Show("casi estasmos");

        }

        private void reporteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string generarFecha(int mesInicial,int anio,bool inical){
            string diaInicial = "01";
            
            string mes = "";
            if (mesInicial < 10)
            {
                mes = "0" + mesInicial;
            }
            else {
                mes = Convert.ToString(mesInicial);
                if (mesInicial == 12 && !inical) {
                    anio=anio + 1;
                }
            }

            string fechaArmada = diaInicial + "/" + mes + "/" + anio;

            return fechaArmada;
        }
            

        }

    
}
