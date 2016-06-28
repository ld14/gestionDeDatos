using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class SinCalificarDaoImpl : SinCalificarDao
    {

        public void Add(SinCalificar pb)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    SinCalificar newEntityRef = manager.Session.Merge(pb);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(SinCalificar pb)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    SinCalificar newEntityRef = manager.Session.Merge(pb);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(SinCalificar pb)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    SinCalificar newEntityRef = manager.Session.Merge(pb);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }


        public IList<SinCalificar> darLista(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                IList<SinCalificar> asd = manager.Session.CreateCriteria<SinCalificar>().Add(Expression.Eq("idUsuario", id)).List<SinCalificar>();
                return asd;
            }
        }
    }
}
