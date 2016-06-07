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

                    PublicacionSubasta newEntityRef = manager.Session.Merge(publicacionSubasta); //getSession().merge(entity);  
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(PublicacionSubasta publicacionSubasta)  {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionSubasta newEntityRef = manager.Session.Merge(publicacionSubasta); //getSession().merge(entity);  
                    manager.Session.SaveOrUpdate(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(PublicacionSubasta publicacionSubasta) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionSubasta newEntityRef = manager.Session.Merge(publicacionSubasta); //getSession().merge(entity);  
                    manager.Session.Delete(newEntityRef);
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

        public IList<PublicacionSubasta> GetPublicacionByUsuario(Usuario usuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionSubasta>();
                crit.Add(Expression.Eq("Usuario", usuario));
                crit.CreateAlias("EstadoPublicacion", "estado");
                crit.Add(Expression.Not(Expression.Eq("estado.nombre", "Finalizada")));
                return crit.List<PublicacionSubasta>();
            }
        }

    }
}
