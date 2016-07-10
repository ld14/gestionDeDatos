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
//using WindowsFormsApplication1.Entity.Utils;

namespace WindowsFormsApplication1.Calificar
{
    public partial class CalificacionesPage : Form
    {
        public CalificacionesPage()
        {
            InitializeComponent();
        }

        DataSet dset;
        BindingSource bs;

        private void BuscadorPublicacion_Load(object sender, EventArgs e)
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

            IList<SinCalificar> pubList = new List<SinCalificar>();
            Usuario usr = SessionAttribute.user;

            SinCalificarDaoImpl pubDao = new SinCalificarDaoImpl();

            pubList = pubDao.darLista(usr.idUsuario);

            foreach (SinCalificar publ in pubList)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calificar(object sender, EventArgs e)
        {
            int idPublicacion = 0;
            int idCompraUsuario = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                idPublicacion = Convert.ToInt32(row.Cells[0].Value.ToString());
                idCompraUsuario = Convert.ToInt32(row.Cells[1].Value.ToString());
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            

            CalificacionDaoImpl califDao = new CalificacionDaoImpl();
            Calificacion calif = new Calificacion();
            calif.cantEstrellas = Convert.ToInt32(numericUpDown1.Value * 2);
            calif.descripcion = textBox1.Text;
            calif.codigo = califDao.getSecuenciaPubli() + 1;

            califDao.Add(calif);

            CompraUsuarioDaoImpl compraDao = new CompraUsuarioDaoImpl();
            CompraUsuario compra = compraDao.GetByID(idCompraUsuario);

            compra.Calificacion = calif;

            compraDao.Update(compra);

            MessageBox.Show("Calificacion exitosa.\nGracias por utilizar nuestra aplicación de *MercadoEnvio*");
        }

        private void CantidadDeEstrellasText_Click(object sender, EventArgs e)
        {

        }
    }
}
