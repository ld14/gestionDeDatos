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
    public partial class GenerarPublicacionPage : Form
    {

        public GenerarPublicacionPage()
        {
            InitializeComponent();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
            //MessageBox.Show(selectedEstado.nombre, "caption goes here");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);

            String descripcion = DescripcionPublicacionTxt.Text;
            Double stock = Convert.ToDouble(StockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
            Double valorActual = 0;




            DateTime fechaIncioDateTime =   DateUtils.convertirStringEnFecha(FechaIncioDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime fechaVencimientoDateTime = DateUtils.convertirStringEnFecha(FechaVencimientoDateTime.Value.ToString("dd/MM/yyyy"));



            //Esto debe ser autoIncrementable
            double codigoPublicacion = 444446;

            //Esto hay que cambiarlo por el usuario logueado



            Estadopublicacion selectedEstadoBox = EstadoComboBox.SelectedItem as Estadopublicacion;
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(selectedEstadoBox.idEstadoPublicacion);

            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;

            //ESTO HAY Q CAMBIARLO POR EL USUARIO LOGUEADO
            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);

            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            if(TipoPubliSelect.Text.Equals("Publicación Subasta")){

                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                                                       codigoPublicacion, descripcion, fechaIncioDateTime,
                                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, valorActual, selectedRubro);

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

                if (selectedEstado.nombre.Equals("Activa"))
                {
                    ItemFactura nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = nuevaFactura;
                    nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                    lst.Add(nuevoItemFactura);


                    nuevaFactura.setFacturaNueva(36626, fehaSistema, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                    FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                    factDaoImpl.Add(nuevaFactura);
                }


                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;

            }else{
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.setPublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                                       codigoPublicacion, descripcion, fechaIncioDateTime,
                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, selectedRubro);

                PublicacionNormalDaoImpl publicacionSubastaDaoImpl = new PublicacionNormalDaoImpl();
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

                if (selectedEstado.nombre.Equals("Activa"))
                {
                    ItemFactura nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = nuevaFactura;
                    nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                    lst.Add(nuevoItemFactura);


                    nuevaFactura.setFacturaNueva(36661, fehaSistema, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                    FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                    factDaoImpl.Add(nuevaFactura);
                }

                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;
            }


            modificarPublicacionPage.MdiParent = this.ParentForm;
            
            modificarPublicacionPage.Show();
            this.Close();
        }

        private void RubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerarPublicacionPage_Load(object sender, EventArgs e)
        {

            //----------------------Campos seccion Estados-------------------------------------------//
            WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
            IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(1);


            //Setup data binding
            EstadoComboBox.DataSource = estadosPublicacionLts;
            EstadoComboBox.DisplayMember = "nombre";
            EstadoComboBox.ValueMember = "idEstadoPublicacion";

            //----------------------Campos seccion Rubro ----------------------------------------------//
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();

            RubroComboBox.DataSource = rubroLts;
            RubroComboBox.DisplayMember = "descripcion";
            RubroComboBox.ValueMember = "idRubro";



            //----------------------Campos seccion Visibilidad --------------------------------------//
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();

            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "idVisibilidad";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
