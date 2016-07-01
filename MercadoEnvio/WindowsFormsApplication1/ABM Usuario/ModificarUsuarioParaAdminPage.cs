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
    public partial class ModificarUsuarioParaAdminPage : Form
    {
        Boolean esTipoRolEmpresa = false;
        Int32 idUsuario = -1;
        public ModificarUsuarioParaAdminPage()
        {
            InitializeComponent();
        }

        public void setearCliente(Cliente cliente)
        {
            esTipoRolEmpresa = false;
            idUsuario = cliente.idUsuario;
            userNameInput.Text = cliente.userName;
            tipoDeUsuarioComboBox.Text = cliente.nombre;
            ClienteGroup.Visible = true;
            EmpresaGroup.Visible = false;

            ClienteApellidoTxt.Text = cliente.apellido;
            ClienteNombreTxt.Text = cliente.nombre;
            ClienteDNITxt.Text = cliente.dni.ToString();
            ClienteTipoDocComboBox.Text = Convert.ToString(cliente.tipoDocumento);

            DatosBasicosEmailTxt.Text = cliente.DatosBasicos.email;
            DatosBasicosTelefono.Text = cliente.DatosBasicos.telefono;
            DatosBasicosDomicilioCalle.Text = cliente.DatosBasicos.domCalle;
            DatosBasicosNroCalle.Text = Convert.ToString(cliente.DatosBasicos.nroCalle);
            DatosBasicosPiso.Text = Convert.ToString(cliente.DatosBasicos.piso);
            DatosBasicosDepto.Text = Convert.ToString(cliente.DatosBasicos.depto);
            DatosBasicosLocalidad.Text = cliente.DatosBasicos.localidad;
            DatosBasicosCodigoPostal.Text = Convert.ToString(cliente.DatosBasicos.codPostal);
            DatosBasicosCiudad.Text = cliente.DatosBasicos.ciudad;
        }

        public void setearEmpresa(Empresa empresa)
        {
            esTipoRolEmpresa = true;
            idUsuario = empresa.idUsuario;
            EmpresaGroup.Visible = true;
            ClienteGroup.Visible = false;

            EmpresaNombreContactoTxt.Text = empresa.nombreContacto;
            EmpresaCuitTxt.Text = empresa.cuit;
            EmpresaRazonSocialTxt.Text = empresa.razonSocial;

            DatosBasicosEmailTxt.Text = empresa.DatosBasicos.email;
            DatosBasicosTelefono.Text = empresa.DatosBasicos.telefono;
            DatosBasicosDomicilioCalle.Text = empresa.DatosBasicos.domCalle;
            DatosBasicosNroCalle.Text = Convert.ToString(empresa.DatosBasicos.nroCalle);
            DatosBasicosPiso.Text = Convert.ToString(empresa.DatosBasicos.piso);
            DatosBasicosDepto.Text = Convert.ToString(empresa.DatosBasicos.depto);
            DatosBasicosLocalidad.Text = empresa.DatosBasicos.localidad;
            DatosBasicosCodigoPostal.Text = Convert.ToString(empresa.DatosBasicos.codPostal);
            DatosBasicosCiudad.Text = empresa.DatosBasicos.ciudad;
        }
       
        private void Grabar_Click(object sender, EventArgs e)
        {
            String nombreUsuario = userNameInput.Text;
            String password = userPasswordImput.Text;
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
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(EmpresaFechaCreacionDateTime.Value.ToString("dd/MM/yyyy"));
            //DATOS DEL CLIENTE----------------------
            int tipoDocumento = 1;
            String Nombre = ClienteNombreTxt.Text;
            String Apellido = ClienteApellidoTxt.Text;
            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(ClienteFechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            //---------------------------------------
            //DATOS DE LA EMPRESA--------------------
            String RazonSocial = EmpresaRazonSocialTxt.Text;
            String Cuit = EmpresaCuitTxt.Text;
            String NombreContacto = EmpresaNombreContactoTxt.Text;
            //---------------------------------------

            if (esTipoRolEmpresa == false)
            {
                int DNI = Convert.ToInt32(ClienteDNITxt.Text);
                ClienteDaoImpl clienteDaoImpl = new ClienteDaoImpl();
                Cliente nuevoCliente = clienteDaoImpl.GetUsuarioById(idUsuario);
                
                nuevoCliente.password = password;

                nuevoCliente.dni = DNI;
                nuevoCliente.tipoDocumento = tipoDocumento;
                nuevoCliente.nombre = Nombre;
                nuevoCliente.apellido = Apellido;
                nuevoCliente.fechaNacimiento = FechaNacimiento;
               
                nuevoCliente.DatosBasicos.email = Mail;
                nuevoCliente.DatosBasicos.telefono = Telefono;
                nuevoCliente.DatosBasicos.domCalle = DomicilioCalle;
                nuevoCliente.DatosBasicos.nroCalle = nroCalle;
                nuevoCliente.DatosBasicos.piso = piso;
                nuevoCliente.DatosBasicos.depto = depto;
                nuevoCliente.DatosBasicos.codPostal = CodigoPostal;
                nuevoCliente.DatosBasicos.localidad = localidad;
                nuevoCliente.DatosBasicos.ciudad = ciudad;

                clienteDaoImpl.Update(nuevoCliente);
            }
            else
            {
                EmpresaDaoImpl empresaDaoImpl = new EmpresaDaoImpl();
                Empresa nuevaEmpresa = empresaDaoImpl.GetEmpresaByIdUsuario(idUsuario);

                nuevaEmpresa.password = password;

                nuevaEmpresa.razonSocial = RazonSocial;
                nuevaEmpresa.cuit = Cuit;
                
                nuevaEmpresa.nombreContacto = NombreContacto;
                
                nuevaEmpresa.DatosBasicos.email = Mail;
                nuevaEmpresa.DatosBasicos.telefono = Telefono;
                nuevaEmpresa.DatosBasicos.domCalle = DomicilioCalle;
                nuevaEmpresa.DatosBasicos.nroCalle = nroCalle;
                nuevaEmpresa.DatosBasicos.piso = piso;
                nuevaEmpresa.DatosBasicos.depto = depto;
                nuevaEmpresa.DatosBasicos.codPostal = CodigoPostal;
                nuevaEmpresa.DatosBasicos.localidad = localidad;
                nuevaEmpresa.DatosBasicos.ciudad = ciudad;
                nuevaEmpresa.nombreContacto = NombreContacto;

                empresaDaoImpl.Update(nuevaEmpresa);
            }
            MessageBox.Show("Datos modificados con éxito");
        }
    }
}
