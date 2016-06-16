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
    class CompraUsuarioDaoImpl : CompraUsuarioDao
    {

        public void Add(CompraUsuario compraUsuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    CompraUsuario newEntityRef = manager.Session.Merge(compraUsuario);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(CompraUsuario compraUsuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    CompraUsuario newEntityRef = manager.Session.Merge(compraUsuario);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(CompraUsuario compraUsuario)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    CompraUsuario newEntityRef = manager.Session.Merge(compraUsuario);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public CompraUsuario  GetUsuarioById(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    return manager.Session.Get<CompraUsuario>(id);
                }
            }
        }

        public IList<CompraUsuario> GetByPublicacion(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
                {
                    return manager.Session.QueryOver<CompraUsuario>().Where(x => x.Publicacion.idPublicacion == id).List();
                }
        }

        public int getProfileIdSequenceByCodigoCalificacion()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    int sequence = (int)manager.Session.CreateSQLQuery("SELECT NEXT VALUE FOR [LOPEZ_Y_CIA].[secuenciaCalif] AS secuencia").AddScalar("secuencia", NHibernateUtil.Int32).UniqueResult();
                    return sequence;
                }
            }
        }

    }     
}
