using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    class PublicacionSubastaDaoImpl : PublicacionSubastaDao  {

        public void Add(PublicacionSubasta publicacionSubasta) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(publicacionSubasta);
                    transaction.Commit();
                }
            }
        }

        public void Update(PublicacionSubasta publicacionSubasta)  {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(publicacionSubasta);
                    transaction.Commit();
                }
            }
        }

        public void Remove(PublicacionSubasta publicacionSubasta) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(publicacionSubasta);
                    transaction.Commit();
                }
            }
        }

        public PublicacionSubasta GetById(int id)   {
            using (NHibernateManager manager = new NHibernateManager())  {
                return manager.Session.Get<PublicacionSubasta>(id) ;
            }
        }

        public PublicacionSubasta GetByUsuario(string usuario)        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<PublicacionSubasta>();
                crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("usr.userName",usuario));
                return crit.UniqueResult<PublicacionSubasta>();

        }
    }

    }
}
