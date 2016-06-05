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
                    Cliente newEntityRef = manager.Session.Merge(user);
                    manager.Session.Save(newEntityRef);
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
                    Cliente newEntityRef = manager.Session.Merge(user);
                    manager.Session.Update(newEntityRef);
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
                    Cliente newEntityRef = manager.Session.Merge(user);
                    manager.Session.Delete(newEntityRef);
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
