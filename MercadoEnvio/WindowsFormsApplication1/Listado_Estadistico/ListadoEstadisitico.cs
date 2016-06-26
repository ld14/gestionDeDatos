using NHibernate.Mapping;
using System;
using System.Collections;
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

        public static int totalRecords = 0;
        private const int pageSize = 10;
        List<Object> customerList = new List<Object>();

        public static int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

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
            EstadisticaVendedoresDaoImpl estaVendImpl = new EstadisticaVendedoresDaoImpl();

            if (reporteSelect.Text.Equals("Vendedores con mayor cantidad de productos no vendidos")) {
                
                customerList = new List<Object>(estaVendImpl.darEstadisticasVendedores(dateFechaInicial, dateFechaFin, 1));
                TotalRecords = this.customerList.Count;
                //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
                bindingSource1.DataSource = new PageOffsetList();
            }

            if (reporteSelect.Text.Equals("Clientes con mayor cantidad de productos comprados"))
            {
                customerList = new List<Object>(estaVendImpl.darEstadisticasCompradores(dateFechaInicial, dateFechaFin, 1));
                TotalRecords = this.customerList.Count;
                //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChangedCompra);
                bindingSource1.DataSource = new PageOffsetList();
            }
            if (reporteSelect.Text.Equals("Vendedores con mayor cantidad de facturas"))
            {
                customerList = new List<Object>(estaVendImpl.darMaximaCantidadFacturas(anio, mesInicial, mesFinal));
                TotalRecords = this.customerList.Count;
                //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChangedMaxCantidadVenta);
                bindingSource1.DataSource = new PageOffsetList();
            }
            if (reporteSelect.Text.Equals("Vendedores con mayor monto facturado"))
            {
                customerList = new List<Object>(estaVendImpl.darMonToMaximoFacturas(anio, mesInicial, mesFinal));
                TotalRecords = this.customerList.Count;
                //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChangedMontoMaximo);
                bindingSource1.DataSource = new PageOffsetList();
            }
            /*Vendedores con mayor cantidad de productos no vendidos
            Vendedores con mayor cantidad de facturas
            Vendedores con mayor monto facturado
            Clientes con mayor cantidad de productos comprados*/



            

        }

        private void reporteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChangedCompra(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            var mesesDicionario = new Dictionary<int, string>();
                mesesDicionario.Add(1,"enero");
                mesesDicionario.Add(2,"febrero");
                mesesDicionario.Add(3,"marzo");
                mesesDicionario.Add(4,"abril");
                mesesDicionario.Add(5,"mayo");
                mesesDicionario.Add(6,"junio");
                mesesDicionario.Add(7,"julio"); 
                mesesDicionario.Add(8,"agosto");
                mesesDicionario.Add(9,"septiembre");
                mesesDicionario.Add(10,"octubre");
                mesesDicionario.Add(11,"noviembre");
                mesesDicionario.Add(12,"diciembre");
                

            int offset = (int)bindingSource1.Current;
            var records = new List<Object>();

            for (int i = offset; i < offset + pageSize && i < totalRecords; i++) {
                EstadisticaCompradoresGrilla nuevo = this.customerList[i] as EstadisticaCompradoresGrilla;
               // nuevo.NombreMes = mesesDicionario[nuevo.mes];
                records.Add(nuevo);
            }
            

            dataGridView1.DataSource = records;

            
            
            dataGridView1.Columns[3].HeaderText = "Mes";
            dataGridView1.Columns[3].DisplayIndex = 1;
            dataGridView1.Columns[2].HeaderText = "Usuario";
            dataGridView1.Columns[2].DisplayIndex = 2;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Cantidad Comprada";
            dataGridView1.Columns[1].DisplayIndex = 3;

            dataGridView1.Columns[0].Visible = false;
            

            //myGridView.Columns["mySecondCol"].DisplayIndex = 1; ARRREGALNDO ELBAROD


        }

        private void bindingSource1_CurrentChangedMaxCantidadVenta(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            var mesesDicionario = new Dictionary<int, string>();
            mesesDicionario.Add(1, "enero");
            mesesDicionario.Add(2, "febrero");
            mesesDicionario.Add(3, "marzo");
            mesesDicionario.Add(4, "abril");
            mesesDicionario.Add(5, "mayo");
            mesesDicionario.Add(6, "junio");
            mesesDicionario.Add(7, "julio");
            mesesDicionario.Add(8, "agosto");
            mesesDicionario.Add(9, "septiembre");
            mesesDicionario.Add(10, "octubre");
            mesesDicionario.Add(11, "noviembre");
            mesesDicionario.Add(12, "diciembre");


            int offset = (int)bindingSource1.Current;
            var records = new List<Object>();

            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            {
                Estadisticamaximos nuevo = this.customerList[i] as Estadisticamaximos;
                // nuevo.NombreMes = mesesDicionario[nuevo.mes];
                records.Add(nuevo);
            }


            dataGridView1.DataSource = records;



            dataGridView1.Columns[2].HeaderText = "Usuario";
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[3].HeaderText = "Año";
            dataGridView1.Columns[3].DisplayIndex = 2;
            dataGridView1.Columns[3].Width = 40;

            dataGridView1.Columns[4].HeaderText = "Mes";
            dataGridView1.Columns[4].DisplayIndex = 3;
            dataGridView1.Columns[4].Width = 40;

            dataGridView1.Columns[5].HeaderText = "Cantidad Facturado";
            dataGridView1.Columns[5].DisplayIndex = 4;
            dataGridView1.Columns[5].Width = 100;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            //myGridView.Columns["mySecondCol"].DisplayIndex = 1; ARRREGALNDO ELBAROD


        }

        private void bindingSource1_CurrentChangedMontoMaximo(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            var mesesDicionario = new Dictionary<int, string>();
            mesesDicionario.Add(1, "enero");
            mesesDicionario.Add(2, "febrero");
            mesesDicionario.Add(3, "marzo");
            mesesDicionario.Add(4, "abril");
            mesesDicionario.Add(5, "mayo");
            mesesDicionario.Add(6, "junio");
            mesesDicionario.Add(7, "julio");
            mesesDicionario.Add(8, "agosto");
            mesesDicionario.Add(9, "septiembre");
            mesesDicionario.Add(10, "octubre");
            mesesDicionario.Add(11, "noviembre");
            mesesDicionario.Add(12, "diciembre");


            int offset = (int)bindingSource1.Current;
            var records = new List<Object>();

            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            {
                Estadisticamaximos nuevo = this.customerList[i] as Estadisticamaximos;
                // nuevo.NombreMes = mesesDicionario[nuevo.mes];
                records.Add(nuevo);
            }


            dataGridView1.DataSource = records;



            dataGridView1.Columns[2].HeaderText = "Usuario";
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[3].HeaderText = "Año";
            dataGridView1.Columns[3].DisplayIndex = 2;
            dataGridView1.Columns[3].Width = 40;

            dataGridView1.Columns[4].HeaderText = "Mes";
            dataGridView1.Columns[4].DisplayIndex = 3;
            dataGridView1.Columns[4].Width = 40;

            dataGridView1.Columns[6].HeaderText = "Monto maximo Facturado";
            dataGridView1.Columns[6].DisplayIndex = 4;
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;


            //myGridView.Columns["mySecondCol"].DisplayIndex = 1; ARRREGALNDO ELBAROD


        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            var records = new List<Object>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;

            /*
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Codigo";
            dataGridView1.Columns[2].HeaderText = "Tipo De Venta";
            dataGridView1.Columns[3].HeaderText = "Descripcion Producto";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "Rubro";
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].HeaderText = "Precio";
            dataGridView1.Columns[7].HeaderText = "Fin de Venta";*/


        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < TotalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
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
