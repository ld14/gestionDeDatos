using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class VisibilidadDaoImpl : VisibilidadDao
    {

        public void Add(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(visibilidad);
                    transaction.Commit();
                }
            }
        }

        public void Update(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(visibilidad);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(visibilidad);
                    transaction.Commit();
                }
            }
        }



        public IList<Visibilidad> darVisibilidad()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Visibilidad>();
                return crit.List<Visibilidad>(); 
                

        }
    }

    }
}
