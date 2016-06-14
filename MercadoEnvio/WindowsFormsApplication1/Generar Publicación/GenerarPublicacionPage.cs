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
    public partial class GenerarPublicacionPage : Form
    {

        public GenerarPublicacionPage()
        {
            InitializeComponent();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
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



            //Esto hay que cambiarlo por el usuario logueado



            //Estadopublicacion selectedEstadoBox = EstadoComboBox.SelectedItem as Estadopublicacion;
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(1);

            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;

            //ESTO HAY Q CAMBIARLO POR EL USUARIO LOGUEADO
            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);

            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            if(TipoPubliSelect.Text.Equals("Subasta")){
                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                                                       publicacionSubastaDaoImpl.getProfileIdSequence(), descripcion, fechaIncioDateTime,
                                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, valorActual, selectedRubro);

                
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

                if (selectedEstado.nombre.Equals("Activa"))
                {
                    ItemFactura nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = nuevaFactura;
                    nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                    lst.Add(nuevoItemFactura);


                    nuevaFactura.setFacturaNueva(fehaSistema, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                    FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                    factDaoImpl.Add(nuevaFactura);
                }


                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;

            }else{
                PublicacionNormalDaoImpl publicacionSubastaDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.setPublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                                       publicacionSubastaDaoImpl.getProfileIdSequence(), descripcion, fechaIncioDateTime,
                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, selectedRubro);

                
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

                if (selectedEstado.nombre.Equals("Activa"))
                {
                    ItemFactura nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = nuevaFactura;
                    nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                    lst.Add(nuevoItemFactura);


                    nuevaFactura.setFacturaNueva(fehaSistema, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

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
            var asd = (Visibilidad)visibilidadComboBox.SelectedItem;
            costoValue.Text = "$" + Convert.ToString(asd.costo);
            porcentajeValue.Text = Convert.ToString(asd.porcentaje * 100) + "%";
        }

        private void GenerarPublicacionPage_Load(object sender, EventArgs e)
        {

            Usuario user = SessionAttribute.user;
            ICollection<Rol> ba = user.RolesLst;

            //----------------------Campos seccion Estados-------------------------------------------//
            /*
            WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
            IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(1);


            //Setup data binding
            EstadoComboBox.DataSource = estadosPublicacionLts;
            EstadoComboBox.DisplayMember = "nombre";
            EstadoComboBox.ValueMember = "idEstadoPublicacion";
            */
            //----------------------Campos seccion Rubro ----------------------------------------------//
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();

            RubroComboBox.DataSource = rubroLts;
            RubroComboBox.DisplayMember = "descripcion";
            RubroComboBox.ValueMember = "idRubro";

            PublicacionSubastaDaoImpl publicacionDaoImpl = new PublicacionSubastaDaoImpl();
            textBox4.Text = Convert.ToString(publicacionDaoImpl.getProfileIdSequence());

            //----------------------Campos seccion Visibilidad --------------------------------------//
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();

            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "idVisibilidad";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }


        private void groupBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var asd = (String)TipoPubliSelect.SelectedItem;
            if (asd == "Compra Inmediata")
            {
                label2.Text = "Precio por Unidad";
                label10.Visible = true;
                StockTxt.Visible = true;
            }
            if (asd == "Subasta")
            {
                label2.Text = "Precio Inicial";
                label10.Visible = false;
                StockTxt.Visible = false;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EnvioCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
