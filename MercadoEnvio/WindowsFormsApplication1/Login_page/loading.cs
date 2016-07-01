using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.DAO;

namespace WindowsFormsApplication1.Login_page
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            string asd = Directory.GetCurrentDirectory();
            Image image = Image.FromFile("../../image_1001943.gif");
            loadingImg.Image = image;

            //PublicacionNormalDaoImpl DAO = new PublicacionNormalDaoImpl();
            //PublicacionNormal asdasdasd = DAO.GetByUsuario("u1"); //Esto se va a cambiar por ACTUALIZAR ESTADO PUBLICACIONES

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
