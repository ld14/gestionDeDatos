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
    public partial class ModificarPublicacionPage : Form
    {
        public ModificarPublicacionPage()
        {
            InitializeComponent();
            
        }

        private void ModificarPublicacionPage_Load(object sender, EventArgs e)
        {
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

                infoBox.Visible = false;
                labelInfoA.Visible = false;
                labelInfoB.Visible = false;

                if (this.Tag is PublicacionSubasta)
                {
                    PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                    //Datos Basicos
                    tipoPublicacion = "Subasta";
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

                    if (publicacionSubasta.EstadoPublicacion.idEstadoPublicacion != 1)
                    {
                        OfertaSubastaDaoImpl oDao = new OfertaSubastaDaoImpl();
                        IList<Ofertasubasta> ofertas = oDao.GetByPublicacion(publicacionSubasta.idPublicacion);
                        infoBox.Visible = true;
                        labelInfoB.Visible = true;

                        if (ofertas.Count == 0)
                        {
                            labelInfoB.Text += " Ninguna";
                        }
                        else
                        {
                            labelInfoB.Text += " $" + Convert.ToString(publicacionSubasta.valorActual);
                        }
                    }

                }

                if (this.Tag is PublicacionNormal)
                {
                    PublicacionNormal publicacionDirecta = (PublicacionNormal)this.Tag;
                    tipoPublicacion = "Compra Inmediata";
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

                    if (publicacionDirecta.EstadoPublicacion.idEstadoPublicacion != 1)
                    {
                        CompraUsuarioDaoImpl cDao = new CompraUsuarioDaoImpl();
                        IList<CompraUsuario> compras = cDao.GetByPublicacion(publicacionDirecta.idPublicacion);
                        infoBox.Visible = true;
                        labelInfoA.Visible = true;
                        labelInfoA.Text += Convert.ToString(compras.Count);
                    }
                }
                
                comboBox1.Text=tipoPublicacion;
                CodigoPublicacionTxt.Text= Convert.ToString(codigo);
                DescripcionTxt.Text = descripcion;
                stockTxt.Text = Convert.ToString(stock);                           
                EnvioCheckBox.Checked = Convert.ToBoolean(envioSN);
                PreguntasCheckBox.Checked = Convert.ToBoolean(preguntasSN);
                PrecioTxt.Text = Convert.ToString(precio);
                FechaIncioDateTimeTxt.Value = fechaIncioDateTime.Value;
                FechaVencimientoDateTimeTxt.Value = fechaVencimientoDateTime.Value;



                //Seteo del WF del estado Actual a los estados posibles.
                WorkflowEstadosDaoImpl workflowEstadosDaoImpl = new WorkflowEstadosDaoImpl();
                IList<Estadopublicacion> estadosPublicacionLts = workflowEstadosDaoImpl.darWorkflowEstadosActivoByEstadoActual(estadoPublicacion.idEstadoPublicacion);

                /*
                EstadoComboBox.DataSource = estadosPublicacionLts;
                EstadoComboBox.DisplayMember = "nombre";
                EstadoComboBox.ValueMember = "idEstadoPublicacion";
                */

                botonFinalizar.Visible = false;
                botonGuardar.Visible = false;
                botonPausar.Visible = false;
                botonPublicarN.Visible = false;
                botonPublicarP.Visible = false;

                switch (estadoPublicacion.idEstadoPublicacion)
                {
                    case 1:
                        botonGuardar.Visible = true;
                        botonPublicarN.Visible = true;
                        break;
                    case 2:
                        botonPausar.Visible = true;
                        botonFinalizar.Visible = true;
                        break;
                    case 3:
                        botonPublicarP.Visible = true;
                        break;
                }


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

        private void desahabilitarCamposPorEstado(Estadopublicacion estadoPublicacion)
        {
            if (!estadoPublicacion.nombre.Equals("Borrador"))
            {
                EnvioCheckBox.Enabled = false;
                DescripcionTxt.Enabled = false;
                PreguntasCheckBox.Enabled = false;
                PrecioTxt.Enabled = false;
                stockTxt.Enabled = false;
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

        private void guardar_Click(object sender, EventArgs e)
        {
            int stock = 1;
            String descripcion = DescripcionTxt.Text;
            if (comboBox1.Text != "Subasta")
                stock = Convert.ToInt32(stockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
            DateTime fechaIncioDateTime = FechaIncioDateTimeTxt.Value;
            DateTime fechaVencimientoDateTime = FechaVencimientoDateTimeTxt.Value;
            int codigo = Convert.ToInt32(CodigoPublicacionTxt.Text);
            
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(1);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;

            if (comboBox1.Text.Equals("Subasta"))
            {
                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.updatePublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock, preguntasSN, envioSN,
                        precio, precio, selectedRubro, codigo);
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);
            }

            if (comboBox1.Text.Equals("Compra Inmediata"))
            {
                PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.updatePublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock,
                        preguntasSN, envioSN, precio, selectedRubro, codigo);
                publicacionNormalDaoImpl.Update(nuevaPublicacion);
            }

            MessageBox.Show("Se ha actualizado satisfactoriamente su publicación.");
            this.Close();
        }

        private void publicar_Click(object sender, EventArgs e)
        {
            int stock = 1;
            String descripcion = DescripcionTxt.Text;
            if (comboBox1.Text != "Subasta")
                stock = Convert.ToInt32(stockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
            DateTime fechaIncioDateTime = FechaIncioDateTimeTxt.Value;
            DateTime fechaVencimientoDateTime = FechaVencimientoDateTimeTxt.Value;
            int codigo = Convert.ToInt32(CodigoPublicacionTxt.Text);

            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(2);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;
            
            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            if (comboBox1.Text.Equals("Subasta"))
            {
                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.updatePublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock, preguntasSN, envioSN,
                        precio, precio, selectedRubro, codigo);
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = 1;
                nuevoItemFactura.Factura = nuevaFactura;
                nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                lst.Add(nuevoItemFactura);
                nuevaFactura.setFacturaNueva(fechaIncioDateTime, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                factDaoImpl.Add(nuevaFactura);
            }

            if (comboBox1.Text.Equals("Compra Inmediata"))
            {
                PublicacionNormalDaoImpl publicacionSubastaDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.updatePublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock,
                        preguntasSN, envioSN, precio, selectedRubro, codigo);
                publicacionSubastaDaoImpl.Update(nuevaPublicacion);

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = 1;
                nuevoItemFactura.Factura = nuevaFactura;
                nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                lst.Add(nuevoItemFactura);
                nuevaFactura.setFacturaNueva(fechaIncioDateTime, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                factDaoImpl.Add(nuevaFactura);
            }

            MessageBox.Show("Publicación exitosa.");
            this.Close();
        }



        private void visibilidadChanged(object sender, EventArgs e)
        {
            var asd = (Visibilidad)visibilidadComboBox.SelectedItem;
            costoValue.Text = "$" + Convert.ToString(asd.costo);
            porcentajeValue.Text = Convert.ToString(asd.porcentaje * 100) + "%";
        }

        private void tipoPubliChanged(object sender, EventArgs e)
        {
            var asd = comboBox1.Text;
            if (asd == "Compra Inmediata")
            {
                label2.Text = "Precio por Unidad";
                label10.Visible = true;
                stockTxt.Visible = true;
            }
            if (asd == "Subasta")
            {
                label2.Text = "Precio Inicial";
                label10.Visible = false;
                stockTxt.Visible = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
