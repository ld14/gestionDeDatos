using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class BuscadorPublicacion : Form
    {
        public BuscadorPublicacion()
        {
            InitializeComponent();
        }

        DataSet dset;
        BindingSource bs;

        private void BuscadorPublicacion_Load(object sender, EventArgs e)        {
            dset = new DataSet();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("tipoPublicacion", typeof(string));
            dt.Columns.Add("idPublicacion", typeof(int));
            dt.Columns.Add("codigo", typeof(double));
            dt.Columns.Add("descProducto", typeof(string));
            dt.Columns.Add("precio", typeof(double));
            dt.Columns.Add("estado", typeof(string));
            dt.Columns.Add("rubro", typeof(string));
            dt.Columns.Add("fechaInicio", typeof(DateTime));
            dt.Columns.Add("fechaVencimiento", typeof(DateTime));
            

            List<GrillaPublicacion> customerList = new List<GrillaPublicacion>();
            //UsuarioDaoImpl usrImpl = new UsuarioDaoImpl();
            Usuario usr = SessionAttribute.user;

            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();

            IList<PublicacionSubasta> pubSubLts = publicacionSubastaDaoImpl.GetPublicacionByUsuario(usr);
            //pubSubLts.OrderBy(x => x.idPublicacion).ToList(); para ordenar.
            IList<PublicacionNormal> pubNorLts = publicacionNormalDaoImpl.GetPublicacionByUsuario(usr);

            foreach (PublicacionSubasta pubSubasta in pubSubLts) {
                dt.Rows.Add("Subasta", pubSubasta.idPublicacion, pubSubasta.codigoPublicacion, pubSubasta.descripcion, pubSubasta.valorInicialVenta, pubSubasta.EstadoPublicacion.nombre, "", pubSubasta.fechaCreacion, pubSubasta.fechaVencimiento);
            }
            foreach (PublicacionNormal pubNormal in pubNorLts)
            {
                dt.Rows.Add("Compra Inmediata", pubNormal.idPublicacion, pubNormal.codigoPublicacion, pubNormal.descripcion, pubNormal.precioPorUnidad, pubNormal.EstadoPublicacion.nombre, "", pubNormal.fechaCreacion, pubNormal.fechaVencimiento);
            }
            
            dset.Tables.Add(dt);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bs.Sort = "codigo";
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
            

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            string tipoPublicacion = "";
            string idPublicacion = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tipoPublicacion = row.Cells[2].Value.ToString();
                idPublicacion = row.Cells[0].Value.ToString();
            }

            if (tipoPublicacion.Equals("Subasta")) {
                PublicacionSubastaDaoImpl pubDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta publi = pubDaoImpl.GetById(Convert.ToInt32(idPublicacion));
                modificarPublicacionPage.Text = Convert.ToString(publi.idPublicacion);
                modificarPublicacionPage.Tag = publi;
            } else {
                PublicacionNormalDaoImpl pubDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal publi = pubDaoImpl.GetById(Convert.ToInt32(idPublicacion));
                modificarPublicacionPage.Text = Convert.ToString(publi.idPublicacion);
                modificarPublicacionPage.Tag = publi;
            }

            modificarPublicacionPage.MdiParent = this.ParentForm;

            modificarPublicacionPage.Show();
            this.Close();
        }


        public DataSet CreateDataSet<T>(List<T> list)
        {
            //list is nothing or has nothing, return nothing (or add exception handling)
            if (list == null || list.Count == 0) { return null; }

            //get the type of the first obj in the list
            var obj = list[0].GetType();

            //now grab all properties
            var properties = obj.GetProperties();

            //make sure the obj has properties, return nothing (or add exception handling)
            if (properties.Length == 0) { return null; }

            //it does so create the dataset and table
            var dataSet = new DataSet();
            var dataTable = new DataTable();

            //now build the columns from the properties
            var columns = new DataColumn[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                //columns[i] = new DataColumn(properties[i].Name, properties[i].PropertyType != null ?? properties[i].PropertyType : "");
            }

            //add columns to table
            dataTable.Columns.AddRange(columns);

            //now add the list values to the table
            foreach (var item in list)
            {
                //create a new row from table
                var dataRow = dataTable.NewRow();

                //now we have to iterate thru each property of the item and retrieve it's value for the corresponding row's cell
                var itemProperties = item.GetType().GetProperties();

                for (int i = 0; i < itemProperties.Length; i++)
                {
                    dataRow[i] = itemProperties[i].GetValue(item, null);
                }

                //now add the populated row to the table
                dataTable.Rows.Add(dataRow);
            }

            //add table to dataset
            dataSet.Tables.Add(dataTable);

            //return dataset
            return dataSet;
        }
    }
}
