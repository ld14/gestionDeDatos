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

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class GenerarPublicacionPage : Form
    {

        public GenerarPublicacionPage()
        {
            InitializeComponent();
        }

        private void GenerarPublicacionPage_Load(object sender, EventArgs e)
        {
            Usuario user = SessionAttribute.user;
            if (user.publicacionGratis)
            {
                Gratis.Visible = true;
            }

            FechaIncioDateTime.Value = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);

            //----------------------ComboBox Rubro -------------------------------------------//
            RubroDaoImpl rubroDaoImpli = new RubroDaoImpl();
            IList<Rubro> rubroLts = rubroDaoImpli.darRubroActivo();

            RubroComboBox.DataSource = rubroLts;
            RubroComboBox.DisplayMember = "descripcion";
            RubroComboBox.ValueMember = "idRubro";

            PublicacionNormalDaoImpl publicacionDaoImpl = new PublicacionNormalDaoImpl();
            textBox4.Text = Convert.ToString(publicacionDaoImpl.getSecuenciaPubli() + 1);

            //----------------------ComboBox Visibilidad --------------------------------------//
            VisibilidadDaoImpl visibilidadDao = new VisibilidadDaoImpl();
            IList<Visibilidad> VisibilidadLts = visibilidadDao.darVisibilidad();

            visibilidadComboBox.DataSource = VisibilidadLts;
            visibilidadComboBox.DisplayMember = "nombreVisibilidad";
            visibilidadComboBox.ValueMember = "idVisibilidad";
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

        private void guardar_Click(object sender, EventArgs e)
        {
            if (DescripcionPublicacionTxt.Text == "" || PrecioTxt.Text == "")
            {
                MessageBox.Show("Debe de completar todos los campos obligatorios");
                return;
            }

            if (!Regex.IsMatch(PrecioTxt.Text, @"(^(\d)+(,(\d)+)?)$"))
            {
                MessageBox.Show("El campo Precio solo admite un numero decimal");
                return;
            }

            if (TipoPubliSelect.Text.Equals("Subasta"))
                alta_publicacion_subasta(1);
            else
                alta_publicacion_normal(1);

            MessageBox.Show("Se ha guardado Satisfactoriamente su publicación.\nSi desea publicarla ir a [Publicacion] -> [Modificar]");
            this.Close();
        }

        private void publicar_Click(object sender, EventArgs e)
        {
            if (DescripcionPublicacionTxt.Text == "" || PrecioTxt.Text == "")
            {
                MessageBox.Show("Debe de completar todos los campos obligatorios");
                return;
            }

            if (!Regex.IsMatch(PrecioTxt.Text, @"(^(\d)+(,(\d)+)?)$"))
            {
                MessageBox.Show("El campo Precio solo admite un numero decimal");
                return;
            }
            
            if (DescripcionPublicacionTxt.Text == "" || PrecioTxt.Text == "")
            {
                MessageBox.Show("Debe de completar todos los campos obligatorios");
                return;
            }

            if (TipoPubliSelect.Text.Equals("Subasta"))
                alta_publicacion_subasta(2);
            else
                alta_publicacion_normal(2);

            // Se genera la facturación correspondiente por publicar
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
            
            nuevaFactura.setFacturaNueva(DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema), "Efectivo", nuevoItemFactura);
            factDaoImpl.Add(nuevaFactura);

            MessageBox.Show("Publicación exitosa.");
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
    }
}
