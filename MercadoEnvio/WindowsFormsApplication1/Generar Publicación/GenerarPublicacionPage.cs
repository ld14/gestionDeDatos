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
            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            FechaIncioDateTime.Value = DateUtils.convertirStringEnFecha(fechaSistema);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Estadopublicacion selectedEstado = EstadoComboBox.SelectedItem as Estadopublicacion;
            //MessageBox.Show(selectedEstado.nombre, "caption goes here");

        }


        private void publicar_Click(object sender, EventArgs e)
        {
            int stock = 1;
            String descripcion = DescripcionPublicacionTxt.Text;
            if (TipoPubliSelect.Text != "Subasta")
                stock = Convert.ToInt32(StockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
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

            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(2);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;
            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            if (TipoPubliSelect.Text.Equals("Subasta"))
            {
                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock, preguntasSN, envioSN,
                        precio, precio, selectedRubro);
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

                ItemFactura nuevoItemFactura = new ItemFactura();
                nuevoItemFactura.cantidad = 1;
                nuevoItemFactura.Factura = nuevaFactura;
                nuevoItemFactura.monto = nuevaPublicacion.Visibilidad.costo;
                lst.Add(nuevoItemFactura);
                nuevaFactura.setFacturaNueva(fechaIncioDateTime, nuevaPublicacion.Visibilidad.costo, "Efectivo", nuevaPublicacion, lst);

                FacturaDaoImpl factDaoImpl = new FacturaDaoImpl();
                factDaoImpl.Add(nuevaFactura);
            }
 
            if (TipoPubliSelect.Text.Equals("Compra Inmediata"))
            {
                PublicacionNormalDaoImpl publicacionSubastaDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.setPublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock,
                        preguntasSN, envioSN, precio, selectedRubro);
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);

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

        private void button1_Click(object sender, EventArgs e)
        {
            int stock = 1;
            String descripcion = DescripcionPublicacionTxt.Text;
            if (TipoPubliSelect.Text != "Subasta")
                stock = Convert.ToInt32(StockTxt.Text);
            bool envioSN = EnvioCheckBox.Checked;
            bool preguntasSN = PreguntasCheckBox.Checked;
            Double precio = Convert.ToDouble(PrecioTxt.Text);
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
            
            EstadoPublicacionDaoDaoImpl buscarEstado = new EstadoPublicacionDaoDaoImpl();
            Estadopublicacion selectedEstado = buscarEstado.darEstadoByID(1);
            Rubro selectedRubro = RubroComboBox.SelectedItem as Rubro;
            Visibilidad selectedVisibilidad = visibilidadComboBox.SelectedItem as Visibilidad;
            Usuario usr = SessionAttribute.user;
            //Factura nuevaFactura = new Factura();
            //IList<ItemFactura> lst = new List<ItemFactura>();

            if(TipoPubliSelect.Text.Equals("Subasta"))
            {
                PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
                PublicacionSubasta nuevaPublicacion = new PublicacionSubasta();
                nuevaPublicacion.setPublicacionSubasta(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock, preguntasSN, envioSN,
                        precio, precio, selectedRubro);
                publicacionSubastaDaoImpl.Add(nuevaPublicacion);
            }

            if (TipoPubliSelect.Text.Equals("Compra Inmediata"))
            {
                PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();
                PublicacionNormal nuevaPublicacion = new PublicacionNormal();
                nuevaPublicacion.setPublicacionNormal(selectedEstado, selectedVisibilidad, usr,
                        descripcion, fechaIncioDateTime, fechaVencimientoDateTime, stock,
                        preguntasSN, envioSN, precio, selectedRubro);
                publicacionNormalDaoImpl.Add(nuevaPublicacion);
            }

            MessageBox.Show("Se ha guardado Satisfactoriamente su publicación.\nSi desea publicarla ir a [Publicacion] -> [Modificar]");
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

            PublicacionNormalDaoImpl publicacionDaoImpl = new PublicacionNormalDaoImpl();
            textBox4.Text = Convert.ToString(publicacionDaoImpl.getSecuenciaPubli() + 1);

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

        private void FechaIncioDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
