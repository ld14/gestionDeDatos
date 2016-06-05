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
    class UsuarioDaoImpl : UsuarioDao
    {

        public void Add(Usuario user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Usuario newEntityRef = manager.Session.Merge(user);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Usuario user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Usuario newEntityRef = manager.Session.Merge(user);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Usuario user)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Usuario newEntityRef = manager.Session.Merge(user);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public Usuario GetUsuarioById(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.Get<Usuario>(id);
            }
        }

    }     
}
