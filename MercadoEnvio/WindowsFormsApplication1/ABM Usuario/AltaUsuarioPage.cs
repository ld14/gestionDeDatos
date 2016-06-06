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
            //MessageBox.Show(nombreUsuario);
            String Password = textBox2.Text;
            String TipoDeUsuario = comboBox1.Text;
            String RazonSocial = ClienteRazonSocialTxt.Text;
            String Cuit = ClienteCuitTxt.Text;
            String NombreContacto = ClienteNombreContactoTxt.Text;
            String Mail = textBox16.Text;
            String Telefono = textBox15.Text;
            String DomicilioCalle = textBox1.Text;
            Double nroCalle = Convert.ToDouble(textBox11.Text);
            Double piso =  Convert.ToDouble(textBox12.Text);
            String depto = textBox13.Text;
            String localidad = textBox8.Text;
            String ciudad = textBox3.Text;
            String CodigoPostal = textBox9.Text;
            
            int tipoDocumento = 1;//Convert.ToInt32(ClienteTipoDocComboBox.Text);
            Double DNI = Convert.ToDouble(ClienteDNITxt.Text);
            String Nombre = ClienteNombreTxt.Text;
            String Apellido = ClienteApellidoTxt.Text;

            DateTime FechaNacimiento = DateUtils.convertirStringEnFecha(ClienteFechaNacDateTime.Value.ToString("dd/MM/yyyy"));
            DateTime FechaCreacion = DateUtils.convertirStringEnFecha(FechaCreacionDateTime.Value.ToString("dd/MM/yyyy"));

            if (comboBox1.Text.Equals("Cliente"))
            {
                Cliente nuevoCliente = new Cliente();

                nuevoCliente.userName = "";
                nuevoCliente.password = ""; //Colocar Algoritmo de Encriptacion
                
                nuevoCliente.dni = DNI;
                nuevoCliente.tipoDocumento = tipoDocumento;
                nuevoCliente.nombre = Nombre;
                nuevoCliente.apellido = Apellido;
                nuevoCliente.fechaNacimiento = FechaNacimiento;
                // ver si joaco lo pone cuando detecta un usuario nuevo tanto el perfil activo como compras y calificadas
                nuevoCliente.perfilActivo = true;
                nuevoCliente.fechaCreacion = FechaCreacion;
                nuevoCliente.comprasEfectuadas = 0;
                nuevoCliente.comprasCalificadas = 0;

                DatosBasicos nuevoDatoBasico = new DatosBasicos();
                nuevoCliente.DatosBasicos = nuevoDatoBasico;

                nuevoCliente.DatosBasicos.email = Mail;
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
                nuevaEmpresa.razonSocial = RazonSocial;
                nuevaEmpresa.cuit = Cuit;
                nuevaEmpresa.fechaCreacion = FechaCreacion;
                //nuevaEmpresa.perfilActivo = true;// aca hay que cambiar en la tabla el tipo de dato a bool ya que figura int
                nuevaEmpresa.nombreContacto = NombreContacto;
                
                nuevaEmpresa.DatosBasicos.email = Mail;
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

        }
    
}

