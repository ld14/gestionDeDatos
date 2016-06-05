using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rubro
{
    public partial class RubroPage : Form
    {
        public RubroPage()
        {
            InitializeComponent();
        }

        private void RubroPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigoTxt = CodigoTxt.Text;
            String nombreCortoTxt = NombreCortoTxt.Text;
            String descripcionTxt = DescripcionTxt.Text;

            Rubro nuevoRubro = new Rubro();
            nuevoRubro.codigo = codigoTxt;
            nuevoRubro.descripcion = descripcionTxt;
            nuevoRubro.nombreCorto = nombreCortoTxt;

            RubroDaoImpl rubroDaoImpl = new RubroDaoImpl();
            rubroDaoImpl.Add(nuevoRubro);

        }
    }
}
