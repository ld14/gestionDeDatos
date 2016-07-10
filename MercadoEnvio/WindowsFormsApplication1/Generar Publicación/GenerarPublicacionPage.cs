using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApplication1.Entity.Utils;
using WindowsFormsApplication1.Entity.DAO;
using System.Globalization;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class GenerarPublicacionPage : Form
    {
        public GenerarPublicacionPage()
        {
            InitializeComponent();
        }

        public int idPub;

        private void GenerarPublicacionPage_Load(object sender, EventArgs e)
        {
            Usuario user = SessionAttribute.user;

            if (user.publicacionGratis)
            {
                Gratis.Visible = true;
            }

            PublicacionNormalDaoImpl publicacionDaoImpl = new PublicacionNormalDaoImpl();
            textBox4.Text = Convert.ToString(publicacionDaoImpl.getSecuenciaPubli());

            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();
            RubroComboBox.DataSource = rubroLts;
            RubroComboBox.DisplayMember = "descripcion";
            RubroComboBox.ValueMember = "idRubro";

            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();
            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "idVisibilidad";

            TipoPubliSelect.Text = "Compra Inmediata";
            vencimientoBox.Text = "7 Días";

            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion estadoPublicacion = buscarEstado.darEstadoByID(1);

            if (this.Tag != null) //Si queremos modificar una publicacion existente
                estadoPublicacion = cargar_formulario();

            FechaIncioDateTime.Value = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
            desabilitar_campos_por_estado(estadoPublicacion);
        }

        public void desabilitar_campos_por_estado(Estadopublicacion estado)
        {
            if (estado.idEstadoPublicacion > 1)
            {
                DescripcionPublicacionTxt.Enabled = false;
                PrecioTxt.Enabled = false;
                stock.Enabled = false;
                EnvioCheckBox.Enabled = false;
                PreguntasCheckBox.Enabled = false;
                vencimientoBox.Enabled = false;
                RubroComboBox.Enabled = false;
                visibilidadComboBox.Enabled = false;
            }

            if (estado.idEstadoPublicacion == 2)
            {
                button1.Text = "Pausar";
                button2.Text = "Finalizar";
            }

            if (estado.idEstadoPublicacion == 3)
            {
                button1.Visible = false;
                button2.Text = "Activar";
                button2.Left -= 141;
            }
        }

        private void visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Gratis.Visible)
            {
                var visibilidad = (Visibilidad)visibilidadComboBox.SelectedItem;
                costoValue.Text = "$" + Convert.ToString(visibilidad.costo);
                porcentajeValue.Text = Convert.ToString(visibilidad.porcentaje * 100) + "%";
            }
        }

        private void tipoPublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipoPubl = (String)TipoPubliSelect.SelectedItem;
            if (tipoPubl.Equals("Compra Inmediata"))
            {
                label2.Text = "Precio por Unidad";
                label10.Visible = true;
                stock.Visible = true;
            }
            if (tipoPubl.Equals("Subasta"))
            {
                label2.Text = "Precio Inicial";
                label10.Visible = false;
                stock.Visible = false;
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (validar_formulario() == true) return; //Sale de la función si no pasa la validación

            if (button1.Text.Equals("Guardar")) //Estado Borrador
            {
                if (groupBoxEstado.Visible == false) //Se trata de una publicacion nueva
                {
                    if (TipoPubliSelect.Text.Equals("Subasta"))
                        alta_publicacion_subasta(1);
                    else
                        alta_publicacion_normal(1);
                }
                else //Una publicacion que ya existe
                {
                    if (TipoPubliSelect.Text.Equals("Subasta"))
                        modif_publicacion_subasta(1);
                    else
                        modif_publicacion_normal(1);
                }

                MessageBox.Show("Se ha guardado Satisfactoriamente su publicación.\nSi desea publicarla ir a [Publicacion] -> [Modificar]");
            }

            if (button1.Text.Equals("Pausar")) //Estado Pausado
            {
                if (TipoPubliSelect.Text.Equals("Subasta"))
                    modif_publicacion_subasta(3);
                else
                    modif_publicacion_normal(3);

                MessageBox.Show("Se ha pausado su publicación.\nSi desea seguir vendiendo deberá activar nuevamente la publicación.");
            }
                
            this.Close();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (validar_formulario() == true) return; //Sale de la función si no pasa la validación
            
            if (button2.Text.Equals("Publicar")) //Estado Activo
            {
                if (groupBoxEstado.Visible == false) //Se trata de una publicacion nueva
                {
                    if (TipoPubliSelect.Text.Equals("Subasta"))
                        alta_publicacion_subasta(2);
                    else
                        alta_publicacion_normal(2);
                }
                else //Una publicacion que ya existe
                {
                    if (TipoPubliSelect.Text.Equals("Subasta"))
                        modif_publicacion_subasta(2);
                    else
                        modif_publicacion_normal(2);
                }

                //Se procede a facturar comisiones al vendedor por publicar
                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                Factura nuevaFactura = new Factura();
                ItemFactura nuevoItemFactura = new ItemFactura();

                nuevoItemFactura.cantidad = 1;
                if (Gratis.Visible)
                {
                    nuevoItemFactura.monto = 0;
                    UsuarioDaoImpl userDao = new UsuarioDaoImpl();
                    SessionAttribute.user.publicacionGratis = false;

                    userDao.Update(SessionAttribute.user);
                }
                else
                {
                    nuevoItemFactura.monto = ((Visibilidad)visibilidadComboBox.SelectedItem).costo;
                }
                nuevoItemFactura.Factura = nuevaFactura;

                nuevaFactura.setFacturaNueva(DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema), "Efectivo", nuevoItemFactura, Convert.ToInt32(textBox4.Text));
                factDaoImpl.Add(nuevaFactura);

                MessageBox.Show("Publicación exitosa.");
            }

            if (button2.Text.Equals("Finalizar")) //Estado Finalizado
            {
                if (TipoPubliSelect.Text.Equals("Subasta"))
                    modif_publicacion_subasta(4);
                else
                    modif_publicacion_normal(4);

                MessageBox.Show("Su publicación ha finalizado.");
            }

            if (button2.Text.Equals("Activar")) //Estado Activo (Desde pausado)
            {
                if (TipoPubliSelect.Text.Equals("Subasta"))
                    modif_publicacion_subasta(2);
                else
                    modif_publicacion_normal(2);

                MessageBox.Show("Su publicación se encuentra activa nuevamente.");
            }

            this.Close();
        }

        public void alta_publicacion_normal(int idEstado)
        {
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(idEstado);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;

            DateTime fechaIncioDateTime = FechaIncioDateTime.Value;
            DateTime fechaVencimientoDateTime = FechaIncioDateTime.Value;

            switch (vencimientoBox.Text)
            {
                case "7 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(7);
                    break;
                case "14 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(14);
                    break;
                case "21 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(21);
                    break;
                case "28 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(28);
                    break;
            }

            PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();
            PublicacionNormal nuevaPublNormal = new PublicacionNormal();
            
            nuevaPublNormal.codigoPublicacion = Convert.ToInt32(textBox4.Text);
            nuevaPublNormal.descripcion = DescripcionPublicacionTxt.Text;
            nuevaPublNormal.envioSN = EnvioCheckBox.Checked;
            nuevaPublNormal.EstadoPublicacion = selectedEstado;
            nuevaPublNormal.fechaCreacion = fechaIncioDateTime;
            nuevaPublNormal.fechaVencimiento = fechaVencimientoDateTime;
            nuevaPublNormal.precioPorUnidad = Convert.ToDouble(PrecioTxt.Text);
            nuevaPublNormal.preguntasSN = PreguntasCheckBox.Checked;
            nuevaPublNormal.RubroLst = new List<Rubro>();
            nuevaPublNormal.RubroLst.Add(selectedRubro);
            nuevaPublNormal.stock = Convert.ToInt32(stock.Value);
            nuevaPublNormal.Usuario = usr;
            nuevaPublNormal.Visibilidad = selectedVisibilidad;
            
            publicacionNormalDaoImpl.Add(nuevaPublNormal);
        }

        public void alta_publicacion_subasta(int idEstado)
        {
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(idEstado);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;

            DateTime fechaIncioDateTime = FechaIncioDateTime.Value;
            DateTime fechaVencimientoDateTime = FechaIncioDateTime.Value;

            switch (vencimientoBox.Text)
            {
                case "7 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(7);
                    break;
                case "14 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(14);
                    break;
                case "21 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(21);
                    break;
                case "28 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(28);
                    break;
            }
            
            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            PublicacionSubasta nuevaPublSub = new PublicacionSubasta();
            
            nuevaPublSub.codigoPublicacion = Convert.ToInt32(textBox4.Text);
            nuevaPublSub.descripcion = DescripcionPublicacionTxt.Text;
            nuevaPublSub.envioSN = EnvioCheckBox.Checked;
            nuevaPublSub.EstadoPublicacion = selectedEstado;
            nuevaPublSub.fechaCreacion = fechaIncioDateTime;
            nuevaPublSub.fechaVencimiento = fechaVencimientoDateTime;
            nuevaPublSub.preguntasSN = PreguntasCheckBox.Checked;
            nuevaPublSub.RubroLst = new List<Rubro>();
            nuevaPublSub.RubroLst.Add(selectedRubro);
            nuevaPublSub.stock = 1;
            nuevaPublSub.Usuario = usr;
            nuevaPublSub.valorActual = Convert.ToDouble(PrecioTxt.Text);
            nuevaPublSub.valorInicialVenta = nuevaPublSub.valorActual;
            nuevaPublSub.Visibilidad = selectedVisibilidad;
            
            publicacionSubastaDaoImpl.Add(nuevaPublSub);
        }

        public void modif_publicacion_normal(int idEstado)
        {
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(idEstado);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;

            DateTime fechaIncioDateTime = FechaIncioDateTime.Value;
            DateTime fechaVencimientoDateTime = FechaIncioDateTime.Value;

            switch (vencimientoBox.Text)
            {
                case "7 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(7);
                    break;
                case "14 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(14);
                    break;
                case "21 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(21);
                    break;
                case "28 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(28);
                    break;
            }

            PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();
            PublicacionNormal nuevaPublNormal = publicacionNormalDaoImpl.GetById(idPub);

            //nuevaPublNormal.codigoPublicacion = Convert.ToInt32(textBox4.Text);
            nuevaPublNormal.descripcion = DescripcionPublicacionTxt.Text;
            nuevaPublNormal.envioSN = EnvioCheckBox.Checked;
            nuevaPublNormal.EstadoPublicacion = selectedEstado;
            nuevaPublNormal.fechaCreacion = fechaIncioDateTime;
            nuevaPublNormal.fechaVencimiento = fechaVencimientoDateTime;
            nuevaPublNormal.precioPorUnidad = Convert.ToDouble(PrecioTxt.Text);
            nuevaPublNormal.preguntasSN = PreguntasCheckBox.Checked;
            nuevaPublNormal.RubroLst = new List<Rubro>();
            nuevaPublNormal.RubroLst.Add(selectedRubro);
            nuevaPublNormal.stock = Convert.ToInt32(stock.Value);
            nuevaPublNormal.Usuario = usr;
            nuevaPublNormal.Visibilidad = selectedVisibilidad;

            publicacionNormalDaoImpl.Update(nuevaPublNormal);
        }

        public void modif_publicacion_subasta(int idEstado)
        {
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(idEstado);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;

            DateTime fechaIncioDateTime = FechaIncioDateTime.Value;
            DateTime fechaVencimientoDateTime = FechaIncioDateTime.Value;

            switch (vencimientoBox.Text)
            {
                case "7 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(7);
                    break;
                case "14 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(14);
                    break;
                case "21 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(21);
                    break;
                case "28 Días":
                    fechaVencimientoDateTime = fechaVencimientoDateTime.AddDays(28);
                    break;
            }

            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            PublicacionSubasta nuevaPublSub = publicacionSubastaDaoImpl.GetById(idPub);

            //nuevaPublSub.codigoPublicacion = Convert.ToInt32(textBox4.Text);
            nuevaPublSub.descripcion = DescripcionPublicacionTxt.Text;
            nuevaPublSub.envioSN = EnvioCheckBox.Checked;
            nuevaPublSub.EstadoPublicacion = selectedEstado;
            nuevaPublSub.fechaCreacion = fechaIncioDateTime;
            nuevaPublSub.fechaVencimiento = fechaVencimientoDateTime;
            nuevaPublSub.preguntasSN = PreguntasCheckBox.Checked;
            nuevaPublSub.RubroLst = new List<Rubro>();
            nuevaPublSub.RubroLst.Add(selectedRubro);
            nuevaPublSub.stock = 1;
            nuevaPublSub.Usuario = usr;
            nuevaPublSub.valorActual = Convert.ToDouble(PrecioTxt.Text);
            nuevaPublSub.valorInicialVenta = nuevaPublSub.valorActual;
            nuevaPublSub.Visibilidad = selectedVisibilidad;

            publicacionSubastaDaoImpl.Update(nuevaPublSub);
        }

        public Estadopublicacion cargar_formulario()
        {
            Estadopublicacion estadoPublicacion = null;
            string vencimiento = "";
            if (this.Tag is PublicacionSubasta)
            {
                PublicacionSubasta tag = (PublicacionSubasta)this.Tag;
                TipoPubliSelect.Text = "Subasta";
                estadoPublicacion = tag.EstadoPublicacion;
                idPub = tag.idPublicacion;

                textBox4.Text = Convert.ToString(tag.codigoPublicacion);
                DescripcionPublicacionTxt.Text = tag.descripcion;
                EnvioCheckBox.Checked = tag.envioSN;
                PreguntasCheckBox.Checked = tag.preguntasSN;
                PrecioTxt.Text = Convert.ToString(tag.valorInicialVenta);
                RubroComboBox.SelectedIndex = tag.RubroLst.First().idRubro - 1;
                visibilidadComboBox.SelectedIndex = tag.Visibilidad.idVisibilidad - 1;
                vencimiento = tag.fechaVencimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                OfertaSubastaDaoImpl oDao = new OfertaSubastaDaoImpl();
                IList<Ofertasubasta> ofertas = oDao.GetByPublicacion(tag.idPublicacion);

                if (ofertas.Count == 0)
                    labelInfo.Text = "Mejor Oferta: (Ninguna)";
                else
                    labelInfo.Text += "Mejor Oferta: $" + Convert.ToString(tag.valorActual);
            }

            if (this.Tag is PublicacionNormal)
            {
                PublicacionNormal tag = (PublicacionNormal)this.Tag;
                TipoPubliSelect.Text = "Compra Inmediata";
                estadoPublicacion = tag.EstadoPublicacion;
                idPub = tag.idPublicacion;

                textBox4.Text = Convert.ToString(tag.codigoPublicacion);
                DescripcionPublicacionTxt.Text = tag.descripcion;
                EnvioCheckBox.Checked = tag.envioSN;
                PreguntasCheckBox.Checked = tag.preguntasSN;
                PrecioTxt.Text = Convert.ToString(tag.precioPorUnidad);
                RubroComboBox.Text = tag.RubroLst.First().descripcion;
                visibilidadComboBox.Text = tag.Visibilidad.nombreVisibilidad;
                stock.Value = tag.stock;
                vencimiento = tag.fechaVencimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                CompraUsuarioDaoImpl cDao = new CompraUsuarioDaoImpl();
                IList<CompraUsuario> compras = cDao.GetByPublicacion(tag.idPublicacion);
                labelInfo.Text = "Unidades vendidas: " + Convert.ToString(compras.Count);
            }

            TipoPubliSelect.Enabled = false;
            estado.Text += estadoPublicacion.nombre;
            groupBoxEstado.Visible = true;
            if (estadoPublicacion.idEstadoPublicacion > 1)
            {
                infoBox.Visible = true;
                List<string> venc = new List<string>();
                venc.Add(vencimiento);
                vencimientoBox.DataSource = venc;
                vencimientoBox.Text = vencimiento;
                label1.Text = "Fecha Vencimiento";
            }

            return estadoPublicacion;
        }

        public bool validar_formulario()
        {
            if (DescripcionPublicacionTxt.Text == "" || PrecioTxt.Text == "")
            {
                MessageBox.Show("Debe de completar todos los campos obligatorios");
                return true;
            }
            if (!Regex.IsMatch(PrecioTxt.Text, @"(^(\d)+(,(\d)+)?)$"))
            {
                MessageBox.Show("El campo Precio solo admite un numero decimal");
                return true;
            }
            return false;
        }
    }
}
