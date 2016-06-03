using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class EstadoPublicacionDaoDaoImpl : EstadoPublicacionDao     {

        public void Add(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(estadopublicacion);
                    transaction.Commit();
                }
            }
        }

        public void Update(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(estadopublicacion);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(estadopublicacion);
                    transaction.Commit();
                }
            }
        }



        public IList<Estadopublicacion> darEstados()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Estadopublicacion>();

                return crit.List<Estadopublicacion>(); 
                

        }
    }

    }
}
