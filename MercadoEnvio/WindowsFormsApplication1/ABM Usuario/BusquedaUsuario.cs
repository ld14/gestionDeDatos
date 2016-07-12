using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class BusquedaUsuario : Form
    {
        public BusquedaUsuario()
        {
            InitializeComponent();
        }

        public short tipoUser = 0; 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaUsuario_Load(object sender, EventArgs e)
        {
            disparar_evento();
        }

        public void disparar_evento()
        {
            if (empresaRadioButton.Checked)
            {
                EmpresaDaoImpl eDAO = new EmpresaDaoImpl();
                IList<Empresa> empresasList = eDAO.GetByCriteria(cuitTextBox.Text, mailEmpresaTextBox.Text, razonSocialTextBox.Text);

                IList<UsuariosEmpresa> usrEmpresa = new List<UsuariosEmpresa>();
                foreach (Empresa empresa in empresasList)
                {
                    UsuariosEmpresa temp = new UsuariosEmpresa();
                    temp.idUsuario = empresa.idUsuario;
                    temp.cuit = empresa.cuit;
                    temp.email = empresa.DatosBasicos.email;
                    temp.razonSocial = empresa.razonSocial;

                    usrEmpresa.Add(temp);
                }
                
                dataGridView1.DataSource = usuariosEmpresaBindingSource;
                usuariosEmpresaBindingSource.Clear();
                
                dataGridView1.Columns[2].Width = 66;
                dataGridView1.Columns[2].HeaderText = "ID Usuario";
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[3].HeaderText = "Razón Social";
                dataGridView1.Columns[4].Width = 92;
                dataGridView1.Columns[4].HeaderText = "CUIT";
                dataGridView1.Columns[5].Width = 190;
                dataGridView1.Columns[5].HeaderText = "eMail";
                dataGridView1.Columns[6].Visible = false;


                foreach (UsuariosEmpresa emp in usrEmpresa)
                {
                    usuariosEmpresaBindingSource.Add(emp);
                }
            }
            
            if (clienteRadioButton.Checked)
            {
                ClienteDaoImpl cDAO = new ClienteDaoImpl();
                IList<Cliente> clientesList = cDAO.GetByCriteria(dniTextBox.Text, mailClienteTextBox.Text, nombreTextBox.Text, apellidoTextBox.Text);
                
                IList<UsuariosCliente> usrCliente = new List<UsuariosCliente>();
                foreach (Cliente cliente in clientesList)
                {
                    UsuariosCliente temp = new UsuariosCliente();
                    temp.idUsuario = cliente.idUsuario;
                    temp.dni = cliente.dni;
                    temp.mail = cliente.DatosBasicos.email;
                    temp.apellido = cliente.apellido;
                    temp.nombre = cliente.nombre;

                    usrCliente.Add(temp);
                }

                dataGridView1.DataSource = usuariosClienteBindingSource;
                
                usuariosClienteBindingSource.Clear();

                dataGridView1.Columns[2].Width = 66;
                dataGridView1.Columns[2].HeaderText = "ID Usuario";
                dataGridView1.Columns[3].Width = 90;
                dataGridView1.Columns[3].HeaderText = "Nombre";
                dataGridView1.Columns[4].Width = 90;
                dataGridView1.Columns[4].HeaderText = "Apellido";
                dataGridView1.Columns[5].Width = 85;
                dataGridView1.Columns[5].HeaderText = "Nro Documento";
                dataGridView1.Columns[6].Width = 140;
                dataGridView1.Columns[6].HeaderText = "eMail";
                dataGridView1.Columns[6].Visible = true;

                foreach (UsuariosCliente cli in usrCliente)
                {
                    usuariosClienteBindingSource.Add(cli);
                }
                
            }
        }

        private void empresaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void razonSocialTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void cuitTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void mailEmpresaTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void clienteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clienteGroupBox.Visible = true;
            empresaGroupBox.Visible = false;
            disparar_evento();
        }

        private void empresaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clienteGroupBox.Visible = false;
            empresaGroupBox.Visible = true;
            disparar_evento();
        }
    }
}
