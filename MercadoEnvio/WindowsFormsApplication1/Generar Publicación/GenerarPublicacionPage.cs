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

        //            public virtual int idPublicacion { get; set; }
        //public virtual Estadopublicacion EstadoPublicacion { get; set; }
        //public virtual Visibilidad Visibilidad { get; set; }
        //private ICollection<Rubro> rubroLst;
        //public virtual Usuario Usuario { get; set; }
        //public virtual double? codigoPublicacion { get; set; }
        //public virtual string descripcion { get; set; }
        //public virtual DateTime? fechaCreacion { get; set; }
        //public virtual DateTime? fechaVencimiento { get; set; }
        //public virtual double? stock { get; set; }
        //public virtual bool? preguntasSN { get; set; }
        //public virtual bool? envioSN { get; set; }
        //public virtual ISet<Preguntas> Preguntas { get; set; }
            //DescripcionPublicacionTxt
            //StockTxt
            //EnvioCheckBox
            //PreguntasCheckBox
            //PrecioTx
            //FechaIncioDateTime
            //FechaVencimientoDateTime  
            //EstadoComboBox
            //RubroComboBox
            //visibilidadComboBox

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
            double codigoPublicacion = 1111;

            //Esto hay que cambiarlo por el usuario logueado
            UsuarioDaoImpl usrImpl = new UsuarioDaoImpl();
            Usuario usr = usrImpl.GetUsuarioById(1);



            Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;

            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            if(TipoPubliSelect.Text.Equals("Publicación Subasta")){
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                                                       codigoPublicacion, descripcion, fechaIncioDateTime, 
                                                       fechaVencimientoDateTime,stock,preguntasSN,envioSN,precio,valorActual);
                
                
                DatosBasicos dtBasicos = new DatosBasicos();
                dtBasicos.setDatosBasicos("soyYO@hotmail.com", "A", 1, 1, "2", "152", "mata", "cap");

                Cliente cliente = new Cliente("JuanMoreira", "12323", 18801865, 1, "1Pedro Ange222l 2", "Poi", DateTime.Now, dtBasicos);
                PublicacionSubasta nuevaSubasta = new PublicacionSubasta();
                nuevaSubasta.setPublicacionSubasta(selectedEstado, selectedVisibilidad, cliente, 123, "Es lo que hay", DateTime.Now, DateTime.Now, 12, true, true, 15, 20);

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Add(nuevaSubasta);

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
