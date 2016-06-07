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
                comboBox2.DataSource = cantidadCompra;

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

    }
}
