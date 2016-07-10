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

        public IList<Cliente> getAllClienteActivos()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<Cliente>();
                    crit.Add(Expression.Eq("perfilActivo", true));
                    return crit.List<Cliente>();
                }
            }
        }

        public IList<Cliente> darClientesFiltrados(String nombre, String apellido, String email, Int32 dni)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<Cliente>();

                if (!nombre.Equals(""))
                {
                    crit.Add(Expression.Like("nombre", "%" + nombre + "%"));
                }
                if (!apellido.Equals(""))
                {
                    crit.Add(Expression.Like("apellido", "%" + apellido + "%"));
                }
                if (!email.Equals(""))
                {
                    crit.CreateAlias("DatosBasicos", "datoBasico");
                    crit.Add(Expression.Like("datoBasico.email", "%" + email + "%"));
                }

                if (!dni.Equals(0))
                {
                    crit.Add(Expression.Eq("dni", dni));
                }

                return crit.List<Cliente>();
            }
        }
    }     
}
