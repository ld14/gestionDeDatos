using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class NHibernateManager : IDisposable    {
        private static ISessionFactory _sessionFactory;
        public ISession Session;

        public NHibernateManager()
        {
            CreateSession();
            OpenSession();
        }

        private void CreateSession()
        {
            if (_sessionFactory == null)
            {
                Configuration myConfiguration = new Configuration();
                myConfiguration.Configure();
                _sessionFactory = myConfiguration.BuildSessionFactory();
            }

            Session = OpenSession();
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        

        public static void CloseSession()
        {
            _sessionFactory.Dispose();
        }

        #region Miembros de IDisposable
        public void Dispose()
        {
            CloseSession();
        }
        #endregion

    }
}
