using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class CompraOfertaPublicacion : Form
    {
        public CompraOfertaPublicacion()
        {
            InitializeComponent();
        }

        private void CompraOfertaPublicacion_Load(object sender, EventArgs e)
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
                Double? valorActual = 0;
                DateTime? fechaIncioDateTime = null;
                DateTime? fechaVencimientoDateTime = null;
                String nombreUsuario = null;
                Estadopublicacion estadoPublicacion = new Estadopublicacion();
                Rubro rubroPub = new Rubro();
                ICollection<Rubro> rubro = new List<Rubro>();
                Visibilidad visbilidad = new Visibilidad();

                if (this.Tag is PublicacionSubasta)
                {
                    PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                    //Datos Basicos
                    tipoPublicacion = "Publicación Subasta";
                    codigo = publicacionSubasta.codigoPublicacion;
                    descripcion = publicacionSubasta.descripcion;
                    stock = publicacionSubasta.stock;
                    envioSN = publicacionSubasta.envioSN;
                    preguntasSN = publicacionSubasta.preguntasSN;
                    precio = publicacionSubasta.valorInicialVenta;
                    valorActual = publicacionSubasta.valorActual;
                    fechaIncioDateTime = publicacionSubasta.fechaCreacion;
                    fechaVencimientoDateTime = publicacionSubasta.fechaVencimiento;
                    nombreUsuario = publicacionSubasta.Usuario.userName;
                    //Combo values
                    estadoPublicacion = publicacionSubasta.EstadoPublicacion;
                    rubroPub = publicacionSubasta.RubroLst.First();
                    visbilidad = publicacionSubasta.Visibilidad;
                    CompraDatos.Visible = false;

                } if (this.Tag is PublicacionNormal)
                {
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

                    SubastaOpciones.Visible = false;
                }

                comboBox1.Text = tipoPublicacion;
                CodigoPublicacionTxt.Text = Convert.ToString(codigo);
                DescripcionTxt.Text = descripcion;
                stockTxt.Text = Convert.ToString(stock);
                PrecioTxt.Text = Convert.ToString(precio);
                fechaVencimientoDateTimeTxt.Value = fechaVencimientoDateTime.Value;

                //Coloco el Rubro persistido primero y luego los restantes valores disponibles para ser cambiados
                RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
                rubro.Add(rubroPub);
                IList<Rubro> rubroLts = rubroDaoImpli.darRubroDistintosA(rubro);
                foreach (Rubro rubros in rubroLts)
                {
                    rubro.Add(rubros);
                }

                RubroComboBox.DataSource = rubro;
                RubroComboBox.DisplayMember = "descripcion";
                RubroComboBox.ValueMember = "idRubro";

                //Compra para Stock de Compra Directa
                List<int> cantidadCompra = new List<int>();
                for (int i = 1; i <= stock; i++) {
                    cantidadCompra.Add(i);
                }
                CantidadComprada.DataSource = cantidadCompra;

                //Datos para Subasta - valorActual
                PrecioActualTxt.Text = Convert.ToString(valorActual);

                desahabilitarCamposPorEstado(estadoPublicacion);
            }

        }

        private void desahabilitarCamposPorEstado(Estadopublicacion estadoPublicacion)
        {
            if (!estadoPublicacion.nombre.Equals("Borrador"))
            {
                DescripcionTxt.ReadOnly = true;
                stockTxt.ReadOnly = true;
                PrecioTxt.ReadOnly = true;
                fechaVencimientoDateTimeTxt.Enabled = false;

                RubroComboBox.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);

            if (comboBox1.Text.Equals("Publicación Subasta")) {
                if (Convert.ToDouble(ValorOferta.Text) < Convert.ToDouble(PrecioActualTxt.Text))  {
                    MessageBox.Show("No puede ofertar un valor menor al Actual");
                    return;
                }

                //Esto hay que cambiarlo por el usuario Logueado
                ClienteDaoImpl usrImpl = new ClienteDaoImpl();
                Cliente usr = usrImpl.GetUsuarioById(1);

                PublicacionSubasta nuevaOfertaPublicacion = (PublicacionSubasta)this.Tag;
                nuevaOfertaPublicacion.valorActual = Convert.ToDouble(ValorOferta.Text);

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Update(nuevaOfertaPublicacion);

                Ofertasubasta nuevaOferta = new Ofertasubasta();
                nuevaOferta.monto = Convert.ToDouble(ValorOferta.Text);
                nuevaOferta.PublicacionSubasta = nuevaOfertaPublicacion;
                nuevaOferta.Usuario = usr;

                
                nuevaOferta.fecha = fehaSistema;
                nuevaOferta.adjudicada = false;

                OfertaSubastaDaoImpl ofertaSuabastaImpl = new OfertaSubastaDaoImpl();
                ofertaSuabastaImpl.Add(nuevaOferta);

                MessageBox.Show("Su Oferta Fue Efectuada");

            } else {
                PublicacionNormalDaoImpl actualizarPublicImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaCompraPublicacion = (PublicacionNormal)this.Tag;
                ComisionesParametrizablesDaoImpl cparImpl = new ComisionesParametrizablesDaoImpl();
                double cantidadVendida = Convert.ToDouble(CantidadComprada.Text);

                if (nuevaCompraPublicacion.stock > Convert.ToDouble(CantidadComprada.Text))
                {
                    //Al total del producto le resto el valor solicitado
                    nuevaCompraPublicacion.stock = nuevaCompraPublicacion.stock - Convert.ToDouble(CantidadComprada.Text);
                } else {
                    //Se vendio el total del producto.
                    nuevaCompraPublicacion.stock = 0;
                    // Paso la compra a estado finalizado, actualizo el Stock y sumo una venta al cliente que publico
                    EstadoPublicacionDaoDaoImpl estadoDaoImpl = new EstadoPublicacionDaoDaoImpl();
                    nuevaCompraPublicacion.EstadoPublicacion = estadoDaoImpl.darEstadoByID(4);
                }    
                    
                    
                nuevaCompraPublicacion.Usuario.cantidadVentas = nuevaCompraPublicacion.Usuario.cantidadVentas + 1;
                actualizarPublicImpl.Update(nuevaCompraPublicacion);


                //Actualizo la factura y cargo los datos del nuevo item
                //TODO: ACA DEBERIA HABER HECHO UNA LISTA Y RECORRERLA CON LOS ITEMS SI QUEDA TIEMPO LO REFACTORIZO
                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                Factura fact = factDaoImpl.darFacturaByPublicacionID(nuevaCompraPublicacion.idPublicacion);

                double? montoAgregado = (cantidadVendida * nuevaCompraPublicacion.Visibilidad.costo) * nuevaCompraPublicacion.Visibilidad.porcentaje;

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = nuevaCompraPublicacion.stock;
                nuevoItemFactura.Factura = fact;
                nuevoItemFactura.monto = montoAgregado;
                fact.ItemFacturasLts.Add(nuevoItemFactura);
                fact.montoTotal = fact.montoTotal + montoAgregado;

                //Costos parametrizable segun compra. env
                if (nuevaCompraPublicacion.envioSN==true) {
                    ComisionesParametrizables comiP = cparImpl.darComisionesParametrizablesByNombreCorto("env");
                    montoAgregado = (cantidadVendida * nuevaCompraPublicacion.precioPorUnidad) * comiP.porcentaje;
                    nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = nuevaCompraPublicacion.stock;
                    nuevoItemFactura.Factura = fact;
                    nuevoItemFactura.monto = montoAgregado;
                    fact.ItemFacturasLts.Add(nuevoItemFactura);
                    fact.montoTotal = fact.montoTotal + montoAgregado;
                }

                ComisionesParametrizables comiProv = cparImpl.darComisionesParametrizablesByNombreCorto("prov");
                montoAgregado = (cantidadVendida * nuevaCompraPublicacion.precioPorUnidad) * comiProv.porcentaje;
                nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = nuevaCompraPublicacion.stock;
                nuevoItemFactura.Factura = fact;
                nuevoItemFactura.monto = montoAgregado;
                fact.ItemFacturasLts.Add(nuevoItemFactura);
                fact.montoTotal = fact.montoTotal + montoAgregado;

                factDaoImpl.Update(fact);

                //Genero la compra Cliente y actualizo sus contadores
                CompraUsuarioDaoImpl compUsrDaoImpl = new CompraUsuarioDaoImpl();

                ClienteDaoImpl usrImpl = new ClienteDaoImpl();
                Cliente usr = usrImpl.GetUsuarioById(1); //Esto se debe cambiar por el cliente loguado.
                usr.comprasEfectuadas = usr.comprasEfectuadas + 1;
                usrImpl.Update(usr);

                CompraUsuario compUsuario = new CompraUsuario();
                compUsuario.constructorCompraUsuario(nuevaCompraPublicacion, usr, Convert.ToInt32(cantidadVendida), compUsrDaoImpl.getProfileIdSequenceByCodigoCalificacion());
                compUsrDaoImpl.Add(compUsuario);
            
            }
        }

    }
}
