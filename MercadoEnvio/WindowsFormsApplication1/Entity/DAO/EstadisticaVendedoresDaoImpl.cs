using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;
using WindowsFormsApplication1.Listado_Estadistico;


namespace WindowsFormsApplication1
{
    class EstadisticaVendedoresDaoImpl : EstadisticaVendedoresDao
    {

        public void Add(EstadisticaVendedores estadistica)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    EstadisticaVendedores newEntityRef = manager.Session.Merge(estadistica);
                    manager.Session.SaveOrUpdate(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(EstadisticaVendedores estadistica)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    EstadisticaVendedores newEntityRef = manager.Session.Merge(estadistica);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(EstadisticaVendedores estadistica)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    EstadisticaVendedores newEntityRef = manager.Session.Merge(estadistica);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public IList<EstadisticasVendedoresGrilla> darEstadisticasVendedores(DateTime fechaDesde, DateTime fechaHasta, int visbilidad)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<EstadisticaVendedores>();
                    crit.Add(Expression.Between("fechaCreacion", fechaDesde, fechaHasta));
                    crit.Add(Expression.Eq("idVisibilidad", visbilidad));
                    crit.SetProjection(
                            Projections.ProjectionList()

                                    .Add(Projections.GroupProperty("nombre"), "nombre")
                                    .Add(Projections.Sum("stock"), "cantidad")
                                    .Add(Projections.GroupProperty("idUsuario")))
                                    .SetResultTransformer(Transformers.AliasToBean(typeof(EstadisticasVendedoresGrilla)));

                    

                    return crit.List<EstadisticasVendedoresGrilla>();
                    
                }
            }
        }

        public IList<EstadisticaCompradoresGrilla> darEstadisticasCompradores(DateTime fechaDesde, DateTime fechaHasta, int rubro)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {

                    //Busqueda
                    ICriteria crit = manager.Session.CreateCriteria<EstadisticaCompradores>();
                    crit.Add(Expression.Between("fecha", fechaDesde, fechaHasta));
                    crit.Add(Expression.Eq("idRubro", rubro));
                    crit.SetProjection(
                            Projections.ProjectionList()
                                    .Add(Projections.GroupProperty(Projections.SqlFunction("month",
                                                                   NHibernateUtil.Date,
                                                                   Projections.GroupProperty("fecha"))), "mes")
                                    .Add(Projections.Sum("codigoPublicacion"), "compraCantidad")
                                    .Add(Projections.GroupProperty("nombre"), "nombre"))
                                    .SetResultTransformer(Transformers.AliasToBean(typeof(EstadisticaCompradoresGrilla)));



                    return crit.List<EstadisticaCompradoresGrilla>();

                }
            }
        }
    }
}

