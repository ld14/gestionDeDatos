using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using WindowsFormsApplication1.Entity.Utils;

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
            //EmpresaFechaCreacionDateTime.Value = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
            RolDaoImpl rolDao = new RolDaoImpl();
            IList<Rol> roles = rolDao.GetAll();

            roles.Remove(roles.Where(x => x.nombre.Equals("Admin")).FirstOrDefault());

            for (int i = 0; i < roles.Count; i++)
            {
                if (roles[i].activo == false)
                {
                    roles.Remove(roles[i]);
                    i--;
                }
            }

            rolesComboBox.DataSource = roles;
            rolesComboBox.DisplayMember = "nombre";
            rolesComboBox.ValueMember = "idRol";
            rolesComboBox.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoUsuarioComboBox.Text.Equals("Empresa"))
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = "";
            string Password = "";
            string Mail = "";
            
            int nroCalle = 0;
            int piso = 0;
            

            if (usernameTextBox.Text != "")
            {
                nombreUsuario = usernameTextBox.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar un userName");
                return;
            }
            if (passwordTextBox.Text != "")
            {
                Password = passwordTextBox.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar una Password ");
                return;
            }
            
            String TipoDeUsuario = tipoUsuarioComboBox.Text;
            if (emailTextBox.Text != "")
            {
                 Mail = emailTextBox.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar un email ");
                return;
            }
           
            String Telefono = telefonoTextBox.Text;
            String DomicilioCalle = domicilioTextBox.Text;
            if (nroCalleTextBox.Text != "") 
            {
                nroCalle = Convert.ToInt32(nroCalleTextBox.Text);
            }
            if (pisoTextBox.Text != "")
            {
                piso = Convert.ToInt32(pisoTextBox.Text);
            }
            String depto = deptoTextBox.Text;
            String localidad = localidadTextBox.Text;
            String ciudad = ciudadTextBox.Text;
            String CodigoPostal = codigoPostalTextBox.Text;

            String Nombre = nombreTextBox.Text;
            String Apellido = apellidoTextBox.Text;

            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(fechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
           
            RolDaoImpl rolDao = new RolDaoImpl();
          
            if (tipoUsuarioComboBox.Text.Equals("Cliente"))
            {
                if (tipoDocumentoComboBox.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento");
                    return;
                }
                if (nroDocumentoTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar un número de documento");
                    return;
                }
                if (apellidoTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Apellido");
                    return;
                }
                if (nombreTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nombre");
                    return;
                }

                UsuarioDaoImpl usuDaoImpl = new UsuarioDaoImpl();
                if (usuDaoImpl.Acceder(usernameTextBox.Text) != null)
                {
                    MessageBox.Show("Ya existe un usuario con el nombre indicado. Por favor ingrese un nuevo nombre de usuario.");
                    return;    
                }


                int tipoDocumento = Convert.ToInt16(tipoDocumentoComboBox.Text);
                int DNI = Convert.ToInt32(nroDocumentoTextBox.Text);
                Cliente nuevoCliente = new Cliente();
                /*Encriptacion password*/
                var mesage = Encoding.UTF8.GetBytes(Password);
                SHA256Managed hashString = new SHA256Managed();
                String pass = "";
                var hashValue = hashString.ComputeHash(mesage);
                foreach (byte x in hashValue)
                {
                    pass += String.Format("{0:x2}", x);
                }

                nuevoCliente.userName = nombreUsuario;
                nuevoCliente.password = pass;
                nuevoCliente.RolesLst = new List<Rol>();
                nuevoCliente.RolesLst.Add(rolesComboBox.SelectedItem as Rol);

                nuevoCliente.dni = DNI;
                nuevoCliente.tipoDocumento = tipoDocumento;
                nuevoCliente.nombre = Nombre;
                nuevoCliente.apellido = Apellido;
                nuevoCliente.fechaNacimiento = FechaNacimiento;
                nuevoCliente.perfilActivo = true;
                nuevoCliente.fechaCreacion = FechaCreacion;
                nuevoCliente.comprasEfectuadas = 0;
                nuevoCliente.comprasCalificadas = 0;
                nuevoCliente.publicacionGratis = true;
                nuevoCliente.activoUsuario = true;

                DatosBasicos nuevoDatoBasico = new DatosBasicos();
                nuevoCliente.DatosBasicos = nuevoDatoBasico;

                nuevoCliente.DatosBasicos.email = Mail;
                nuevoCliente.DatosBasicos.telefono = Telefono;
                nuevoCliente.DatosBasicos.domCalle = DomicilioCalle;
                nuevoCliente.DatosBasicos.nroCalle = nroCalle;
                nuevoCliente.DatosBasicos.piso = piso;
                nuevoCliente.DatosBasicos.depto = depto;
                nuevoCliente.DatosBasicos.codPostal = CodigoPostal;
                nuevoCliente.DatosBasicos.localidad = localidad;
                nuevoCliente.DatosBasicos.ciudad = ciudad;

                ClienteDaoImpl ClienteDaoImpl = new ClienteDaoImpl();
                ClienteDaoImpl.Add(nuevoCliente);
                MessageBox.Show("Creacion de cliente correcta");
            }
            else
            {
                String RazonSocial = "";
                if (razonSocialTextBox.Text != "")
                {
                    RazonSocial = razonSocialTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una razon social");
                    return;
                }
                String Cuit = "";
                if (cuitTextBox.Text != "")
                {
                    Cuit = cuitTextBox.Text;

                }
                else
                {
                    MessageBox.Show("Debe ingresar una CUIT");
                    return;
                }
                String NombreContacto = "";
                if (nombreContactoTextBox.Text != "")
                {
                    NombreContacto = nombreContactoTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una nombre de contacto");
                    return;
                }

                Empresa nuevaEmpresa = new Empresa();
                /*Encriptacion password*/
                var mesage = Encoding.UTF8.GetBytes(Password);
                SHA256Managed hashString = new SHA256Managed();
                String pass = "";
                var hashValue = hashString.ComputeHash(mesage);
                foreach (byte x in hashValue)
                {
                    pass += String.Format("{0:x2}", x);
                }
                nuevaEmpresa.userName = nombreUsuario;
                nuevaEmpresa.password = pass;
                nuevaEmpresa.RolesLst = new List<Rol>();
                nuevaEmpresa.RolesLst.Add(rolesComboBox.SelectedItem as Rol);

                nuevaEmpresa.razonSocial = RazonSocial;
                nuevaEmpresa.cuit = Cuit;
                nuevaEmpresa.fechaCreacion = FechaCreacion;
                nuevaEmpresa.perfilActivo = true;
                nuevaEmpresa.nombreContacto = NombreContacto;
                nuevaEmpresa.publicacionGratis = true;
                nuevaEmpresa.activoUsuario = true;

                DatosBasicos nuevoDatoBasico = new DatosBasicos();
                nuevaEmpresa.DatosBasicos = nuevoDatoBasico;

                nuevaEmpresa.DatosBasicos.email = Mail;
                nuevaEmpresa.DatosBasicos.telefono = Telefono;
                nuevaEmpresa.DatosBasicos.domCalle = DomicilioCalle;
                nuevaEmpresa.DatosBasicos.nroCalle = nroCalle;
                nuevaEmpresa.DatosBasicos.piso = piso;
                nuevaEmpresa.DatosBasicos.depto = depto;
                nuevaEmpresa.DatosBasicos.codPostal = CodigoPostal;
                nuevaEmpresa.DatosBasicos.localidad = localidad;
                nuevaEmpresa.DatosBasicos.ciudad = ciudad;

                EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                empresaDaoImpl.Add(nuevaEmpresa);
                MessageBox.Show("Creacion de empresa correcta");
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            tipoUsuarioComboBox.SelectedItem = null;
            tipoDocumentoComboBox.SelectedItem = null;
            rolesComboBox.SelectedItem = null;
            nroDocumentoTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            razonSocialTextBox.Text = "";
            nombreContactoTextBox.Text = "";
            cuitTextBox.Text = "";
            ciudadTextBox.Text = "";
            codigoPostalTextBox.Text = "";
            deptoTextBox.Text = "";
            domicilioTextBox.Text = "";
            emailTextBox.Text = "";
            localidadTextBox.Text = "";
            nroCalleTextBox.Text = "";
            pisoTextBox.Text = "";
            telefonoTextBox.Text = "";
            ClienteGroup.Visible = false;
            EmpresaGroup.Visible = false;
            cambiarContraseña.Visible = false;
            passwordTextBox.Enabled = true;
            modificarButton.Enabled = false;
            crearButton.Enabled = true;
            activoCheckBox.Checked = false;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            using (BusquedaUsuario busquedaUsuarioForm = new BusquedaUsuario())
            {
                if (busquedaUsuarioForm.ShowDialog() == DialogResult.OK)
                {
                    if (busquedaUsuarioForm.empresaSeleccionada == null)
                    {
                        this.Tag = busquedaUsuarioForm.clienteSeleccionado;
                        usernameTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.userName;
                        tipoUsuarioComboBox.SelectedIndex = tipoUsuarioComboBox.FindString("Cliente");
                        rolesComboBox.SelectedIndex = rolesComboBox.FindString(busquedaUsuarioForm.clienteSeleccionado.RolesLst.First().nombre);
                        tipoDocumentoComboBox.SelectedIndex = busquedaUsuarioForm.clienteSeleccionado.tipoDocumento;
                        nroDocumentoTextBox.Text = Convert.ToString(busquedaUsuarioForm.clienteSeleccionado.dni);
                        nombreTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.nombre;
                        apellidoTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.apellido;
                        fechaNacDateTime.Value = busquedaUsuarioForm.clienteSeleccionado.fechaNacimiento;
                        emailTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.email;
                        localidadTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.localidad;
                        codigoPostalTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.codPostal;
                        pisoTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.piso.ToString();
                        nroCalleTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.nroCalle.ToString();
                        telefonoTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.telefono;
                        domicilioTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.domCalle;
                        deptoTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.depto;
                        ciudadTextBox.Text = busquedaUsuarioForm.clienteSeleccionado.DatosBasicos.ciudad;
                        activoCheckBox.Checked = busquedaUsuarioForm.clienteSeleccionado.activoUsuario;
                    }
                    else
                    {
                        this.Tag = busquedaUsuarioForm.empresaSeleccionada;
                        usernameTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.userName;
                        tipoUsuarioComboBox.SelectedIndex = tipoUsuarioComboBox.FindString("Empresa");
                        rolesComboBox.SelectedIndex = rolesComboBox.FindString(busquedaUsuarioForm.empresaSeleccionada.RolesLst.First().nombre);
                        razonSocialTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.razonSocial;
                        cuitTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.cuit;
                        nombreContactoTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.nombreContacto;
                        emailTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.email;
                        localidadTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.localidad;
                        codigoPostalTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.codPostal;
                        pisoTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.piso.ToString();
                        nroCalleTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.nroCalle.ToString();
                        telefonoTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.telefono;
                        domicilioTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.domCalle;
                        deptoTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.depto;
                        ciudadTextBox.Text = busquedaUsuarioForm.empresaSeleccionada.DatosBasicos.ciudad;
                        activoCheckBox.Checked = busquedaUsuarioForm.empresaSeleccionada.activoUsuario;
                    }

                    passwordTextBox.Enabled = false;
                    passwordTextBox.Text = "********";
                    cambiarContraseña.Visible = true;
                    crearButton.Enabled = false;
                    modificarButton.Enabled = true;
                }
            }
        }      
    }
}

