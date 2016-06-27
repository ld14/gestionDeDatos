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
            if (this.Tag is PublicacionSubasta)
            {
                    PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                    
                    tipoPubBox.Text = "Subasta";
                    codigoPubBox.Text = Convert.ToString(publicacionSubasta.codigoPublicacion);
                    DescripcionTxt.Text = publicacionSubasta.descripcion;
                    stockTxt.Text = Convert.ToString(publicacionSubasta.stock);
                    envioCheck.Enabled = publicacionSubasta.envioSN;
                    PrecioTxt.Text = '$' + Convert.ToString(publicacionSubasta.valorInicialVenta);
                    precioLabel.Text = "Precio Inicial:";
                    ofertaValue.Visible = true;
                    ofertaLabel.Visible = true;
                    cant_oferta.Enabled = false;
                    ofertaValue.Value = Convert.ToDecimal(publicacionSubasta.valorActual) + 1;
                    ofertaValue.Minimum = ofertaValue.Value;
                    fechaVencimientoDateTimeTxt.Value = publicacionSubasta.fechaVencimiento;
                    vendedorBox.Text = publicacionSubasta.Usuario.userName;

                    if (publicacionSubasta.EstadoPublicacion.nombre.Equals("Pausada"))
                    {
                        estadoPausa.Visible = true;
                        cant_oferta.Enabled = false;
                        ofertaValue.Enabled = false;
                        envioCheck.Enabled = false;
                        comprarButton.Enabled = false;
                    }
                    rubroBox.Text = publicacionSubasta.RubroLst.First().descripcion;
                    //preguntarButton.Enabled = publicacionSubasta.preguntasSN;
                    //visbilidad = publicacionSubasta.Visibilidad;
                    //CompraDatos.Visible = false;
            }
                
            if (this.Tag is PublicacionNormal)
            {
                    PublicacionNormal publicacionDirecta = (PublicacionNormal)this.Tag;
                    tipoPubBox.Text = "Compra Inmediata";
                    codigoPubBox.Text = Convert.ToString(publicacionDirecta.codigoPublicacion);
                    DescripcionTxt.Text = publicacionDirecta.descripcion;
                    stockTxt.Text = Convert.ToString(publicacionDirecta.stock);
                    envioCheck.Enabled = publicacionDirecta.envioSN;
                    PrecioTxt.Text = '$' + Convert.ToString(publicacionDirecta.precioPorUnidad);
                    precioLabel.Text = "Precio Unidad:";
                    compraLabel.Text = "Unidades";
                    cant_oferta.Maximum = publicacionDirecta.stock;
                    ofertaValue.Visible = false;
                    ofertaLabel.Visible = false;
                    fechaVencimientoDateTimeTxt.Value = publicacionDirecta.fechaVencimiento;
                    vendedorBox.Text = publicacionDirecta.Usuario.userName;

                    if (publicacionDirecta.EstadoPublicacion.nombre.Equals("Pausada"))
                    {
                        estadoPausa.Visible = true;
                        cant_oferta.Enabled = false;
                        envioCheck.Enabled = false;
                        comprarButton.Enabled = false;
                    }
                    rubroBox.Text = publicacionDirecta.RubroLst.First().descripcion;
                    //preguntarButton.Enabled = publicacionSubasta.preguntasSN;
                    //visbilidad = publicacionSubasta.Visibilidad;
                    //CompraDatos.Visible = false;
            }
        }

        private void desahabilitarCamposPorEstado(Estadopublicacion estadoPublicacion)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*
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


                nuevaCompraPublicacion.Usuario.cantidadVentas = nuevaCompraPublicacion.Usuario.cantidadVentas + Convert.ToInt32(cantidadVendida);
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
         */
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

    }
}
