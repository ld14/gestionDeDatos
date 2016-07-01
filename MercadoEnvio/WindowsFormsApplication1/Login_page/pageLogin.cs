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

namespace WindowsFormsApplication1.Login_page
{
    public partial class pageLogin : Form
    {
        public pageLogin()
        {
            InitializeComponent();
        }

        private void pageLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider pswError = new ErrorProvider();
            pswError.SetIconAlignment(this.password, ErrorIconAlignment.MiddleRight);
            pswError.SetIconPadding(this.password, 2);

            pswError.SetError(this.password, "");
            pswError.Clear();

            UsuarioDaoImpl usuario = new UsuarioDaoImpl();
            Usuario usr = usuario.Acceder(userName.Text);
           
            if ((usr != null))
            {
                if ((usr.intentosFallidos < 3) && (usr.activoUsuario = true))
                {
                    var psw = Encoding.UTF8.GetBytes(password.Text);
                    SHA256Managed hashString = new SHA256Managed();
                    String hashedPass = "";
                    var hashValue = hashString.ComputeHash(psw);
                    foreach (byte x in hashValue)
                    {
                        hashedPass += String.Format("{0:x2}", x);
                    }

                    if (usr.password == hashedPass)
                    {
                        usr.intentosFallidos = 0;
                        usuario.Update(usr);
                        SessionAttribute.user = usr;
                        this.Close();
                    }
                    else
                    {
                        pswError.SetError(this.password, "Contraseña incorrecta");
                        usr.intentosFallidos++;
                        usuario.Update(usr);

                    }
                }
                else {
                    pswError.SetError(this.password, "Verificar Datos Ingresados");
                    usr.activoUsuario = false;
                    usuario.Update(usr);
                    MessageBox.Show("Contactese con el administrador");
                    this.Close();
                    Application.Exit();
                    
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto, Intente nuevamente");
            }
        }
    }
}
