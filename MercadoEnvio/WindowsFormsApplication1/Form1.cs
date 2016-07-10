﻿using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Rubro;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Visibilidad;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.ComprarOfertar;
using WindowsFormsApplication1.Entity.DAO;
using WindowsFormsApplication1.Entity.Utils;
using WindowsFormsApplication1.Facturas;
using WindowsFormsApplication1.Generar_Publicación;
using WindowsFormsApplication1.Historial_Cliente;
using WindowsFormsApplication1.Listado_Estadistico;
using WindowsFormsApplication1.Login_page;



namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int length = 0;
        loading nuevaPagina;

        public async void funcionAsync()
        {
            length = await ExampleMethodAsync();
            nuevaPagina.timer1_Tick();
        }

        public async Task<int> ExampleMethodAsync()
        {
            int hours = 1;
            await Task.Run(() =>
            {
                PublicacionNormalDaoImpl DAO = new PublicacionNormalDaoImpl();
                IList<PublicacionNormal> normales = DAO.GetAll();

                PublicacionSubastaDaoImpl DAO2 = new PublicacionSubastaDaoImpl();
                IList<PublicacionSubasta> subs = DAO2.GetAll();

                foreach (PublicacionNormal pubNormal in normales)
                {
                    if (pubNormal.fechaVencimiento < DateTime.ParseExact(SessionAttribute.fechaSistema, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    {
                        pubNormal.EstadoPublicacion.idEstadoPublicacion = 4;
                        DAO.Update(pubNormal);
                    }
                }

                foreach (PublicacionSubasta pubSubasta in subs)
                {
                    if (pubSubasta.fechaVencimiento < DateTime.ParseExact(SessionAttribute.fechaSistema, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    {
                        pubSubasta.EstadoPublicacion.idEstadoPublicacion = 4;
                        DAO2.Update(pubSubasta);
                    }
                }
            });
            return hours;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Oculto todas las funcionalidades
            aBMMenu.Visible = false;
            PublicacionMenu.Visible = false;
            comprarOfertarMenu.Visible = false;
            calificacionesToolStripMenuItem.Visible = false;
            historialDeCompraMenu.Visible = false;
            estadisticasToolStripMenuItem.Visible = false;
            facturacionToolStripMenuItem.Visible = false;
            misDatosToolStripMenuItem.Visible = false;

            SessionAttribute.fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"]; 

            funcionAsync();

            //Abro la pagina de Logueo
            nuevaPagina = new loading();
            nuevaPagina.ShowDialog();

            pageLogin form2 = new pageLogin();
            form2.ShowDialog();

            //Asigno el Rol correspondiente al Usuario logeado
            IEnumerator<Rol> rolUser = SessionAttribute.user.RolesLst.GetEnumerator();
            rolUser.MoveNext();

            this.Text = "MercadoEnvio [Usuario: " + SessionAttribute.user.userName + "] [Rol: " + rolUser.Current.nombre + "] [Fecha: " + SessionAttribute.fechaSistema + "]"; 
 
            //Obtener datos del Usuario
            if (rolUser.Current.idRol == 1)
            {
                ClienteDaoImpl cli = new ClienteDaoImpl();
                SessionAttribute.clienteUser = cli.GetUsuarioById(SessionAttribute.user.idUsuario);
            }
            if (rolUser.Current.idRol == 2)
            {
                EmpresaDaoImpl emp = new EmpresaDaoImpl();
                SessionAttribute.empresaUser = emp.GetEmpresaByIdUsuario(SessionAttribute.user.idUsuario);
            }
            
            //Habilito funcionalidades segun Usuario
            RolDaoImpl rl = new RolDaoImpl();
            IList<Funciones> func = rl.obtenerFuncionesPorRol(rolUser.Current.idRol);
            foreach (Funciones funcion in func)
            {
                switch (funcion.idFunciones)
                {
                    case 1:
                        aBMMenu.Visible = true;
                        break;
                    case 2:
                        PublicacionMenu.Visible = true;
                        break;
                    case 3:
                        comprarOfertarMenu.Visible = true;
                        break;
                    case 4:
                        historialDeCompraMenu.Visible = true;
                        break;
                    case 5:
                        facturacionToolStripMenuItem.Visible = true;
                        break;
                    case 6:
                        estadisticasToolStripMenuItem.Visible = true;
                        break;
                    case 7:
                        misDatosToolStripMenuItem.Visible = true;
                        break;
                    case 8:
                        calificacionesToolStripMenuItem.Visible = true;
                        break;
                }
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarioPage paginaAltaUsuario = new AltaUsuarioPage();
            paginaAltaUsuario.MdiParent = this;
            paginaAltaUsuario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaRolUsuarioPage rolUsuarioPage = new AltaRolUsuarioPage();
            rolUsuarioPage.MdiParent = this;
            rolUsuarioPage.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaRubroPage rubroPage = new AltaRubroPage();
            rubroPage.MdiParent = this;
            rubroPage.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaVisibilidadPage visibilidadPage = new AltaVisibilidadPage();
            visibilidadPage.MdiParent = this;
            visibilidadPage.Show();
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente tipoCliente = SessionAttribute.clienteUser;
            Empresa tipoEmpresa = SessionAttribute.empresaUser;

            if (tipoCliente == null && tipoEmpresa == null)
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
            else
            {
                GenerarPublicacionPage generarPublicacionPage = new GenerarPublicacionPage();
                generarPublicacionPage.Text = "init";
                generarPublicacionPage.MdiParent = this;
                generarPublicacionPage.Show();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente tipoCliente = SessionAttribute.clienteUser;
            Empresa tipoEmpresa = SessionAttribute.empresaUser;

            if (tipoCliente == null && tipoEmpresa == null)
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
            else
            {
                BuscadorPublicacion buscadorPublicaciones = new BuscadorPublicacion();
                buscadorPublicaciones.MdiParent = this;
                buscadorPublicaciones.Show();
            }
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BusquedaPublicacion busquedaPublicacion = new BusquedaPublicacion();
            busquedaPublicacion.MdiParent = this;

            Cliente usr = SessionAttribute.clienteUser;
            if (usr == null)
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
            else
            {
                if (usr.comprasEfectuadas > usr.comprasCalificadas + 3)
                {
                    MessageBox.Show("Deberá calificar sus ultimas operaciones antes de seguir comprando");
                    busquedaPublicacion.Close();
                }
                else busquedaPublicacion.Show();
            }
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Empresa tipoEmpresa = SessionAttribute.empresaUser;

            if (tipoEmpresa == null)
            {
                CompraVentaForm compraVentaForm = new CompraVentaForm();
                compraVentaForm.MdiParent = this;
                compraVentaForm.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
        }

        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FacturasEmitidasForm facturasEmitidasFormForm = new FacturasEmitidasForm();
            facturasEmitidasFormForm.MdiParent = this;
            facturasEmitidasFormForm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEstadisitico facturasEmitidasFormForm = new ListadoEstadisitico();
            facturasEmitidasFormForm.MdiParent = this;
            facturasEmitidasFormForm.Show();
        }

        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ModificarUsuarioPorAdminPage modificarUsuarionPage = new ModificarUsuarioPorAdminPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente usr = SessionAttribute.clienteUser;

            if (usr == null)
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
            else
            {
                CalificacionesPage calificacion = new CalificacionesPage();

                calificacion.Text = "init";
                calificacion.MdiParent = this;
                calificacion.Show();
            }
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente tipoCliente = SessionAttribute.clienteUser;
            Empresa tipoEmpresa = SessionAttribute.empresaUser;

            if (tipoCliente == null && tipoEmpresa == null)
            {
                MessageBox.Show("No tienes acceso a esta funcionalidad porque no le corresponde a este tipo de usuario");
            }
            else
            {
                ModificarUsuarioPage usuario = new ModificarUsuarioPage();
                usuario.Text = "init";
                usuario.MdiParent = this;
                usuario.Show();
            }
        }

        private void modificarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          
            ModificarRolPage modificarUsuarionPage = new ModificarRolPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            ModificarVisibilidadPage modificarUsuarionPage = new ModificarVisibilidadPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        
        }

        private void elimiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuarioPage modificarUsuarionPage = new EliminarUsuarioPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarRolPage modificarUsuarionPage = new EliminarRolPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarVisibilidadPage modificarUsuarionPage = new EliminarVisibilidadPage();
            modificarUsuarionPage.MdiParent = this;
            modificarUsuarionPage.Show();
        
        }
    }
}
