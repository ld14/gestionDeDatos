using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class PublicacionNormalDaoImpl : PublicacionNormalDao
    {

        public void Add(PublicacionNormal publicacionNormal) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {

                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(PublicacionNormal publicacionNormal)        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(PublicacionNormal publicacionNormal)        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    PublicacionNormal newEntityRef = manager.Session.Merge(publicacionNormal); //getSession().merge(entity);  
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public PublicacionNormal GetById(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.Get<PublicacionNormal>(id);
            }
        }
        public IList<PublicacionNormal> GetAll()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<PublicacionNormal>().Where(x => x.EstadoPublicacion.idEstadoPublicacion != 4).List();
            }
        }

        public PublicacionNormal GetByUsuario(string usuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionNormal>();
                crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("usr.userName", usuario));
                return crit.UniqueResult<PublicacionNormal>();

            }
        }

        public   IList<PublicacionNormal> GetPublicacionByUsuario(Usuario usuario)     {
            using (NHibernateManager manager = new NHibernateManager()) {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionNormal>();
                //crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("Usuario", usuario));
                crit.CreateAlias("EstadoPublicacion", "estado");
                crit.Add(Expression.Not(Expression.Eq("estado.nombre", "Finalizada")));
                return crit.List<PublicacionNormal>();
            }
         }

        public PublicacionNormal GetPublicacionByCodigo(double? codigoPublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<PublicacionNormal>();
                crit.Add(Expression.Eq("codigoPublicacion", codigoPublicacion));
                return crit.UniqueResult<PublicacionNormal>();
            }
        }

        public int getSecuenciaPubli()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    int sequence = (int)manager.Session.CreateSQLQuery("SELECT current_value FROM [LOPEZ_Y_CIA].[getCodigo]").AddScalar("current_value", NHibernateUtil.Int32).UniqueResult();
                    return sequence;
                }
            }
        }

        public Publicacion GetByCodigo(int codigo)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<Publicacion>().Where(x => x.codigoPublicacion == codigo).List().First();
            }
        }
    }
}
