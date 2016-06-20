using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Rubro;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Visibilidad;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.ComprarOfertar;
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
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;


        public Login()
        {
            InitializeComponent();
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

            //Abro la pagina de Logueo
            pageLogin nuevaPagina = new pageLogin();
            nuevaPagina.ShowDialog();

            //Asigno el Rol correspondiente al Usuario logeado
            IEnumerator<Rol> rolUser = SessionAttribute.user.RolesLst.GetEnumerator();
            rolUser.MoveNext();
            this.Text = "MercadoEnvio [Usuario: " + SessionAttribute.user.idUsuario + "] [Rol: " + rolUser.Current.nombre + "]"; 
 
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


            /*
             * FacturaDaoImpl factDaoImp = new FacturaDaoImpl();
            double nroFactura = factDaoImp.getProfileIdSequence();
            try
            {
            string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);
            Factura nuevaFactura = new Factura();
            IList<ItemFactura> lst = new List<ItemFactura>();

            PublicacionSubastaDaoImpl pb = new PublicacionSubastaDaoImpl();
            PublicacionSubasta pub = pb.GetById(59735);
            
           
            for (int i = 1; i <= 2; i++)
            {
                ItemFactura itmf = new ItemFactura();
                itmf.monto = 20 * i;
                itmf.Factura = nuevaFactura;
                itmf.cantidad = 2 * i;
                lst.Add(itmf);
            }

            
            nuevaFactura.setFacturaNueva(36623, DateTime.Now, 21112, "cash", pub, lst);

            FacturaDaoImpl nuevaFacturaDaoImp = new FacturaDaoImpl();
            nuevaFacturaDaoImp.Add(nuevaFactura);

            


            }
            catch (Exception conect)
            {

                throw;
            }
            
                        
            try
            {
                myConfiguration = new Configuration();
                myConfiguration.Configure();
                mySessionFactory = myConfiguration.BuildSessionFactory();
                mySession = mySessionFactory.OpenSession();
            }
            catch (Exception conect)
            {

                throw;
            }

            
                         try
            {
                BusquedaDePublicacionDaoImpl busquedaDePublicacionDaoImpl = new BusquedaDePublicacionDaoImpl();
                IList<BusquedaDePublicacion> busquedaDePublicacionLts = busquedaDePublicacionDaoImpl.darLista();
            }
            catch (Exception conect)
            {

                throw;
            }
            Estadopublicacion estadoPublicacion = new Estadopublicacion();
            estadoPublicacion.nombre = "Public";
            estadoPublicacion.nombreCorto = "pub";

            Visibilidad visbilidad = new Visibilidad();
            visbilidad.nombreVisibilidad = "plata";
            visbilidad.costo = 20;

            DatosBasicos dtBasicos = new DatosBasicos();
            dtBasicos.setDatosBasicos("queSeYo@hotmail.com", "A", 1, 1, "2", "152", "mata", "cap");

            Cliente cliente = new Cliente("SonUser", "1123", 201965, 1, "Pedro Angel 22", "Poi2", DateTime.Now, dtBasicos);
            PublicacionSubasta nuevaSubasta = new PublicacionSubasta();
            nuevaSubasta.setPublicacionSubasta(estadoPublicacion, visbilidad, cliente, 123, "Es lo que hay", DateTime.Now, DateTime.Now, 12, true, true, 15, 20);

            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            publicacionSubastaDaoImpl.Add(nuevaSubasta);
            */








            //

            /*
             *             comprarOfertarMenu
PublicacionMenu
aBMMenu


             * try
              {
                  myConfiguration = new Configuration();
                  myConfiguration.Configure();
                  mySessionFactory = myConfiguration.BuildSessionFactory();
                  mySession = mySessionFactory.OpenSession();
              }
              catch (Exception conect)            {
                
                  throw;
              }
            

            PublicacionSubastaDaoImpl repositorio = new PublicacionSubastaDaoImpl();
            PublicacionSubasta u = repositorio.GetByUsuario("Regi2222222222");
            Console.Write("Usuario Nombre: " + u.Usuario.userName);
              */

            /*  
              // Add Record
              using (mySession.BeginTransaction())
              {

                  string fechaSistema = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
                  DateTime fehaSistema = DateUtils.convertirStringEnFecha(fechaSistema);
                
                  //Session["fechaSistema"] = fehaSistema;

                  ComisionesParametrizables comisionesParametrizables = new ComisionesParametrizables { nombre = "luis", nombreCorto = "l" , porcentaje=20};

                  //Usuario user = new Usuario();
                  //user.setUsuario("juan", "1234");

                  DatosBasicos dtBasicos = new DatosBasicos();
                  dtBasicos.setDatosBasicos("pedro2@hotmail.com","A","B",1,2,"CCC","mata","cap");

                  //  Cliente cliente = new Cliente("morrey", "123", 28801965, 1, "Pedro Angel 2", "Poi", DateTime.Now, dtBasicos);
                 //   Empresa empresa = new Empresa("hrmindo", "bonanza", dtBasicos, "Tonton SRL", "20-10", DateTime.Now, "Pipo");

                  //Rol rol = new Rol();
                  //rol.nombre = "Vino";
                  //rol.activo = true;

                  //List <Funciones> lst = new List<Funciones>();
                  //for (int i = 1; i <= 2; i++) 
                  //    Funciones fuc = new Funciones();
                  //    fuc.nombre = i.ToString();
                  //    fuc.descripcion = i.ToString() + "descripcion";
                  //    lst.Add(fuc);
                  //}

                  //rol.FuncionesLst = lst;
                  Estadopublicacion estadoPublicacion = new Estadopublicacion();
                  estadoPublicacion.nombre = "Public";
                  estadoPublicacion.nombreCorto = "pub";

                  Visibilidad visbilidad = new Visibilidad();
                  visbilidad.nombreVisibilidad = "plata";
                  visbilidad.costo = 20;

                  Cliente cliente = new Cliente("Regi2222222222", "123", 28801965, 1, "Pedro Angel 2", "Poi", DateTime.Now, dtBasicos);
                

                  //Publicacion publicacion = new Publicacion();
                  //publicacion.setPubicacion(estadoPublicacion, visbilidad, cliente, 12, "Soy un poducto", DateTime.Now, DateTime.Now, 12, true, true);

                  //Publicacion nuevaPublicacion = new Publicacion();
                  //nuevaPublicacion.setPublicacion(estadoPublicacion, visbilidad, cliente, 123, "Es lo que hay", DateTime.Now, DateTime.Now, 12, true, true);

                  PublicacionSubasta nuevaSubasta = new PublicacionSubasta();
                  nuevaSubasta.setPublicacionSubasta(estadoPublicacion, visbilidad, cliente, 123, "Es lo que hay", DateTime.Now, DateTime.Now, 12, true, true,15,20);

                  HashSet<ItemFactura> lst = new HashSet<ItemFactura>();
                  for (int i = 1; i <= 2; i++)
                  {
                      ItemFactura itmf = new ItemFactura();
                      itmf.monto = 20 * i;
                      itmf.cantidad = 2 * i;
                      lst.Add(itmf);
                  }

                  Factura nuevaFactura = new Factura();
                  nuevaFactura.setFacturaNueva(123, DateTime.Now, 22, "cash", nuevaSubasta, lst);


				
				

                  try
                  {
                      mySession.Save(nuevaSubasta);
                      mySession.Transaction.Commit();
                  }
                  catch (Exception es)
                  {
                    
                      throw;
                  }
                
            
                
              }*/

            // List Contact

            //using (mySession.BeginTransaction())
            //{
            //  ICriteria criteria = mySession.CreateCriteria<Contact>();
            // IList<Contact> list = criteria.List<Contact>();

            //                mySession.Transaction.Commit();
            //          }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarioPage paginaAltaUsuario = new AltaUsuarioPage();
            paginaAltaUsuario.MdiParent = this;
            paginaAltaUsuario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolUsuarioPage rolUsuarioPage = new RolUsuarioPage();
            rolUsuarioPage.MdiParent = this;
            rolUsuarioPage.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RubroPage rubroPage = new RubroPage();
            rubroPage.MdiParent = this;
            rubroPage.Show();
        }

        private void visibToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPage visibilidadPage = new VisibilidadPage();
            visibilidadPage.MdiParent = this;
            visibilidadPage.Show();
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerarPublicacionPage generarPublicacionPage = new GenerarPublicacionPage();
            generarPublicacionPage.Text = "init";
            generarPublicacionPage.MdiParent = this;
            generarPublicacionPage.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPublicacionPage modificarPublicacionPage = new ModificarPublicacionPage();
            modificarPublicacionPage.MdiParent = this;
            modificarPublicacionPage.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscadorPublicacion buscadorPublicaciones = new BuscadorPublicacion();
            buscadorPublicaciones.MdiParent = this;
            buscadorPublicaciones.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BusquedaPublicacion busquedaPublicacion = new BusquedaPublicacion();
            busquedaPublicacion.MdiParent = this;
            busquedaPublicacion.Show();
        }

        private void comprarOfertarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CompraVentaForm compraVentaForm = new CompraVentaForm();
            compraVentaForm.MdiParent = this;
            compraVentaForm.Show();
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

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CalificacionesPage calificacion = new CalificacionesPage();

            calificacion.Text = "init";
            calificacion.MdiParent = this;
           calificacion.Show();
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuarioPage usuario = new ModificarUsuarioPage();
            usuario.Text = "init";
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
