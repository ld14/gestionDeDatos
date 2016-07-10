using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;
using WindowsFormsApplication1.Entity.DAO;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class CompraVentaForm : Form
    {
        public static int totalRecords = 0;
        private const int pageSize = 10;
        IList<SubastaCompraDelSistema> customerList = new List<SubastaCompraDelSistema>();
        IList<SoloSubasta> customerList2 = new List<SoloSubasta>();
        Boolean esSubasta = false;

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
            customerList = new List<SubastaCompraDelSistema>();  

            if (SessionAttribute.user is Cliente)
            {
                Cliente user = SessionAttribute.clienteUser;
                nombreUsuario.Text = user.nombre + " " + user.apellido;
                compEfectuadas.Text += Convert.ToString(user.comprasEfectuadas);
                compSinCalificar.Text +=  Convert.ToString(user.comprasEfectuadas - user.comprasCalificadas);
                montoTotal.Text += Convert.ToString(user.montoComprado);
                estrellasDadas.Text += Convert.ToString(user.estrellasDadas);

                OfertaSubastaDaoImpl ofertDao = new OfertaSubastaDaoImpl();
                IList<Ofertasubasta> ofertas = ofertDao.GetByUsuario(user.idUsuario);

                subParticipadas.Text += Convert.ToString(ofertas.Count);

                int cant = 0;
                foreach (Ofertasubasta ofert in ofertas)
                {
                    if (ofert.adjudicada == true) cant++;
                }

                subGanadas.Text += Convert.ToString(cant); 

                SubastaCompraDelSistemaDaoImpl subastaCompraDelSistemaDaoImpl = new SubastaCompraDelSistemaDaoImpl();
                customerList = subastaCompraDelSistemaDaoImpl.darSubastaCompra(user.idUsuario);
                SoloSubastaDaoImpl superDAO = new SoloSubastaDaoImpl();
                customerList2 = superDAO.darSubastasParticipadas(user.idUsuario);

            }

            TotalRecords = this.customerList.Count;
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();

        }

        private void compraClick(object sender, EventArgs e)
        {
            if (compraL.Font.Underline == false)
            {
                esSubasta = false;
                compraL.Font = new Font(compraL.Font, FontStyle.Underline);
                subastaL.Font = new Font(subastaL.Font, FontStyle.Regular);
                splitCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                splitSubasta.BorderStyle = System.Windows.Forms.BorderStyle.None;

                TotalRecords = this.customerList.Count;

                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
                bindingSource1.DataSource = new PageOffsetList();
            }
        }

        private void subastaClick(object sender, EventArgs e)
        {
            if (subastaL.Font.Underline == false)
            {
                esSubasta = true;
                compraL.Font = new Font(compraL.Font, FontStyle.Regular);
                subastaL.Font = new Font(subastaL.Font, FontStyle.Underline);
                splitSubasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                splitCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;

                TotalRecords = this.customerList2.Count;

                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged2);
                bindingSource1.DataSource = new PageOffsetList();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (!esSubasta)
            {
                // The desired page has changed, so fetch the page of records using the "Current" offset 
                int offset = (int)bindingSource1.Current;
                var records = new List<SubastaCompraDelSistema>();
                for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                    records.Add(this.customerList[i]);
                dataGridView1.DataSource = records;

                //Chequeo si alguna calificacion esta pendiente
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value == null)
                        dataGridView1.Rows[i].Cells[7].Value = "(Pendiente)";
                }

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;

                dataGridView1.Columns[2].HeaderText = "Tipo de Compra";
                dataGridView1.Columns[2].Width = 125;
                dataGridView1.Columns[3].HeaderText = "Fecha Compra";
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].HeaderText = "Cantidad Comprada";
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].HeaderText = "Código Publicación";
                dataGridView1.Columns[5].Width = 86;
                dataGridView1.Columns[6].HeaderText = "Descripción";
                dataGridView1.Columns[6].Width = 255;
                dataGridView1.Columns[7].HeaderText = "Calificación dada";
                dataGridView1.Columns[7].Width = 83;
                dataGridView1.Columns[8].HeaderText = "Comentario Calificación";
                dataGridView1.Columns[8].Width = 200;
            }
        }

        private void bindingSource1_CurrentChanged2(object sender, EventArgs e)
        {
            if (esSubasta)
            {
                // The desired page has changed, so fetch the page of records using the "Current" offset 
                int offset = (int)bindingSource1.Current;
                var records = new List<SoloSubasta>();
                for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                    records.Add(this.customerList2[i]);
                dataGridView1.DataSource = records;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;

                dataGridView1.Columns[2].HeaderText = "Tipo de Compra";
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].HeaderText = "Fecha de Oferta";
                dataGridView1.Columns[3].Width = 88;
                dataGridView1.Columns[4].HeaderText = "Valor Inicial";
                dataGridView1.Columns[4].Width = 86;
                dataGridView1.Columns[5].HeaderText = "Monto Oferta";
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].HeaderText = "Adjudicada";
                dataGridView1.Columns[6].Width = 160;
                dataGridView1.Columns[7].HeaderText = "Código Publicación";
                dataGridView1.Columns[7].Width = 85;
                dataGridView1.Columns[8].HeaderText = "Descripción";
                dataGridView1.Columns[8].Width = 300;

                dataGridView1.Columns[5].DisplayIndex = 5;
                //customersDataGridView.Columns["ContactTitle"].DisplayIndex = 1;
                //customersDataGridView.Columns["City"].DisplayIndex = 2;
                //customersDataGridView.Columns["Country"].DisplayIndex = 3;
                //customersDataGridView.Columns["CompanyName"].DisplayIndex = 4;

            }
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

/*
        private void setValoresFormulario   (string DatosUsuarioText,string CantidadComprasText,string 
                                             CantSinCalifText,string CantCalifText,string CantidadEstrellasText) { 
            nombreUsuario.Text = DatosUsuarioText;
            nombreUsuario.Enabled = false;
            CantidadCompras.Text = CantidadComprasText;
            CantidadCompras.Enabled = false;
            CantSinCalif.Text = CantSinCalifText;
            CantSinCalif.Enabled = false;
            CantCalif.Text = CantCalifText;
            CantCalif.Enabled = false;
            CantidadEstrellas.Text = CantidadEstrellasText;
            CantidadEstrellas.Enabled = false;
        }
 */
    }
}
