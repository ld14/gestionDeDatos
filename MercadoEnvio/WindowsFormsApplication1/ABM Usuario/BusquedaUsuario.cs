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

        public Empresa empresaSeleccionada = null;
        public Cliente clienteSeleccionado = null;

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

                dataGridView1.Visible = true;
                dataGridView2.Visible = false;

                usuariosEmpresaBindingSource.Clear();
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

                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                
                usuariosClienteBindingSource.Clear();
                foreach (UsuariosCliente cli in usrCliente)
                {
                    usuariosClienteBindingSource.Add(cli);
                }
                
            }
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

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void mailClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            disparar_evento();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (clienteRadioButton.Checked)
            {
                UsuariosCliente tempCli = dataGridView2.CurrentRow.DataBoundItem as UsuariosCliente;
                ClienteDaoImpl cDAO = new ClienteDaoImpl();
                clienteSeleccionado = cDAO.GetUsuarioById(tempCli.idUsuario);

            }
            if (empresaRadioButton.Checked)
            {
                UsuariosEmpresa tempEmp = dataGridView1.CurrentRow.DataBoundItem as UsuariosEmpresa;
                EmpresaDaoImpl eDAO = new EmpresaDaoImpl();
                empresaSeleccionada = eDAO.GetEmpresaByIdUsuario(tempEmp.idUsuario);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
