using NHibernate;
using NHibernate.Cfg;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using WindowsFormsApplication1.Login_page;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Rubro;
using WindowsFormsApplication1.ABM_Visibilidad;
using WindowsFormsApplication1.Generar_Publicación;



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
            /*
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

            pageLogin nuevaPagina = new pageLogin();
            nuevaPagina.MdiParent = this;
            ///Hola...2222
            nuevaPagina.Show();



            /*
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
    }
}
