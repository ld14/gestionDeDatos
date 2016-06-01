using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class AltaUsuarioPage : Form
    {
        public AltaUsuarioPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Empresa")){
                EmpresaGroup.Visible = true;
                ClienteGroup.Visible = false;
            }
            else {
                ClienteGroup.Visible = true;
                EmpresaGroup.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreUsuario = userNameInput.Text;
            MessageBox.Show(nombreUsuario);

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
