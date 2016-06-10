using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class CompraVentaForm : Form
    {
        public static int totalRecords = 0;
        private const int pageSize = 10;
        IList<SubastaCompraDelSistema> customerList = new List<SubastaCompraDelSistema>();

        public static int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public CompraVentaForm()
        {
            InitializeComponent();
        }

        private void CompraVentaForm_Load(object sender, EventArgs e)
        {
            string DatosUsuarioText="";
            string CantidadComprasText = "";
            string CantSinCalifText = "";
            string CantCalifText = "";
            string CantidadEstrellasText = "";
            customerList = new List<SubastaCompraDelSistema>();  

            if (SessionAttribute.user is Cliente)
            {
                Cliente user = (Cliente)SessionAttribute.user;
                DatosUsuarioText = user.nombre + " " + user.apellido;
                CantidadComprasText = Convert.ToString(user.comprasEfectuadas);
                CantSinCalifText =  Convert.ToString(user.comprasEfectuadas - user.comprasCalificadas);
                CantCalifText = Convert.ToString(user.comprasCalificadas);
                CantidadEstrellasText = Convert.ToString(user.cantidadEstrellas);

                SubastaCompraDelSistemaDaoImpl subastaCompraDelSistemaDaoImpl = new SubastaCompraDelSistemaDaoImpl();
                customerList = subastaCompraDelSistemaDaoImpl.darSubastaCompra(user.idUsuario);

            }
            if (SessionAttribute.user is Empresa)
            {
                Empresa user = (Empresa)SessionAttribute.user;
                DatosUsuarioText = user.razonSocial;

                labelCantCompras.Text = "Cantidad de Ventas";
                CantidadComprasText = Convert.ToString(user.cantidadVentas);

                CantSinCalif.Visible = false;
                cantSCalifLabel.Visible = false;
                CantSinCalifText = "0";

                CantCalif.Visible = false;
                canCaliLabel.Visible = false;
                CantCalifText = "0";

                CantEstrellasLabel.Text = "Cantidad de Estrellas Recibidas";
                CantidadEstrellasText = Convert.ToString(user.cantidadEstrellas);

                SubastaCompraDelSistemaDaoImpl subastaCompraDelSistemaDaoImpl = new SubastaCompraDelSistemaDaoImpl();
                customerList = subastaCompraDelSistemaDaoImpl.darSubastaCompra(user.idUsuario);
            }

            this.setValoresFormulario(DatosUsuarioText, CantidadComprasText, CantSinCalifText, CantCalifText, CantidadEstrellasText);

            TotalRecords = this.customerList.Count;
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            var records = new List<SubastaCompraDelSistema>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[2].HeaderText = "Tipo de Compra";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Fecha";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Cantidad Comprada";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].HeaderText = "Codigo de Publicacion";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "Descripcion";
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].HeaderText = "Cantiadad Estrella";
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].HeaderText = "Descripcion Calificacion";
            dataGridView1.Columns[8].Width = 200;


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


        private void setValoresFormulario   (string DatosUsuarioText,string CantidadComprasText,string 
                                             CantSinCalifText,string CantCalifText,string CantidadEstrellasText) { 
            DatosUsuario.Text = DatosUsuarioText;
            DatosUsuario.Enabled = false;
            CantidadCompras.Text = CantidadComprasText;
            CantidadCompras.Enabled = false;
            CantSinCalif.Text = CantSinCalifText;
            CantSinCalif.Enabled = false;
            CantCalif.Text = CantCalifText;
            CantCalif.Enabled = false;
            CantidadEstrellas.Text = CantidadEstrellasText;
            CantidadEstrellas.Enabled = false;
        }
    }
}
