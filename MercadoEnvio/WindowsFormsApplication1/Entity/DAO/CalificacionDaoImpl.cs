using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class CalificacionDaoImpl : CalificacionDao
    {

        public void Add(Calificacion calif)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Calificacion newEntityRef = manager.Session.Merge(calif);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Calificacion calif)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Calificacion newEntityRef = manager.Session.Merge(calif);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Calificacion calif)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Calificacion newEntityRef = manager.Session.Merge(calif);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public int getSecuenciaPubli()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    int sequence = (int)manager.Session.CreateSQLQuery("SELECT current_value FROM [LOPEZ_Y_CIA].[getCodigoCalif]").AddScalar("current_value", NHibernateUtil.Int32).UniqueResult();
                    return sequence;
                }
            }
        }

        public Calificacion GetByCodigo(int codigo)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<Calificacion>();
                crit.Add(Expression.Eq("codigo", codigo));
                return crit.UniqueResult<Calificacion>();
            }
        }

    }     
}
