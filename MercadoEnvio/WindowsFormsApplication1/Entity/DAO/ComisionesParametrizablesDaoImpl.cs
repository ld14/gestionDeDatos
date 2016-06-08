using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class ComisionesParametrizablesDaoImpl : ComisionesParametrizablesDao
    {

        public void Add(ComisionesParametrizables comi)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    ComisionesParametrizables newEntityRef = manager.Session.Merge(comi);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(ComisionesParametrizables comi)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    ComisionesParametrizables newEntityRef = manager.Session.Merge(comi);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(ComisionesParametrizables comi)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    ComisionesParametrizables newEntityRef = manager.Session.Merge(comi);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public ComisionesParametrizables darComisionesParametrizablesByNombreCorto(string nombreCorto) {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<ComisionesParametrizables>();
                    crit.Add(Expression.Eq("nombreCorto", nombreCorto));
                    return crit.UniqueResult<ComisionesParametrizables>();
                }
            }
        }



    }
}
