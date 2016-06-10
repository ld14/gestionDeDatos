using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class SubastaCompraDelSistemaDaoImpl : SubastaCompraDelSistemaDao
    {

        public void Add(SubastaCompraDelSistema SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SubastaCompraDelSistema newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(SubastaCompraDelSistema SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SubastaCompraDelSistema newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(SubastaCompraDelSistema SubastaCompra)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    SubastaCompraDelSistema newEntityRef = manager.Session.Merge(SubastaCompra);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public IList<SubastaCompraDelSistema> darSubastaCompra(int idUsuario)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<SubastaCompraDelSistema>();
                    crit.Add(Expression.Eq("idUsuario", idUsuario));
                    return crit.List<SubastaCompraDelSistema>();

                }
        }
    }

    }
}
