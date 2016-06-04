using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class RubroDaoImpl : RubroDao    {

        public void Add(Rubro rubro)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(rubro);
                    transaction.Commit();
                }
            }
        }

        public void Update(Rubro rubro)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(rubro);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Rubro rubro)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(rubro);
                    transaction.Commit();
                }
            }
        }



        public IList<Rubro> darRubroActivo()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Rubro>();
                return crit.List<Rubro>(); 
                

        }
    }

    }
}
