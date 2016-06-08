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
    public partial class ModificarPublicacionPage : Form
    {
        public ModificarPublicacionPage()
        {
            InitializeComponent();
            


        }

        private void ModificarPublicacionPage_Load(object sender, EventArgs e)
        {
            //PublicacionSubastaDaoImpl sub = new PublicacionSubastaDaoImpl();
            //this.Tag = sub.GetById(352375);

            if (this.Tag != null)
            {
                String tipoPublicacion = null;
                Double? codigo = null;
                String descripcion = null;
                Double? stock = null;
                bool? envioSN = null;
                bool? preguntasSN = null;
                Double precio = 0;
                DateTime? fechaIncioDateTime = null;
                DateTime? fechaVencimientoDateTime = null;
                String nombreUsuario = null;
                Estadopublicacion estadoPublicacion = new Estadopublicacion();
                Rubro rubroPub = new Rubro();
                ICollection<Rubro> rubro = new List<Rubro>();
                Visibilidad visbilidad = new Visibilidad();

                if (this.Tag is PublicacionSubasta) {
                    PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                    //Datos Basicos
                    tipoPublicacion = "Publicación Subasta";
                    codigo = publicacionSubasta.codigoPublicacion;
                    descripcion = publicacionSubasta.descripcion;
                    stock = publicacionSubasta.stock;
                    envioSN = publicacionSubasta.envioSN;   
                    preguntasSN = publicacionSubasta.preguntasSN;
                    precio = publicacionSubasta.valorInicialVenta;
                    fechaIncioDateTime = publicacionSubasta.fechaCreacion;
                    fechaVencimientoDateTime = publicacionSubasta.fechaVencimiento;
                    nombreUsuario = publicacionSubasta.Usuario.userName;
                    //Combo values
                    estadoPublicacion = publicacionSubasta.EstadoPublicacion;
                    rubroPub = publicacionSubasta.RubroLst.First();
                    visbilidad = publicacionSubasta.Visibilidad;

                } if (this.Tag is PublicacionNormal) {
                    PublicacionNormal publicacionDirecta = (PublicacionNormal)this.Tag;
                    tipoPublicacion = "Publicación Compra Inmediata";
                    //Datos Basicos
                    codigo = publicacionDirecta.codigoPublicacion;
                    descripcion = publicacionDirecta.descripcion;
                    stock = publicacionDirecta.stock;
                    envioSN = publicacionDirecta.envioSN;   
                    preguntasSN = publicacionDirecta.preguntasSN;
                    precio = publicacionDirecta.precioPorUnidad;
                    fechaIncioDateTime = publicacionDirecta.fechaCreacion;
                    fechaVencimientoDateTime = publicacionDirecta.fechaVencimiento;
                    nombreUsuario = publicacionDirecta.Usuario.userName;
                    //Combo values
                    estadoPublicacion = publicacionDirecta.EstadoPublicacion;
                    rubroPub = publicacionDirecta.RubroLst.First();
                    visbilidad = publicacionDirecta.Visibilidad;
                }
                
                comboBox1.Text=tipoPublicacion;
                CodigoPublicacionTxt.Text= Convert.ToString(codigo);
                DescripcionTxt.Text = descripcion;
                stockTxt.Text = Convert.ToString(stock);                           
                EnvioCheckBox.Checked = Convert.ToBoolean(envioSN);
                PreguntasCheckBox.Checked = Convert.ToBoolean(preguntasSN);
                PrecioTxt.Text = Convert.ToString(precio);
                UsuarioNombreTxt.Text = nombreUsuario;
                fechaIncioDateTimeTxt.Value = fechaIncioDateTime.Value;
                fechaVencimientoDateTimeTxt.Value = fechaVencimientoDateTime.Value;



                //Seteo del WF del estado Actual a los estados posibles.
                WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
                IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(estadoPublicacion.idEstadoPublicacion);

                EstadoComboBox.DataSource = estadosPublicacionLts;
                EstadoComboBox.DisplayMember = "nombre";
                EstadoComboBox.ValueMember = "idEstadoPublicacion";

                //Coloco el Rubro persistido primero y luego los restantes valores disponibles para ser cambiados
                RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
                rubro.Add(rubroPub);
                IList<Rubro> rubroLts = rubroDaoImpli.darRubroDistintosA(rubro);
                foreach (Rubro rubros in rubroLts) {
                    rubro.Add(rubros);
                }

                RubroComboBox.DataSource = rubro;
                RubroComboBox.DisplayMember = "descripcion";
                RubroComboBox.ValueMember = "idRubro";

                //Coloco el Visibilidad persistido primero y luego los restantes valores disponibles para ser cambiados
                VisibilidadDaoImpl visbDaoImpl = new VisibilidadDaoImpl();

                IList<Visibilidad> visbilidadLts = new List<Visibilidad>();
                visbilidadLts.Add(visbilidad);
                foreach (Visibilidad visbi in visbDaoImpl.darVisibilidadDistintosA(visbilidad)){
                    visbilidadLts.Add(visbi);
                }

                visibilidadComboBox.DataSource = visbilidadLts;
                visibilidadComboBox.DisplayMember = "nombreVisibilidad";
                visibilidadComboBox.ValueMember = "idVisibilidad";

                desahabilitarCamposPorEstado(estadoPublicacion);
            }
        }

        private void desahabilitarCamposPorEstado(Estadopublicacion estadoPublicacion) {
            if (!estadoPublicacion.nombre.Equals("Borrador")) {
                DescripcionTxt.ReadOnly = true;
                stockTxt.ReadOnly = true;
                EnvioCheckBox.Enabled = false;
                PreguntasCheckBox.Enabled = false;
                PrecioTxt.ReadOnly = true;
                fechaIncioDateTimeTxt.Enabled = false;
                fechaVencimientoDateTimeTxt.Enabled = false;
                visibilidadComboBox.Enabled = false;
                RubroComboBox.Enabled = false;
            }
        }

        private void fechaIncioDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String descripcion = DescripcionTxt.Text;
            Double stock = Convert.ToDouble(stockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);

            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);

            DateTime fechaIncioDateTime = DateUtils.convertirStringEnFecha(fechaIncioDateTimeTxt.Value.ToString("dd/MM/yyyy"));
            DateTime fechaVencimientoDateTime = DateUtils.convertirStringEnFecha(fechaVencimientoDateTimeTxt.Value.ToString("dd/MM/yyyy"));
            Estadopublicacion selectedEstadoBox = EstadoComboBox.SelectedItem as Estadopublicacion;
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(selectedEstadoBox.idEstadoPublicacion);

            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;

            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();

            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            if (comboBox1.Text.Equals("Publicación Subasta"))
            {
                PublicacionSubasta nuevaPublicacion = (PublicacionSubasta)this.Tag;

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = 1;
                nuevoItemFactura.Factura = nuevaFactura;
                nuevoItemFactura.monto = selectedVisibilidad.costo;
                lst.Add(nuevoItemFactura);


                nuevaFactura.setFacturaNueva(36625, fehaSistema, selectedVisibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                factDaoImpl.Add(nuevaFactura);

                
                nuevaPublicacion.updatePublicacionSubasta(selectedEstado, selectedVisibilidad, 
                                                       descripcion, fechaIncioDateTime,
                                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, selectedRubro);

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);



                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;

            }
            else
            {
                PublicacionNormal nuevaPublicacion = (PublicacionNormal)this.Tag;
                
                
                    ItemFactura nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = nuevaFactura;
                    nuevoItemFactura.monto = selectedVisibilidad.costo;
                    lst.Add(nuevoItemFactura);


                    nuevaFactura.setFacturaNueva(36625, fehaSistema, selectedVisibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                    FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                    factDaoImpl.Add(nuevaFactura);

                    nuevaPublicacion.updatePublicacionNormal(selectedEstado, selectedVisibilidad, 
                                       descripcion, fechaIncioDateTime,
                                       fechaVencimientoDateTime, stock, preguntasSN, envioSN, precio, selectedRubro);

                PublicacionNormalDaoImpl publicacionSubastaDaoImpl = new PublicacionNormalDaoImpl();
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);

                modificarPublicacionPage.Text = Convert.ToString(nuevaPublicacion.idPublicacion);
                modificarPublicacionPage.Tag = nuevaPublicacion;
            }


            modificarPublicacionPage.MdiParent = this.ParentForm;

            modificarPublicacionPage.Show();
            this.Close();
        }
    }
}
