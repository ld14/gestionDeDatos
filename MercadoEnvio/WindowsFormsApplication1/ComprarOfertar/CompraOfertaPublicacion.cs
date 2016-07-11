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
            Estadopublicacion estado = null;

            if (this.Tag is PublicacionSubasta) //Cargar formulario para subasta
            {
                PublicacionSubasta publicacionSubasta = (PublicacionSubasta)this.Tag;
                estado = publicacionSubasta.EstadoPublicacion;
    
                tipoTextBox.Text = "Subasta";
                codigoTextBox.Text = Convert.ToString(publicacionSubasta.codigoPublicacion);
                descripcionTextBox.Text = publicacionSubasta.descripcion;
                stockTextBox.Text = Convert.ToString(publicacionSubasta.stock);
                envioCheckBox.Enabled = publicacionSubasta.envioSN;
                precioTextBox.Text = '$' + Convert.ToString(publicacionSubasta.valorInicialVenta);
                precioLabel.Text = "Precio Inicial:";
                ofertarNumeric.Visible = true;
                ofertaLabel.Visible = true;
                cant_ofertaNumeric.Enabled = false;
                vencimientoDateTime.Value = publicacionSubasta.fechaVencimiento;
                vendedorTextBox.Text = publicacionSubasta.Usuario.userName;

                Double cantEstrellas = publicacionSubasta.Usuario.cantidadEstrellas;
                Double cantVentas = publicacionSubasta.Usuario.cantidadVentas;
                reputacionTextBox.Text = String.Format("{0:N2}", cantEstrellas / cantVentas / 2);
                ofertarNumeric.Value = Convert.ToDecimal(publicacionSubasta.valorActual);
                ofertarNumeric.Minimum = ofertarNumeric.Value;
                rubroTextBox.Text = publicacionSubasta.RubroLst.First().descripcion;

                //Si hay alguna oferta te obligo a que ofertes como minimo un peso mas que la mejor oferta
                OfertaSubastaDaoImpl ofertaDao = new OfertaSubastaDaoImpl();
                IList<Ofertasubasta> ofertas = ofertaDao.GetByPublicacion(publicacionSubasta.idPublicacion);
                if (ofertas.Count > 0)
                {
                    cant_ofertaNumeric.Value = Convert.ToDecimal(publicacionSubasta.valorActual);
                    ofertarNumeric.Value++;
                    ofertarNumeric.Minimum++;
                }
            }  

            if (this.Tag is PublicacionNormal) //Cargar formulario para compra inmediata
            {
                PublicacionNormal publicacionDirecta = (PublicacionNormal)this.Tag;
                estado = publicacionDirecta.EstadoPublicacion;
                
                tipoTextBox.Text = "Compra Inmediata";
                codigoTextBox.Text = Convert.ToString(publicacionDirecta.codigoPublicacion);
                descripcionTextBox.Text = publicacionDirecta.descripcion;
                stockTextBox.Text = Convert.ToString(publicacionDirecta.stock);
                envioCheckBox.Enabled = publicacionDirecta.envioSN;
                precioTextBox.Text = '$' + Convert.ToString(publicacionDirecta.precioPorUnidad);
                precioLabel.Text = "Precio Unidad:";
                compraLabel.Text = "Unidades";
                cant_ofertaNumeric.Maximum = publicacionDirecta.stock;
                ofertarNumeric.Visible = false;
                ofertaLabel.Visible = false;
                vencimientoDateTime.Value = publicacionDirecta.fechaVencimiento;
                vendedorTextBox.Text = publicacionDirecta.Usuario.userName;

                Double cantEstrellas = publicacionDirecta.Usuario.cantidadEstrellas;
                Double cantVentas = publicacionDirecta.Usuario.cantidadVentas;
                reputacionTextBox.Text = String.Format("{0:N2}", cantEstrellas / cantVentas / 2);
                rubroTextBox.Text = publicacionDirecta.RubroLst.First().descripcion;
            }

            deshabilitar_campos_por_estado(estado);
        }

        public void deshabilitar_campos_por_estado(Estadopublicacion estado)
        {
            if (estado.nombre.Equals("Pausada"))
            {
                estadoPausadoLabel.Visible = true;
                cant_ofertaNumeric.Enabled = false;
                ofertarNumeric.Enabled = false;
                envioCheckBox.Enabled = false;
                comprarButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime hoy = DateUtils.convertirStringEnFecha(fechaSistema);

            
            if (tipoTextBox.Text.Equals("Subasta"))
            {
                Cliente usr = SessionAttribute.clienteUser;

                PublicacionSubasta nuevaOfertaPublicacion = (PublicacionSubasta)this.Tag;
                nuevaOfertaPublicacion.valorActual = Convert.ToDouble(ofertarNumeric.Value);

                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                publicacionSubastaDaoImpl.Update(nuevaOfertaPublicacion);

                Ofertasubasta nuevaOferta = new Ofertasubasta();
                nuevaOferta.monto = Convert.ToDouble(ofertarNumeric.Value) - nuevaOfertaPublicacion.valorInicialVenta;
                nuevaOferta.PublicacionSubasta = nuevaOfertaPublicacion;
                nuevaOferta.Usuario = usr;

                
                nuevaOferta.fecha = hoy;
                nuevaOferta.adjudicada = false;

                OfertaSubastaDaoImpl ofertaSubastaImpl = new OfertaSubastaDaoImpl();
                ofertaSubastaImpl.Add(nuevaOferta);

                MessageBox.Show("Su oferta se efectuó con exito.\nCuando finalize la subasta podrá saber si se le adjudicó la compra.");
                this.Close();
            }
            else
            {
                //Validaciones pre compra
                int cantidadVendida = Convert.ToInt32(cant_ofertaNumeric.Value);
                PublicacionNormalDaoImpl actualizarPublicImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaCompraPublicacion = (PublicacionNormal)this.Tag;
                ComisionesParametrizablesDaoImpl cparImpl = new ComisionesParametrizablesDaoImpl();
                CompraUsuarioDaoImpl compUsrDaoImpl = new CompraUsuarioDaoImpl();
                int cantProdVendidos = 0;
                int cantProdDisponibles = 0;

                if (cantidadVendida == 0)
                {
                    MessageBox.Show("Debe seleccionar una cantidad mayor a cero.");
                    return;
                }

                foreach (CompraUsuario compUsu in compUsrDaoImpl.GetByPublicacion(nuevaCompraPublicacion.idPublicacion))
                {
                    cantProdVendidos += compUsu.compraCantidad;
                }
                cantProdDisponibles = nuevaCompraPublicacion.stock - cantProdVendidos;
                if (cantProdDisponibles < cantidadVendida)
                {
                    MessageBox.Show("No hay stock suficiente para su pedido. Stock disponible: " + cantProdDisponibles);
                    return;
                }

                nuevaCompraPublicacion.stock = cantProdDisponibles - cantidadVendida;
                nuevaCompraPublicacion.Usuario.cantidadVentas++;
                
                if (nuevaCompraPublicacion.stock == 0) //Se vendio el total del producto.
                {
                    EstadoPublicacionDaoDaoImpl estadoDaoImpl = new EstadoPublicacionDaoDaoImpl();
                    nuevaCompraPublicacion.EstadoPublicacion = estadoDaoImpl.darEstadoByID(4);
                }


                //Actualizo la factura y cargo los datos del nuevo item
                //TODO: ACA DEBERIA HABER HECHO UNA LISTA Y RECORRERLA CON LOS ITEMS SI QUEDA TIEMPO LO REFACTORIZO
                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                Factura fact = factDaoImpl.darFacturaByPublicacionID(nuevaCompraPublicacion.idPublicacion);

                double montoAgregado = cantidadVendida * nuevaCompraPublicacion.Visibilidad.porcentaje * nuevaCompraPublicacion.precioPorUnidad;

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = cantidadVendida;
                nuevoItemFactura.Factura = fact;
                nuevoItemFactura.monto = montoAgregado;
                fact.ItemFacturasLts.Add(nuevoItemFactura);

                //Costos parametrizable segun compra. env
                if (nuevaCompraPublicacion.envioSN == true)
                {
                    ComisionesParametrizables comiP = cparImpl.darComisionesParametrizablesByNombreCorto("envio");
                    montoAgregado += comiP.porcentaje * nuevaCompraPublicacion.Visibilidad.costo;
                    nuevoItemFactura = new ItemFactura();
                    nuevoItemFactura.cantidad = 1;
                    nuevoItemFactura.Factura = fact;
                    nuevoItemFactura.monto = comiP.porcentaje * nuevaCompraPublicacion.Visibilidad.costo;
                    fact.ItemFacturasLts.Add(nuevoItemFactura);
                }

                fact.montoTotal += montoAgregado;
                factDaoImpl.Update(fact);

                //Genero la compra Cliente y actualizo sus contadores
                ClienteDaoImpl usrImpl = new ClienteDaoImpl();
                Cliente usr = SessionAttribute.clienteUser;
                usr.comprasEfectuadas++;
                usr.montoComprado += nuevaCompraPublicacion.precioPorUnidad * cantidadVendida;
                usrImpl.Update(usr);
                SessionAttribute.clienteUser = usr;

                CompraUsuario compUsuario = new CompraUsuario();
                compUsuario.Publicacion = nuevaCompraPublicacion;
                compUsuario.Usuario = usr;
                compUsuario.compraCantidad = cantidadVendida;
                compUsuario.fecha = hoy;
                compUsrDaoImpl.Add(compUsuario);

                actualizarPublicImpl.Update(nuevaCompraPublicacion);

                MessageBox.Show("Se ha efectuado la compra con exito.\nPor favor, contactese con el vendedor para concretar y obtener su producto.");
                this.Close();
            }
        }
    }
}
