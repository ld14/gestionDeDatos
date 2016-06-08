using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class BusquedaPublicacion : Form
    {
        public static int totalRecords = 0;
        private const int pageSize = 10;
        List<GrillaPublicacion> customerList = new List<GrillaPublicacion>();
        

        public static int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public BusquedaPublicacion()
        {
            InitializeComponent();
        }

        private void BusquedaPublicacion_Load(object sender, EventArgs e)
        {
            //----------------------Campos seccion Rubro ----------------------------------------------//
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();

            RubroCheckedList.DataSource = rubroLts;
            RubroCheckedList.DisplayMember = "descripcion";
            RubroCheckedList.ValueMember = "idRubro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<string> selectedRubrosLst = new List<string>();

            foreach(Rubro itemChecked in RubroCheckedList.CheckedItems){
                selectedRubrosLst.Add(itemChecked.descripcion);
            }

            //TODO: CAMBIAR ESTO POR EL USUARIO LOGUEADO.
            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);


            BusquedaDePublicacionDaoImpl busquedaDePublicacionDaoImpl = new BusquedaDePublicacionDaoImpl();
            IList<BusquedaDePublicacion> busquedaDePublicacionLts = busquedaDePublicacionDaoImpl.darListaFiltradaPorRubroDescripcion(selectedRubrosLst, descripcionTxt.Text, usr.idUsuario);

            foreach (BusquedaDePublicacion publicacion in busquedaDePublicacionLts)
            {

                GrillaPublicacion nuevaGrilla = new GrillaPublicacion();
                nuevaGrilla.tipoPublicacion = publicacion.tipoPublicacion;
                nuevaGrilla.idPublicacion = publicacion.idPublicacion;
                nuevaGrilla.codigo = publicacion.codigoPublicacion;
                nuevaGrilla.descProducto = publicacion.descripcion;
                nuevaGrilla.precio = publicacion.precio;
                //nuevaGrilla.fechaInicio = publicacion.f
                nuevaGrilla.fechaVencimiento = publicacion.fechaVencimiento;
                //nuevaGrilla.estado = publicacion.e
                nuevaGrilla.rubro = publicacion.desRubro;
                this.customerList.Add(nuevaGrilla);
            }

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
            var records = new List<GrillaPublicacion>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;
           
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
            dataGridView1.Columns[7].HeaderText = "Fin de Venta"; 


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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompraOfertaPublicacion modificarPublicacionPage = new CompraOfertaPublicacion();
            string tipoPublicacion = "";
            string idPublicacion = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tipoPublicacion = row.Cells[2].Value.ToString();
                idPublicacion = row.Cells[0].Value.ToString();
            }

            if (tipoPublicacion.Equals("Subasta"))
            {
                PublicacionSubastaDaoImpl pubDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta publi = pubDaoImpl.GetById(Convert.ToInt32(idPublicacion));
                modificarPublicacionPage.Text = Convert.ToString(publi.idPublicacion);
                modificarPublicacionPage.Tag = publi;
            }
            else
            {
                PublicacionNormalDaoImpl pubDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal publi = pubDaoImpl.GetById(Convert.ToInt32(idPublicacion));
                modificarPublicacionPage.Text = Convert.ToString(publi.idPublicacion);
                modificarPublicacionPage.Tag = publi;
            }

            modificarPublicacionPage.MdiParent = this.ParentForm;

            modificarPublicacionPage.Show();
            this.Close();

        }


    }
}
