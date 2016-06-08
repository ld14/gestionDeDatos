using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class FacturaDaoImpl : FacturaDao
    {

        public void Add(Factura factura)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Factura newEntityRef = manager.Session.Merge(factura);
                    manager.Session.SaveOrUpdate(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Factura factura)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Factura newEntityRef = manager.Session.Merge(factura);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Factura factura)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Factura newEntityRef = manager.Session.Merge(factura);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public Factura darFacturaByPublicacionID(int id)    {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Factura>();
                crit.CreateAlias("Publicacion", "pub");
                crit.Add(Expression.Eq("pub.idPublicacion", id));
                return crit.UniqueResult<Factura>();
                

        }
    }

    }
}
