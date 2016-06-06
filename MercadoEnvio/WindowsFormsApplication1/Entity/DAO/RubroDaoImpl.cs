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
                    Rubro newEntityRef = manager.Session.Merge(rubro);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Rubro rubro)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Rubro newEntityRef = manager.Session.Merge(rubro);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Rubro rubro)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Rubro newEntityRef = manager.Session.Merge(rubro);
                    manager.Session.Delete(newEntityRef);
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

        public IList<Rubro> darRubroDistintosA(ICollection<Rubro> rubrosLts) {
            using (NHibernateManager manager = new NHibernateManager()) {
                List<int> idRubroLts = new List<int>();
                foreach(Rubro rb in rubrosLts){
                    idRubroLts.Add(rb.idRubro);
                }
                ICriteria crit = manager.Session.CreateCriteria<Rubro>();
                crit.Add(Expression.Not(Expression.In("idRubro",idRubroLts)));
                return crit.List<Rubro>(); 
            }
        }
    }
}
