using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Facturas
{
    public partial class FacturasEmitidasForm : Form
    {
        public static int totalRecords = 0;
        private const int pageSize = 10;
        IList<FacturasEmitidas> customerList = new List<FacturasEmitidas>();

        public static int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
        
        public FacturasEmitidasForm()
        {
            InitializeComponent();
        }

        private void FacturasEmitidasForm1_Load(object sender, EventArgs e)
        {
            
            //ClienteDaoImpl clientesImp = new ClienteDaoImpl();
            //clientesImp.ge
            selectorUsuarios userVacio = new selectorUsuarios();
            userVacio.idUsuario=0;
            userVacio.descripcion="";

            List<selectorUsuarios> selectorUsuariosLts = new List<selectorUsuarios>();
            selectorUsuariosLts.Add(userVacio);

            EmpresaDaoImpl empImpl = new EmpresaDaoImpl();
            foreach(Empresa emp in empImpl.getAllEmpresaActivas() ){
                selectorUsuarios user = new selectorUsuarios();
                user.descripcion = emp.razonSocial;
                user.idUsuario = emp.idUsuario;
                selectorUsuariosLts.Add(user);
            }
             
            ClienteDaoImpl cilImpl = new ClienteDaoImpl();
            foreach(Cliente clie in cilImpl.getAllClienteActivos()){
                selectorUsuarios user = new selectorUsuarios();
                user.descripcion = clie.nombre+" "+clie.apellido;
                user.idUsuario = clie.idUsuario;
                selectorUsuariosLts.Add(user);
            }

            destinatarioSelect.DataSource = selectorUsuariosLts;
            destinatarioSelect.DisplayMember = "descripcion";
            destinatarioSelect.ValueMember = "idUsuario";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public class selectorUsuarios{
            public virtual int idUsuario { get; set; }
            public virtual String descripcion { get; set; }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            int idUsuario = (destinatarioSelect.SelectedItem as selectorUsuarios).idUsuario;
            double? amount = null;

            DateTime fechaDesde = DateUtils.convertirStringEnFecha(FechaDesde.Value.ToString("dd/MM/yyyy"));
            DateTime fechaHasta = DateUtils.convertirStringEnFecha(FechaHasta.Value.ToString("dd/MM/yyyy"));
            //columns[i] = new DataColumn(properties[i].Name, properties[i].PropertyType != null ?? properties[i].PropertyType : "");
            double? montoTotalini = !montoInicial.Text.Equals("") ? Convert.ToDouble(montoInicial.Text) : amount;
            double? montoTotalfin = !montoFinal.Text.Equals("") ? Convert.ToDouble(montoFinal.Text) : amount;
            string descripcion = descripcionPubTxt.Text;

            FacturasEmitidasDaoImpl facImpl = new FacturasEmitidasDaoImpl();
            customerList = facImpl.darFacturasEmitidas(idUsuario, fechaDesde, fechaHasta, montoTotalini, montoTotalfin, descripcion);

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
            var records = new List<FacturasEmitidas>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Nro Factura";
            dataGridView1.Columns[3].HeaderText = "Fecha Factura";
            dataGridView1.Columns[4].HeaderText = "Monto Total";
            dataGridView1.Columns[5].HeaderText = "Codigo Publicacion";
            
            dataGridView1.Columns[6].HeaderText = "Descripcion Publicacion";
            dataGridView1.Columns[6].Width = 400;
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


    }
}
