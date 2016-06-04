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
                    manager.Session.Save(user);
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
                    manager.Session.Update(user);
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
                    manager.Session.Delete(user);
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
