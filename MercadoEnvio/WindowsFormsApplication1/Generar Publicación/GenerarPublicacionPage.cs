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

            String descripcion = DescripcionPublicacionTxt.Text;
            Double stock = Convert.ToDouble(StockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
            Double valorActual = 0;

            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);


            DateTime fechaIncioDateTime =   DateUtils.convertirStringEnFecha(FechaIncioDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime fechaVencimientoDateTime = DateUtils.convertirStringEnFecha(FechaVencimientoDateTime.Value.ToString("dd/MM/yyyy"));



            //Esto debe ser autoIncrementable
            double codigoPublicacion = 11211;

            //Esto hay que cambiarlo por el usuario logueado



            Estadopublicacion selectedEstadoBox = EstadoComboBox.SelectedItem as Estadopublicacion;
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(selectedEstadoBox.idEstadoPublicacion);

            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;

            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);

            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            if(TipoPubliSelect.Text.Equals("Publicación Subasta")){
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                                                       codigoPublicacion, descripcion, fechaIncioDateTime, 
                                                       fechaVencimientoDateTime,stock,preguntasSN,envioSN,precio,valorActual);

                /*estadopublicacion estadopublicacion = new estadopublicacion();
                estadopublicacion.nombre = "public";
                estadopublicacion.nombrecorto = "pub";

                visibilidad c = new visibilidad();
                c.nombrevisibilidad = "plata";
                c.costo = 20;

                datosbasicos dtbasicos = new datosbasicos();
                dtbasicos.setdatosbasicos("so112211ym1222ayo4@hotmail.com", "2a1221", 1, 1, "2", "152", "mata", "cap");

                cliente cliente = new cliente("juanmor21121e11222112ira4", "1221213111411122323", 41112222111865, 1, "1pedro ange222l 2", "poi", datetime.now, dtbasicos);
                publicacionsubasta nuevasubasta = new publicacionsubasta();
                nuevasubasta.setpublicacionsubasta(estadopublicacion, selectedvisibilidad, usr, codigopublicacion, descripcion, fechainciodatetime, fechavencimientodatetime, stock, preguntassn, enviosn, precio, valoractual);
                */

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);

                

                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;

            }else{
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.setPublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                                       codigoPublicacion, descripcion, fechaIncioDateTime,
                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio);

                
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

            WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
            IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(1);

            //----------------------Campos seccion Estados-------------------------------------------//
            // NOTA: ESTO HAY QUE REFACTORIZARLO POR EL WF DE ESTADOS.
            //EstadoPublicacionDaoDaoImpl estadosDao = new EstadoPublicacionDaoDaoImpl();
            
            //IList<Estadopublicacion> estadosPublicacionLts = estadosDao.darEstados();

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
    }
}
