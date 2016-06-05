using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class ClienteDaoImpl : ClienteDao
    {

        public void Add(Cliente user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Save(user);
                    transaction.Commit();
                }
            }
        }

        public void Update(Cliente user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Update(user);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Cliente user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Delete(user);
                    transaction.Commit();
                }
            }
        }

        public Cliente GetUsuarioById(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.Get<Cliente>(id);
            }
        }

    }     
}
