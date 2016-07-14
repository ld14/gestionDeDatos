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
using System.Text.RegularExpressions;

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

        private void crearButton_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (!validaciones_form()) return;
  
            //Encriptar contraseña
            string contraseña = encriptar_contraseña(passwordTextBox.Text);

            RolDaoImpl rolDao = new RolDaoImpl();
            DatosBasicos nuevoDatoBasico = new DatosBasicos();
            Rol rolSeleccionado = new Rol();

            //Cargo el Rol seleccionado
            rolSeleccionado = rolDao.getRolByName(rolesComboBox.Text);

            //Seteo datos basicos
            nuevoDatoBasico.ciudad = ciudadTextBox.Text;
            nuevoDatoBasico.codPostal = codigoPostalTextBox.Text;
            nuevoDatoBasico.depto = deptoTextBox.Text;
            nuevoDatoBasico.domCalle = domicilioTextBox.Text;
            nuevoDatoBasico.email = emailTextBox.Text;
            nuevoDatoBasico.localidad = localidadTextBox.Text;
            if (nroCalleTextBox.Text == "") nuevoDatoBasico.nroCalle = null;
            else nuevoDatoBasico.nroCalle = Convert.ToInt32(nroCalleTextBox.Text);
            if (pisoTextBox.Text == "") nuevoDatoBasico.piso = null;
            else nuevoDatoBasico.piso = Convert.ToInt32(pisoTextBox.Text);
            nuevoDatoBasico.telefono = telefonoTextBox.Text;

            if (tipoUsuarioComboBox.Text.Equals("Cliente"))
            {
                Cliente nuevoCliente = new Cliente();

                nuevoCliente.activoUsuario = activoCheckBox.Checked;
                nuevoCliente.apellido = apellidoTextBox.Text;
                nuevoCliente.cantidadEstrellas = 0;
                nuevoCliente.cantidadVentas = 0;
                nuevoCliente.comprasCalificadas = 0;
                nuevoCliente.comprasEfectuadas = 0;
                nuevoCliente.dni = Convert.ToInt32(nroDocumentoTextBox.Text);
                nuevoCliente.estrellasDadas = 0;
                nuevoCliente.fechaCreacion = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
                nuevoCliente.fechaNacimiento = fechaNacDateTime.Value;
                nuevoCliente.intentosFallidos = 0;
                nuevoCliente.montoComprado = 0;
                nuevoCliente.nombre = nombreTextBox.Text;
                nuevoCliente.password = contraseña;
                nuevoCliente.perfilActivo = true;
                nuevoCliente.publicacionGratis = true;
                nuevoCliente.tipoDocumento = tipoDocumentoComboBox.SelectedIndex + 1;
                nuevoCliente.userName = usernameTextBox.Text;

                nuevoCliente.DatosBasicos = nuevoDatoBasico;
                nuevoCliente.RolesLst.Add(rolSeleccionado);

                ClienteDaoImpl ClienteDaoImpl = new ClienteDaoImpl();
                ClienteDaoImpl.Add(nuevoCliente);
                MessageBox.Show("Creación de Cliente correcta");
            }
            else
            {
                Empresa nuevaEmpresa = new Empresa();

                nuevaEmpresa.activoUsuario = activoCheckBox.Checked;
                nuevaEmpresa.cantidadEstrellas = 0;
                nuevaEmpresa.cantidadVentas = 0;
                nuevaEmpresa.cuit = cuitTextBox.Text;
                nuevaEmpresa.fechaCreacion = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
                nuevaEmpresa.intentosFallidos = 0;
                nuevaEmpresa.nombreContacto = nombreContactoTextBox.Text;
                nuevaEmpresa.password = contraseña;
                nuevaEmpresa.perfilActivo = true;
                nuevaEmpresa.publicacionGratis = true;
                nuevaEmpresa.razonSocial = razonSocialTextBox.Text;
                nuevaEmpresa.userName = usernameTextBox.Text;

                nuevaEmpresa.DatosBasicos = nuevoDatoBasico;
                nuevaEmpresa.RolesLst.Add(rolSeleccionado);

                EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                empresaDaoImpl.Add(nuevaEmpresa);
                MessageBox.Show("Creación de Empresa correcta");
            }
            this.Close();
        }

        public bool validaciones_form()
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar un userName.");
                return false;
            }
            UsuarioDaoImpl usuDaoImpl = new UsuarioDaoImpl();
            if (usuDaoImpl.Acceder(usernameTextBox.Text) != null)
            {
                MessageBox.Show("Ya existe un usuario con el nombre indicado.\nPor favor ingrese un userName distinto.");
                return false;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar una Password.");
                return false;
            }
            if (tipoUsuarioComboBox.Text == "")
            {
                MessageBox.Show("Debe seleccionar el tipo de usuario a crear.");
                return false;
            }
            if (rolesComboBox.Text == "")
            {
                MessageBox.Show("Debe seleccionar un Rol.");
                return false;
            }

            if (tipoUsuarioComboBox.Text.Equals("Cliente"))
            {
                if (tipoDocumentoComboBox.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento.");
                    return false;
                }
                if (!Regex.IsMatch(nroDocumentoTextBox.Text, @"^[\d]{1,9}$"))
                {
                    MessageBox.Show("Debe ingresar un número de documento válido. (Hasta 9 dígitos)");
                    return false;
                }

                ClienteDaoImpl cDAO = new ClienteDaoImpl();
                if (cDAO.verificarUnique(Convert.ToInt32(tipoDocumentoComboBox.SelectedIndex + 1), Convert.ToInt32(nroDocumentoTextBox.Text)) != null)
                {
                    MessageBox.Show("Ya existe un usuario con ese mismo tipo y número de documento.\nPor favor ingrese uno distinto.");
                    return false;
                }

                if (apellidoTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Apellido.");
                    return false;
                }
                if (nombreTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Nombre.");
                    return false;
                }
            }
            if (tipoUsuarioComboBox.Text.Equals("Empresa"))
            {
                if (razonSocialTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar la Razón social.");
                    return false;
                }
                if (cuitTextBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar el CUIT.");
                    return false;
                }
                EmpresaDaoImpl eDAO = new EmpresaDaoImpl();
                if (eDAO.GetEmpresaByCuit(cuitTextBox.Text) != null)
                {
                    MessageBox.Show("Ya existe una empresa con ese CUIT.\nPor favor ingrese uno distinto.");
                    return false;
                }
                if (eDAO.GetEmpresaByRazonSocial(razonSocialTextBox.Text) != null)
                {
                    MessageBox.Show("Ya existe una empresa con esa Razón Social.\nPor favor ingrese uno distinto.");
                    return false;
                }
            }

            if (!Regex.IsMatch(emailTextBox.Text, @"^[A-Za-z0-9 º:_\-.]+[@]{1}[A-Za-z0-9\-_]+\.(\w){1,3}$"))
            {
                MessageBox.Show("Debe ingresar una dirección de mail válida.");
                return false;
            }
            if (!Regex.IsMatch(pisoTextBox.Text, @"^[\d]{0,9}$"))
            {
                MessageBox.Show("Debe ingresar solo dígitos en el campo Piso. (Hasta 9 dígitos)");
                return false;
            }
            if (!Regex.IsMatch(nroCalleTextBox.Text, @"^[\d]{0,9}$"))
            {
                MessageBox.Show("Debe ingresar solo dígitos en el campo Nro Calle. (Hasta 9 dígitos)");
                return false;
            }

            return true;
        }

        public string encriptar_contraseña(string password)
        {
            var message = Encoding.UTF8.GetBytes(password);
            SHA256Managed hashString = new SHA256Managed();
            String passEncriptada = "";
            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                passEncriptada += String.Format("{0:x2}", x);
            }

            return passEncriptada;
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

        private void cambiarContraseña_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar la contraseña?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                passwordTextBox.Enabled = true;
                passwordTextBox.Text = "";
                cambiarContraseña.Visible = false;
            }
        }      
    }
}

