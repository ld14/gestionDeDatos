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

            RolesCombobox.DataSource = roles;
            RolesCombobox.DisplayMember = "nombre";
            RolesCombobox.ValueMember = "idRol";            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoDeUsuarioComboBox.Text.Equals("Empresa"))
            {
                EmpresaGroup.Visible = true;
                EmpresaGroup.BringToFront();
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
            

            if (userNameInput.Text != "")
            {
                nombreUsuario = userNameInput.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar un userName");
                return;
            }
            if (userPasswordImput.Text != "")
            {
                Password = userPasswordImput.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar una Password ");
                return;
            }
            
            String TipoDeUsuario = tipoDeUsuarioComboBox.Text;
            if (DatosBasicosEmailTxt.Text != "")
            {
                 Mail = DatosBasicosEmailTxt.Text;
            }
            else 
            {
                MessageBox.Show("Debe ingresar un email ");
                return;
            }
           
            String Telefono = DatosBasicosTelefono.Text;
            String DomicilioCalle = DatosBasicosDomicilioCalle.Text;
            if (DatosBasicosNroCalle.Text != "") 
            {
                nroCalle = Convert.ToInt32(DatosBasicosNroCalle.Text);
            }
            if (DatosBasicosPiso.Text != "")
            {
                piso = Convert.ToInt32(DatosBasicosPiso.Text);
            }
            String depto = DatosBasicosDepto.Text;
            String localidad = DatosBasicosLocalidad.Text;
            String ciudad = DatosBasicosCiudad.Text;
            String CodigoPostal = DatosBasicosCodigoPostal.Text;

            
            String Nombre = ClienteNombreTxt.Text;
            String Apellido = ClienteApellidoTxt.Text;

            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(ClienteFechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(SessionAttribute.fechaSistema);
           
    
            RolDaoImpl rolDao = new RolDaoImpl();
          
            if (tipoDeUsuarioComboBox.Text.Equals("Cliente"))
            {
                if (ClienteTipoDocComboBox.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento");
                    return;
                }
                if (ClienteDNITxt.Text == "")
                {
                    MessageBox.Show("Debe ingresar un número de documento");
                    return;
                }
                if (ClienteApellidoTxt.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Apellido");
                    return;
                }
                if (ClienteNombreTxt.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nombre");
                    return;
                }

                UsuarioDaoImpl usuDaoImpl = new UsuarioDaoImpl();
                if (usuDaoImpl.Acceder(userNameInput.Text) != null)
                {
                    MessageBox.Show("Ya existe un usuario con el nombre indicado. Por favor ingrese un nuevo nombre de usuario.");
                    return;    
                }


                int tipoDocumento = Convert.ToInt16(ClienteTipoDocComboBox.Text);
                int DNI = Convert.ToInt32(ClienteDNITxt.Text);
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
                nuevoCliente.RolesLst.Add(RolesCombobox.SelectedItem as Rol);

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
                if (EmpresaRazonSocialTxt.Text != "")
                {
                    RazonSocial = EmpresaRazonSocialTxt.Text;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una razon social");
                    return;
                }
                String Cuit = "";
                if (EmpresaCuitTxt.Text != "")
                {
                    Cuit = EmpresaCuitTxt.Text;

                }
                else
                {
                    MessageBox.Show("Debe ingresar una CUIT");
                    return;
                }
                String NombreContacto = "";
                if (EmpresaNombreContactoTxt.Text != "")
                {
                    NombreContacto = EmpresaNombreContactoTxt.Text;
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
                nuevaEmpresa.RolesLst.Add(RolesCombobox.SelectedItem as Rol);

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


        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userNameInput.Text = "";
            userPasswordImput.Text = "";
            tipoDeUsuarioComboBox.Text = null;
            ClienteTipoDocComboBox.Text = null;
            RolesCombobox.Text = null;
            ClienteDNITxt.Text = "";
            ClienteNombreTxt.Text = "";
            ClienteApellidoTxt.Text = "";
            EmpresaRazonSocialTxt.Text = "";
            EmpresaNombreContactoTxt.Text = "";
            EmpresaCuitTxt.Text = "";
            DatosBasicosCiudad.Text = "";
            DatosBasicosCodigoPostal.Text = "";
            DatosBasicosDepto.Text = "";
            DatosBasicosDomicilioCalle.Text = "";
            DatosBasicosEmailTxt.Text = "";
            DatosBasicosLocalidad.Text = "";
            DatosBasicosNroCalle.Text = "";
            DatosBasicosPiso.Text = "";
            DatosBasicosTelefono.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (BusquedaUsuario busquedaUsuarioForm = new BusquedaUsuario())
            {
                if (busquedaUsuarioForm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }      

    }
    
}

