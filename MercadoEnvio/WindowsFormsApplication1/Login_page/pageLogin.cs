﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using WindowsFormsApplication1.Entity.Utils;
using System.Threading;

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

            if (usr != null)
            {
                var psw = Encoding.UTF8.GetBytes(password.Text);
                SHA256Managed hashString = new SHA256Managed();
                String hashedPass = "";
                var hashValue = hashString.ComputeHash(psw);
                foreach (byte x in hashValue)
                {
                    hashedPass += String.Format("{0:x2}", x);
                }

                if (!usr.activoUsuario)
                {
                    pswError.SetError(this.password, "El usuario se encuentra desactivado");
                    return;
                }

                if (usr.password == hashedPass)
                {
                    SessionAttribute.user = usr;
                    usr.intentosFallidos = 0;
                    this.Close();
                }
                else
                {
                    pswError.SetError(this.password, "Contraseña incorrecta");
                    usr.intentosFallidos++;

                    if (usr.intentosFallidos == 3)
                    {
                        MessageBox.Show("Ha ingresado mal su contraseña 3 veces. Para su seguridad hemos bloqueado su cuenta. Por favor, Contactese con el administrador");
                        usr.activoUsuario = false;
                        usuario.Update(usr);
                        Application.Exit();
                    }
                }
                usuario.Update(usr);
            }
            else
            {
                pswError.SetError(this.password, "Verificar Datos Ingresados");
            }
        }
    }
}