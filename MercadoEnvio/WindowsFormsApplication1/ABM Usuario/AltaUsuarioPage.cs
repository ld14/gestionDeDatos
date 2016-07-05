using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

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
            String nombreUsuario = userNameInput.Text;
            String Password = userPasswordImput.Text;
            String TipoDeUsuario = tipoDeUsuarioComboBox.Text;
            String Mail = DatosBasicosEmailTxt.Text;
            String Telefono = DatosBasicosTelefono.Text;
            String DomicilioCalle = DatosBasicosDomicilioCalle.Text;
            int nroCalle = Convert.ToInt32(DatosBasicosNroCalle.Text);
            int piso =  Convert.ToInt32(DatosBasicosPiso.Text);
            String depto = DatosBasicosDepto.Text;
            String localidad = DatosBasicosLocalidad.Text;
            String ciudad = DatosBasicosCiudad.Text;
            String CodigoPostal = DatosBasicosCodigoPostal.Text;

            
            String Nombre = ClienteNombreTxt.Text;
            String Apellido = ClienteApellidoTxt.Text;

            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(ClienteFechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(EmpresaFechaCreacionDateTime.Value.ToString("dd/MM/yyyy"));
            String RazonSocial = EmpresaRazonSocialTxt.Text;
            String Cuit = EmpresaCuitTxt.Text;
            String NombreContacto = EmpresaNombreContactoTxt.Text;
    
            RolDaoImpl rolDao = new RolDaoImpl();
          
            if (tipoDeUsuarioComboBox.Text.Equals("Cliente"))
            {
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
                nuevoCliente.RolesLst.Add(rolDao.getRolbyId(1));

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
            }
            else
            {
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
                nuevaEmpresa.RolesLst.Add(rolDao.getRolbyId(2));

                nuevaEmpresa.razonSocial = RazonSocial;
                nuevaEmpresa.cuit = Cuit;
                nuevaEmpresa.fechaCreacion = FechaCreacion;
                nuevaEmpresa.perfilActivo = true;
                nuevaEmpresa.nombreContacto = NombreContacto;
                nuevaEmpresa.publicacionGratis = true;

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

        }
    
}

