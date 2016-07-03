using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class SoloSubastaDaoImpl : SoloSubastaDao
    {

        public void Add(SoloSubasta SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SoloSubasta newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(SoloSubasta SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SoloSubasta newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(SoloSubasta SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SoloSubasta newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public IList<SoloSubasta> darSubastasParticipadas(int idUsuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<SoloSubasta>();
                    crit.Add(Expression.Eq("idUsuario", idUsuario));
                    return crit.List<SoloSubasta>();
                }
            }
        } 

    }
}
