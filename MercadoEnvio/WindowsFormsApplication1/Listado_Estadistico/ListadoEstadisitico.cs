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
        enum TiposListado { vendedoresMayorCantidadProdNoVendidos, clientesMayorCantidadProdComprados, vendedoresMayorCantidadFacturas, vendedoresMayorMontoFacturado };
        int listadoSeleccionado = -1;
        string visibilidadSeleccionada = "-1";
        string rubroSeleccionado = "-1";

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
            //-----------------Combo Años------------------------
            List<labelValue> lstAnio = new List<labelValue>();
            for (int i = 2010; i <= 2016; i++)
            {
                labelValue lb = new labelValue();
                lb.value = Convert.ToString(i);
                lb.label = Convert.ToString(i);
                lstAnio.Add(lb);
            }

            anioSelect.DataSource = lstAnio;
            anioSelect.DisplayMember = "label";
            anioSelect.ValueMember = "value";

            //----------------------Combo Rubros-------------------------------------------//
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();
            Rubro rubroAux = new Rubro();
            rubroAux.descripcion = "Seleccione un rubro";
            rubroLts.Insert(0, rubroAux);

            RubroComboBox.DataSource = rubroLts;
            RubroComboBox.DisplayMember = "descripcion";
            RubroComboBox.ValueMember = "descripcion";

            //----------------------Combo visibilidad--------------------------------------//
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();
            Visibilidad visibilidadAux = new Visibilidad();
            visibilidadAux.nombreVisibilidad = "Seleccione una visibilidad";
            VisibilidadLts.Insert(0, visibilidadAux);

            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "nombreVisibilidad";
        }

        private class labelValue
        {
            public string value { get; set; }
            public string label { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32((anioSelect.SelectedItem as labelValue).value);
            int trimestreSeleccionado = Convert.ToInt32(TrimestreCombo.SelectedIndex + 1);

            ListadoEstadisticasDaoImpl estaVendImpl = new ListadoEstadisticasDaoImpl();

            switch (reporteSelect.Text)
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    Visibilidad objVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
                    visibilidadSeleccionada = objVisibilidad.nombreVisibilidad;
                    listadoSeleccionado = (int)TiposListado.vendedoresMayorCantidadProdNoVendidos;
                    break;
                case "Clientes con mayor cantidad de productos comprados":
                    Rubro objRubro = RubroComboBox.SelectedItem as Rubro;
                    rubroSeleccionado = objRubro.descripcion;
                    listadoSeleccionado = (int)TiposListado.clientesMayorCantidadProdComprados;
                    break;
                case "Vendedores con mayor cantidad de facturas":
                    listadoSeleccionado = (int)TiposListado.vendedoresMayorCantidadFacturas;
                    break;
                case "Vendedores con mayor monto facturado":
                    listadoSeleccionado = (int)TiposListado.vendedoresMayorMontoFacturado;
                    break;
                default:
                    MessageBox.Show("Tipo de listado seleccionado no reconocido");
                    break;
            }

            customerList = new List<Object>(estaVendImpl.darInformacionListado(listadoSeleccionado, anio, trimestreSeleccionado, visibilidadSeleccionada, rubroSeleccionado));
            TotalRecords = this.customerList.Count;
            if (TotalRecords == 0)
            {
                MessageBox.Show("No se encontraron resultados");
            }
            else
            {
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
                bindingSource1.DataSource = new PageOffsetList();
                MessageBox.Show("Búsqueda finalizada. Registros encontrados: " + TotalRecords);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int)bindingSource1.Current;
            var records = new List<Object>();

            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            {
                ListadosEstadisticoGrilla nuevo = new ListadosEstadisticoGrilla();
                Object customer = this.customerList[i];
                nuevo.nombreUsuario = (string)customer.GetType().GetProperty("nombreUsuario").GetValue(customer, null);
                nuevo.anio = (int)customer.GetType().GetProperty("anio").GetValue(customer, null);
                nuevo.mes = (int)customer.GetType().GetProperty("mes").GetValue(customer, null);
                nuevo.cantidad = (int)customer.GetType().GetProperty("cantidad").GetValue(customer, null);
                if (listadoSeleccionado == (int)TiposListado.vendedoresMayorCantidadProdNoVendidos)
                {
                    nuevo.visibilidad = (string)customer.GetType().GetProperty("visibilidad").GetValue(customer, null);
                }
                if (listadoSeleccionado == (int)TiposListado.clientesMayorCantidadProdComprados)
                {
                    nuevo.rubro = (string)customer.GetType().GetProperty("rubro").GetValue(customer, null);
                }
                records.Add(nuevo);
            }

            dataGridView1.DataSource = records;

            dataGridView1.Columns[0].HeaderText = "Usuario";
            dataGridView1.Columns[1].HeaderText = "Año";
            dataGridView1.Columns[2].HeaderText = "Mes";
            dataGridView1.Columns[3].HeaderText = "Cantidad";
            dataGridView1.Columns[4].HeaderText = "Visibilidad";
            dataGridView1.Columns[5].HeaderText = "Rubro";

            dataGridView1.Columns[4].Visible = (listadoSeleccionado == (int)TiposListado.vendedoresMayorCantidadProdNoVendidos);
            dataGridView1.Columns[5].Visible = (listadoSeleccionado == (int)TiposListado.clientesMayorCantidadProdComprados);
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

        private void reporteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reporteSeleccionado = Convert.ToInt32(reporteSelect.SelectedIndex);
            grupoVisibilidad.Visible = (reporteSeleccionado == (int)TiposListado.vendedoresMayorCantidadProdNoVendidos);
            grupoRubros.Visible = (reporteSeleccionado == (int)TiposListado.clientesMayorCantidadProdComprados);
        }
    }
}
