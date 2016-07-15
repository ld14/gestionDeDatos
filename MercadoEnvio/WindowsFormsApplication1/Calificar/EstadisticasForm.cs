using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.DAO;
using WindowsFormsApplication1.Entity.Utils;

namespace WindowsFormsApplication1.Calificar
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
        }

        DataSet dset;
        BindingSource bs;

        public void EstadisticasForm_load(object sender, EventArgs e)
        {
            //Cargar formulario de últimas 5 calificaciones
            cargarFormulario5Calificaciones();
            //Cargar formulario de cantidad de compras por calificacion
            cargarFormularioCantidadesCompraXCalificaciones();
        }

        private void cargarFormulario5Calificaciones()
        {

            dset = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("tipoPublicacion", typeof(string));
            dt.Columns.Add("idCompraUsuario", typeof(int));
            dt.Columns.Add("codigo", typeof(double));
            dt.Columns.Add("descProducto", typeof(string));
            dt.Columns.Add("precio", typeof(double));
            dt.Columns.Add("cantidad", typeof(int));
            dt.Columns.Add("vendedor", typeof(string));
            dt.Columns.Add("fechaCompra", typeof(DateTime));
            dt.Columns.Add("idUsuario", typeof(int));

            IList<CalifUlt5Calificaciones> pubList = new List<CalifUlt5Calificaciones>();
            Usuario usr = SessionAttribute.user;

            SinCalificarDaoImpl pubDao = new SinCalificarDaoImpl();

            pubList = pubDao.obtUlt5Calificaciones(usr.idUsuario);

            foreach (CalifUlt5Calificaciones publ in pubList)
            {
                dt.Rows.Add(publ.tipoPublicacion, publ.idCompraUsuario, publ.codigo, publ.descProducto, publ.precio, publ.cantidad, publ.vendedor, publ.fechaCompra, publ.idUsuario);
            }

            dset.Tables.Add(dt);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bs.Sort = "codigo";
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
        }

        private void cargarFormularioCantidadesCompraXCalificaciones()
        {
            dset = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("cantEstrellas", typeof(int));
            dt.Columns.Add("cantEstrellasCount", typeof(int));

            IList<CalifCompraXCalif> pubList = new List<CalifCompraXCalif>();
            Usuario usr = SessionAttribute.user;

            SinCalificarDaoImpl pubDao = new SinCalificarDaoImpl();

            pubList = pubDao.obtCompraXCalif(usr.idUsuario);

            foreach (CalifCompraXCalif publ in pubList)
            {
                dt.Rows.Add(publ.cantEstrellas, publ.cantEstrellasCount);
            }

            dset.Tables.Add(dt);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bs.Sort = "cantEstrellas";
            bindingNavigator2.BindingSource = bs;
            dataGridView2.DataSource = bs;
        }
    }
}
