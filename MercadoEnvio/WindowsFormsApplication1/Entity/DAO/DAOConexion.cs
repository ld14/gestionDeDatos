using NHibernate;
using NHibernate.Cfg;

namespace WindowsFormsApplication1
{
    class DAOConexion
    {

        private static DAOConexion instance = null;

        private static ISessionFactory SessionFactory;
        private static ISession Session;

        private DAOConexion()  {
            Configuration myConfiguration = new Configuration();
            myConfiguration.Configure();
            SessionFactory = myConfiguration.BuildSessionFactory();
            //mySession = mySessionFactory.OpenSession();

        }

        public static DAOConexion getInstance()  {
            if (instance == null) {
                instance = new DAOConexion();
            }
            return instance;
        }

        public  ISession OpenSession()  {
            if (Session == null) {
                Session = SessionFactory.OpenSession();
            }
            return Session;
        }

        public void CloseSession()  {
            if (Session != null && Session.IsOpen) {
                Session.Flush();
                Session.Close();
            }
            Session = null;
        }

    }
}
