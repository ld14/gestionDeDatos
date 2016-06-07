using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    class PublicacionNormalDaoImpl : PublicacionNormalDao
    {

        public void Add(PublicacionNormal publicacionNormal) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {

                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(PublicacionNormal publicacionNormal)        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.SaveOrUpdate(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(PublicacionNormal publicacionNormal)        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public PublicacionNormal GetById(int id)        {
            using (NHibernateManager manager = new NHibernateManager())  {
                return manager.Session.Get<PublicacionNormal>(id);
            }
        }

        public PublicacionNormal GetByUsuario(string usuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionNormal>();
                crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("usr.userName", usuario));
                return crit.UniqueResult<PublicacionNormal>();

            }
        }

        public   IList<PublicacionNormal> GetPublicacionByUsuario(Usuario usuario)     {
            using (NHibernateManager manager = new NHibernateManager()) {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionNormal>();
                //crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("Usuario", usuario));
                return crit.List<PublicacionNormal>();
            }
         }

    }
}
