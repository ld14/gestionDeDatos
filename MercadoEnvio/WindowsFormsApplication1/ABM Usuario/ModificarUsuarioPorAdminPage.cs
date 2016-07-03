using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Entity.Utils;
using WindowsFormsApplication1.ABM_Usuario;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificarUsuarioPorAdminPage : Form
    {
       
        public static int totalRecords = 0;
        private const int pageSize = 10;
        List<GrillaUsuario> customerList = new List<GrillaUsuario>();
        Boolean esTipoRolEmpresa = false; //Booleano que indica si el rol seleccionado es una empresa o no (de no serlo es un cliente)

        public ModificarUsuarioPorAdminPage()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void tipoDeUsuarioComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                if (tipoDeUsuarioComboBox.Text.Equals("Empresa"))
                {
                    EmpresaGroup.Visible = true;
                    ClienteGroup.Visible = false;
                }
                else
                {
                    ClienteGroup.Visible = true;
                    EmpresaGroup.Visible = false;
                }
            
        }
    

        public static int TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerList = new List<GrillaUsuario>();
            Usuario usuario = new Usuario();
            UsuarioDaoImpl usuarioDaoImpl = new UsuarioDaoImpl();
            int cantRegistros = 0;

            if (tipoDeUsuarioComboBox.SelectedIndex == 1)
            {
                ClienteDaoImpl clienteDaoImpl = new ClienteDaoImpl();
                String nombre = ClienteNombreTxt.Text;
                String apellido = ClienteApellidoTxt.Text;
                Double dni = 0;
                if (!ClienteDNITxt.Text.Equals(""))
                {
                    dni = Convert.ToDouble(ClienteDNITxt.Text);
                }
                String email = EmailTxt.Text;
                if (nombre.Equals("") && apellido.Equals("") && email.Equals("") && dni == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un filtro");
                    return;
                }
                IList<Cliente> clienteLts = clienteDaoImpl.darClientesFiltrados(nombre, apellido, email, dni);
                esTipoRolEmpresa = false;

                foreach (Cliente cliente in clienteLts)
                {
                    usuario = usuarioDaoImpl.GetUsuarioById(cliente.idUsuario);
                    
                        cantRegistros++;
                        GrillaUsuario nuevaGrilla = new GrillaUsuario();
                        nuevaGrilla.nombreUsuario = cliente.userName;
                        nuevaGrilla.Nombre = cliente.nombre;
                        nuevaGrilla.Apellido = cliente.apellido;
                        nuevaGrilla.Telefono = cliente.DatosBasicos.telefono;
                        nuevaGrilla.DomicilioCalle = cliente.DatosBasicos.domCalle;
                        nuevaGrilla.nroCalle = cliente.DatosBasicos.nroCalle;
                        nuevaGrilla.piso = cliente.DatosBasicos.piso;
                        nuevaGrilla.depto = cliente.DatosBasicos.depto;
                        nuevaGrilla.localidad = cliente.DatosBasicos.localidad;
                        nuevaGrilla.ciudad = cliente.DatosBasicos.ciudad;
                        nuevaGrilla.CodigoPostal = cliente.DatosBasicos.codPostal;
                        nuevaGrilla.FechaCreacion = cliente.fechaCreacion;
                        nuevaGrilla.Mail = cliente.DatosBasicos.email;
                        nuevaGrilla.FechaNacimiento = cliente.fechaNacimiento;
                        nuevaGrilla.Dni = cliente.dni;
                        nuevaGrilla.idUsuario = cliente.idUsuario;
                        this.customerList.Add(nuevaGrilla);
                    
                }

            }
            else
            {
                EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                String razonSocial = EmpresaRazonSocialTxt.Text;
                String cuit = EmpresaCuitTxt.Text;
                String email = EmailTxt.Text;
                if (razonSocial.Equals("") && email.Equals("") && cuit.Equals(""))
                {
                    MessageBox.Show("Debe ingresar al menos un filtro");
                    return;
                }
                IList<Empresa> empresaLts = empresaDaoImpl.darEmpresasFiltradas(razonSocial, cuit, email);
                esTipoRolEmpresa = true;

                foreach (Empresa empresa in empresaLts)
                {
                    usuario = usuarioDaoImpl.GetUsuarioById(empresa.idUsuario);
                    
                        cantRegistros++;
                        GrillaUsuario nuevaGrilla = new GrillaUsuario();
                        nuevaGrilla.nombreUsuario = empresa.userName;
                        nuevaGrilla.Telefono = empresa.DatosBasicos.telefono;
                        nuevaGrilla.DomicilioCalle = empresa.DatosBasicos.domCalle;
                        nuevaGrilla.nroCalle = empresa.DatosBasicos.nroCalle;
                        nuevaGrilla.piso = empresa.DatosBasicos.piso;
                        nuevaGrilla.depto = empresa.DatosBasicos.depto;
                        nuevaGrilla.localidad = empresa.DatosBasicos.localidad;
                        nuevaGrilla.ciudad = empresa.DatosBasicos.ciudad;
                        nuevaGrilla.CodigoPostal = empresa.DatosBasicos.codPostal;
                        nuevaGrilla.FechaCreacion = empresa.fechaCreacion;
                        nuevaGrilla.NombreContacto = empresa.nombreContacto;
                        nuevaGrilla.RazonSocial = empresa.razonSocial;
                        nuevaGrilla.Mail = empresa.DatosBasicos.email;
                        nuevaGrilla.Cuit = empresa.cuit;
                        nuevaGrilla.idUsuario = empresa.idUsuario;
                        this.customerList.Add(nuevaGrilla);
                    
                }
            }

            TotalRecords = this.customerList.Count;
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idPublicacion" });
            if (TotalRecords == 0)
            {
                MessageBox.Show("No se encontraron resultados en la búsqueda");
            }
            else
            {
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
                bindingSource1.DataSource = new PageOffsetList();
                MessageBox.Show("Búsqueda finalizada. Clientes encontrados: " + cantRegistros);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            var records = new List<GrillaUsuario>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(this.customerList[i]);
            dataGridView1.DataSource = records;
           
            dataGridView1.Columns[0].HeaderText = "Nombre usuario";
            dataGridView1.Columns[1].HeaderText = "Email";
            dataGridView1.Columns[2].HeaderText = "Telefono";
            dataGridView1.Columns[3].HeaderText = "Domicilio Calle";
            dataGridView1.Columns[4].HeaderText = "Número de calle";
            dataGridView1.Columns[5].HeaderText = "Piso";
            dataGridView1.Columns[6].HeaderText = "Dpto";
            dataGridView1.Columns[7].HeaderText = "Código Postal";
            dataGridView1.Columns[8].HeaderText = "Localidad";
            dataGridView1.Columns[9].HeaderText = "Ciudad";
            dataGridView1.Columns[10].HeaderText = "Fecha Creación";
            dataGridView1.Columns[11].HeaderText = "Nombre";
            dataGridView1.Columns[12].HeaderText = "Apellido";
            dataGridView1.Columns[13].HeaderText = "DNI";
            dataGridView1.Columns[14].HeaderText = "Fecha Nacimiento";
            dataGridView1.Columns[15].HeaderText = "Razón social";
            dataGridView1.Columns[16].HeaderText = "CUIT";
            dataGridView1.Columns[17].HeaderText = "Nombre contacto";

            dataGridView1.Columns[11].Visible = !esTipoRolEmpresa;
            dataGridView1.Columns[12].Visible = !esTipoRolEmpresa;
            dataGridView1.Columns[13].Visible = !esTipoRolEmpresa;
            dataGridView1.Columns[14].Visible = !esTipoRolEmpresa;
            dataGridView1.Columns[15].Visible = esTipoRolEmpresa;
            dataGridView1.Columns[16].Visible = esTipoRolEmpresa;
            dataGridView1.Columns[17].Visible = esTipoRolEmpresa;

            dataGridView1.Columns[18].Visible = false;

        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < TotalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Int32 idUsuario = -1;
            UsuarioDaoImpl usuarioDaoImpl = new UsuarioDaoImpl();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fila para poder realizar la baja");
            }
            else
            {
                Int32 idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[18].Value.ToString());
                ModificarUsuarioParaAdminPage modificarUsuarioParaAdminPage = new ModificarUsuarioParaAdminPage();
                if (esTipoRolEmpresa == true)
                {
                    EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                    Empresa empresa = empresaDaoImpl.GetEmpresaByIdUsuario(idUsuario);
                    modificarUsuarioParaAdminPage.setearEmpresa(empresa);
                }
                else
                {
                    ClienteDaoImpl clienteDaoImpl = new ClienteDaoImpl();
                    Cliente cliente = clienteDaoImpl.GetUsuarioById(idUsuario);
                    modificarUsuarioParaAdminPage.setearCliente(cliente);
                }

                modificarUsuarioParaAdminPage.Text = "init";
                modificarUsuarioParaAdminPage.MdiParent = this.MdiParent;
                modificarUsuarioParaAdminPage.Show();
            }
        }
    }     
}
        
    

