using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class FacturasEmitidasDaoImpl : FacturasEmitidasDao
    {

        public void Add(FacturasEmitidas factEmitidas)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    FacturasEmitidas newEntityRef = manager.Session.Merge(factEmitidas);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(FacturasEmitidas factEmitidas)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    FacturasEmitidas newEntityRef = manager.Session.Merge(factEmitidas);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(FacturasEmitidas factEmitidas)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    FacturasEmitidas newEntityRef = manager.Session.Merge(factEmitidas);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public IList<FacturasEmitidas> darRolActivo()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {

                ICriteria crit = manager.Session.CreateCriteria<FacturasEmitidas>();
                return crit.List<FacturasEmitidas>();


            }
        }
        public IList<FacturasEmitidas> darFacturasEmitidas(int idUsuario, DateTime fechaDesde, DateTime fechaHasta, string descripcion)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<FacturasEmitidas>();

                    if (idUsuario != 0) {
                        crit.Add(Expression.Eq("idUsuario", idUsuario));                
                    }

                    crit.Add(Expression.Between("fecha", fechaDesde, fechaHasta));

                    if(!descripcion.Equals("")){
                        crit.Add(Expression.Like("descripcion", "%" + descripcion + "%"));  
                    }

                    return crit.List<FacturasEmitidas>();
                }
            }
        }
    }
}