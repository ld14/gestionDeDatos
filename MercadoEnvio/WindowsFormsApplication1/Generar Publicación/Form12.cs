using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class Form12 : Form
    {
        private const int totalRecords = 43;
        private const int pageSize = 10;
        List<GrillaPublicacion> customerList = new List<GrillaPublicacion>();
        
        public Form12()
        {
            InitializeComponent();

            
            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);

            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();

            IList<PublicacionSubasta> pubSubLts = publicacionSubastaDaoImpl.GetPublicacionByUsuario(usr);
            //pubSubLts.OrderBy(x => x.idPublicacion).ToList(); para ordenar.
            IList<PublicacionNormal> pubNorLts = publicacionNormalDaoImpl.GetPublicacionByUsuario(usr);

            foreach (PublicacionSubasta pubSubasta in pubSubLts)
            {
                    
                    GrillaPublicacion nuevaGrilla = new GrillaPublicacion();
                    nuevaGrilla.tipoPublicacion = "PublicacionSubasta";
                    nuevaGrilla.idPublicacion = pubSubasta.idPublicacion;
                    nuevaGrilla.codigo = pubSubasta.codigoPublicacion;
                    nuevaGrilla.descProducto = pubSubasta.descripcion;
                    nuevaGrilla.estado = "";
                    nuevaGrilla.precio = pubSubasta.valorInicialVenta;
                    nuevaGrilla.rubro = "";
                    this.customerList.Add(nuevaGrilla);
            }
            foreach (PublicacionNormal pubSubasta in pubNorLts)
            {
                GrillaPublicacion nuevaGrilla = new GrillaPublicacion();
                nuevaGrilla.tipoPublicacion = "PublicacionSubasta";
                nuevaGrilla.idPublicacion = pubSubasta.idPublicacion;
                nuevaGrilla.codigo = pubSubasta.codigoPublicacion;
                nuevaGrilla.descProducto = pubSubasta.descripcion;
                nuevaGrilla.estado = "";
                nuevaGrilla.precio = pubSubasta.precioPorUnidad;
                nuevaGrilla.rubro = "";
                this.customerList.Add(nuevaGrilla);            
            }

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            var records = new List<GrillaPublicacion>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;

        }

        class Record
        {
            public int Index { get; set; }
            public string nombre { get; set; }
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }
    }
}
