using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;

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
            selectorUsuarios userVacio = new selectorUsuarios();
            List<selectorUsuarios> selectorUsuariosLts = new List<selectorUsuarios>();
            
            EmpresaDaoImpl empImpl = new EmpresaDaoImpl();
            ClienteDaoImpl cilImpl = new ClienteDaoImpl();

            foreach (Cliente clie in cilImpl.getAllClienteActivos())
            {
                selectorUsuarios user = new selectorUsuarios();
                user.descripcion = clie.userName;
                user.idUsuario = clie.idUsuario;
                selectorUsuariosLts.Add(user);
            }
            foreach(Empresa emp in empImpl.getAllEmpresaActivas())
            {
                selectorUsuarios user = new selectorUsuarios();
                user.descripcion = emp.userName;
                user.idUsuario = emp.idUsuario;
                selectorUsuariosLts.Add(user);
            }

            destinatarioSelect.DataSource = selectorUsuariosLts;
            destinatarioSelect.DisplayMember = "descripcion";
            destinatarioSelect.ValueMember = "idUsuario";

            if (!SessionAttribute.user.userName.Equals("admin"))
            {
                destinatarioSelect.Text = SessionAttribute.user.userName;
                destinatarioSelect.Enabled = false;
            }
        }

        public class selectorUsuarios{
            public virtual int idUsuario { get; set; }
            public virtual String descripcion { get; set; }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            int idUsuario = (destinatarioSelect.SelectedItem as selectorUsuarios).idUsuario;
            double? nulo = null;

            DateTime fechaDesde = DateUtils.convertirStringEnFecha(FechaDesde.Value.ToString("dd/MM/yyyy"));
            DateTime fechaHasta = DateUtils.convertirStringEnFecha(FechaHasta.Value.ToString("dd/MM/yyyy"));
            double? montoTotalini = !montoInicial.Text.Equals("") ? Convert.ToDouble(montoInicial.Text) : nulo;
            double? montoTotalfin = !montoFinal.Text.Equals("") ? Convert.ToDouble(montoFinal.Text) : nulo;
            string descripcion = descripcionPubTxt.Text;

            FacturasEmitidasDaoImpl facImpl = new FacturasEmitidasDaoImpl();
            customerList = facImpl.darFacturasEmitidas(idUsuario, fechaDesde, fechaHasta, descripcion);
            if (montoTotalini != null)
                customerList = customerList.Where(x => Convert.ToDouble(x.montoTotal) >= montoTotalini).ToList();
            if (montoTotalfin != null)
                customerList = customerList.Where(x => Convert.ToDouble(x.montoTotal) <= montoTotalfin).ToList();

            TotalRecords = this.customerList.Count;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int)bindingSource1.Current;
            var records = new List<FacturasEmitidas>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString()[0] != '$')
                    dataGridView1.Rows[i].Cells[4].Value = "$" + customerList[i + offset].montoTotal;
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Nro Factura";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].HeaderText = "Fecha Factura";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].HeaderText = "Monto Total";
            dataGridView1.Columns[4].Width = 94;
            dataGridView1.Columns[5].HeaderText = "Código Publicación";
            dataGridView1.Columns[5].Width = 76;
            dataGridView1.Columns[6].HeaderText = "Descripción Publicación";
            dataGridView1.Columns[6].Width = 370;
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
