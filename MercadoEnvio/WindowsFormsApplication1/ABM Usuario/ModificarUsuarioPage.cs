using System;
using NHibernate;
using WindowsFormsApplication1.Entity.Utils;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificarUsuarioPage : Form
    {
        public ModificarUsuarioPage()
        {
            InitializeComponent();
            IEnumerator<Rol> rolUser = SessionAttribute.user.RolesLst.GetEnumerator();
            rolUser.MoveNext();

            this.userNameInput.Text = SessionAttribute.user.userName;
            //this.userPasswordImput.Text = SessionAttribute.user.password;
            this.tipoDeUsuarioComboBox.Text = rolUser.Current.nombre;
            if (rolUser.Current.nombre.Equals("Empresa"))
            {
                EmpresaGroup.Visible = true;
                ClienteGroup.Visible = false;
            }
            else
            {
                ClienteGroup.Visible = true;
                EmpresaGroup.Visible = false;
            }

            if (rolUser.Current.nombre == "Cliente")
            {
                ClienteGroup.Visible = true;
                EmpresaGroup.Visible = false;

                this.ClienteApellidoTxt.Text = SessionAttribute.clienteUser.apellido;
                this.ClienteNombreTxt.Text = SessionAttribute.clienteUser.nombre;
                this.ClienteDNITxt.Text = SessionAttribute.clienteUser.dni.ToString();
                this.ClienteTipoDocComboBox.Text = Convert.ToString(SessionAttribute.clienteUser.tipoDocumento);

                this.DatosBasicosEmailTxt.Text = SessionAttribute.clienteUser.DatosBasicos.email;
                this.DatosBasicosTelefono.Text = SessionAttribute.clienteUser.DatosBasicos.telefono;
                this.DatosBasicosDomicilioCalle.Text = SessionAttribute.clienteUser.DatosBasicos.domCalle;
                this.DatosBasicosNroCalle.Text = Convert.ToString(SessionAttribute.clienteUser.DatosBasicos.nroCalle);
                this.DatosBasicosPiso.Text = Convert.ToString(SessionAttribute.clienteUser.DatosBasicos.piso);
                this.DatosBasicosDepto.Text = Convert.ToString(SessionAttribute.clienteUser.DatosBasicos.depto);
                this.DatosBasicosLocalidad.Text = SessionAttribute.clienteUser.DatosBasicos.localidad;
                this.DatosBasicosCodigoPostal.Text = Convert.ToString(SessionAttribute.clienteUser.DatosBasicos.codPostal);
                this.DatosBasicosCiudad.Text = SessionAttribute.clienteUser.DatosBasicos.ciudad;

            }
            else
            {
                        
                this.EmpresaNombreContactoTxt.Text = SessionAttribute.empresaUser.nombreContacto;
                this.EmpresaCuitTxt.Text = SessionAttribute.empresaUser.cuit;
                this.EmpresaRazonSocialTxt.Text = SessionAttribute.empresaUser.razonSocial;

                this.DatosBasicosEmailTxt.Text = SessionAttribute.empresaUser.DatosBasicos.email;
                this.DatosBasicosTelefono.Text = SessionAttribute.empresaUser.DatosBasicos.telefono;
                this.DatosBasicosDomicilioCalle.Text = SessionAttribute.empresaUser.DatosBasicos.domCalle;
                this.DatosBasicosNroCalle.Text = Convert.ToString(SessionAttribute.empresaUser.DatosBasicos.nroCalle);
                this.DatosBasicosPiso.Text = Convert.ToString(SessionAttribute.empresaUser.DatosBasicos.piso);
                this.DatosBasicosDepto.Text = Convert.ToString(SessionAttribute.empresaUser.DatosBasicos.depto);
                this.DatosBasicosLocalidad.Text = SessionAttribute.empresaUser.DatosBasicos.localidad;
                this.DatosBasicosCodigoPostal.Text = Convert.ToString(SessionAttribute.empresaUser.DatosBasicos.codPostal);
                this.DatosBasicosCiudad.Text = SessionAttribute.empresaUser.DatosBasicos.ciudad;

            }
        }
       
        private void Grabar_Click(object sender, EventArgs e)
        {

            String nombreUsuario = userNameInput.Text;
            //String Password = userPasswordImput.Text;
            String TipoDeUsuario = tipoDeUsuarioComboBox.Text;
            String Mail = DatosBasicosEmailTxt.Text;
            String Telefono = DatosBasicosTelefono.Text;
            String DomicilioCalle = DatosBasicosDomicilioCalle.Text;
            Double nroCalle = Convert.ToDouble(DatosBasicosNroCalle.Text);
            Double piso = Convert.ToDouble(DatosBasicosPiso.Text);
            String depto = DatosBasicosDepto.Text;
            String localidad = DatosBasicosLocalidad.Text;
            String ciudad = DatosBasicosCiudad.Text;
            String CodigoPostal = DatosBasicosCodigoPostal.Text;

            int tipoDocumento = 1;
            String Nombre = ClienteNombreTxt.Text;
            String Apellido = ClienteApellidoTxt.Text;

            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(ClienteFechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(EmpresaFechaCreacionDateTime.Value.ToString("dd/MM/yyyy"));
            String RazonSocial = EmpresaRazonSocialTxt.Text;
            String Cuit = EmpresaCuitTxt.Text;
            String NombreContacto = EmpresaNombreContactoTxt.Text;


            if (tipoDeUsuarioComboBox.Text.Equals("Cliente"))
            {
                Double DNI = Convert.ToDouble(ClienteDNITxt.Text);
                Cliente nuevoCliente = new Cliente();
                /*Encriptacion password*/
               /* var mesage = Encoding.UTF8.GetBytes(Password);
                SHA256Managed hashString = new SHA256Managed();
                String pass = "";
                var hashValue = hashString.ComputeHash(mesage);
                foreach (byte x in hashValue)
                {
                    pass += String.Format("{0:x2}", x);
                }*/
                nuevoCliente.userName = nombreUsuario;
                nuevoCliente.password = SessionAttribute.user.password;
                nuevoCliente.activoUsuario = SessionAttribute.user.activoUsuario;
                nuevoCliente.cantidadEstrellas = SessionAttribute.user.cantidadEstrellas;
                nuevoCliente.cantidadVentas = SessionAttribute.user.cantidadVentas;
                nuevoCliente.intentosFallidos = SessionAttribute.user.intentosFallidos;
                nuevoCliente.RolesLst = SessionAttribute.user.RolesLst;
                nuevoCliente.comprasCalificadas = SessionAttribute.clienteUser.comprasCalificadas;
                nuevoCliente.comprasEfectuadas = SessionAttribute.clienteUser.comprasEfectuadas;
                nuevoCliente.idUsuario = SessionAttribute.user.idUsuario;
                nuevoCliente.publicacionGratis = SessionAttribute.clienteUser.publicacionGratis;
                nuevoCliente.perfilActivo = SessionAttribute.clienteUser.perfilActivo;
                nuevoCliente.fechaCreacion = SessionAttribute.clienteUser.fechaCreacion;

                nuevoCliente.dni = DNI;
                nuevoCliente.tipoDocumento = tipoDocumento;
                nuevoCliente.nombre = Nombre;
                nuevoCliente.apellido = Apellido;
                nuevoCliente.fechaNacimiento = FechaNacimiento;
               
               

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
                nuevoCliente.DatosBasicos.idDatosBasicos = SessionAttribute.user.DatosBasicos.idDatosBasicos;

                ClienteDaoImpl ClienteDaoImpl = new ClienteDaoImpl();
                ClienteDaoImpl.Add(nuevoCliente);
            }
            else
            {
                Empresa nuevaEmpresa = new Empresa();
                /*Encriptacion password*/
                /*var mesage = Encoding.UTF8.GetBytes(Password);
                SHA256Managed hashString = new SHA256Managed();
                String pass = "";
                var hashValue = hashString.ComputeHash(mesage);
                foreach (byte x in hashValue)
                {
                    pass += String.Format("{0:x2}", x);
                }*/
                nuevaEmpresa.userName = nombreUsuario;
                nuevaEmpresa.password = SessionAttribute.user.password;
                nuevaEmpresa.activoUsuario = SessionAttribute.user.activoUsuario;
                nuevaEmpresa.idUsuario = SessionAttribute.user.idUsuario;
                nuevaEmpresa.cantidadEstrellas = SessionAttribute.user.cantidadEstrellas;
                nuevaEmpresa.cantidadVentas = SessionAttribute.user.cantidadVentas;
                nuevaEmpresa.intentosFallidos = SessionAttribute.user.intentosFallidos;
                nuevaEmpresa.perfilActivo = SessionAttribute.empresaUser.perfilActivo;
                nuevaEmpresa.RolesLst = SessionAttribute.empresaUser.RolesLst;
                nuevaEmpresa.publicacionGratis = SessionAttribute.empresaUser.publicacionGratis;
                nuevaEmpresa.fechaCreacion = SessionAttribute.empresaUser.fechaCreacion;

                nuevaEmpresa.razonSocial = RazonSocial;
                nuevaEmpresa.cuit = Cuit;
                
                
                nuevaEmpresa.nombreContacto = NombreContacto;
                

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
                nuevaEmpresa.DatosBasicos.idDatosBasicos = SessionAttribute.user.DatosBasicos.idDatosBasicos;
                nuevaEmpresa.nombreContacto = SessionAttribute.empresaUser.nombreContacto;

                EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                empresaDaoImpl.Add(nuevaEmpresa);
            }
           
        }

        private void DatosBasicosCiudad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
