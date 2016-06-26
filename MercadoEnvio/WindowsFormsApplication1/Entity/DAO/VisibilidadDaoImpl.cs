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
                    Visibilidad newEntityRef = manager.Session.Merge(visibilidad);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Visibilidad newEntityRef = manager.Session.Merge(visibilidad);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Visibilidad newEntityRef = manager.Session.Merge(visibilidad);
                    manager.Session.Delete(newEntityRef);
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
        public IList<Visibilidad> obtenerVisibilidades()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<Visibilidad>().List();
            }
        }


        public IList<Visibilidad> darVisibilidadDistintosA(Visibilidad visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {

                ICriteria crit = manager.Session.CreateCriteria<Visibilidad>();
                crit.Add(Expression.Not(Expression.Eq("idVisibilidad", visibilidad.idVisibilidad)));
                return crit.List<Visibilidad>();
            }
        }
        public Visibilidad getVisibilidadByName(string visibilidadName)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                var visibilidades = obtenerVisibilidades();

                for (int i = 0; i < visibilidades.Count; i++)
                {
                    if (visibilidades[i].nombreVisibilidad == visibilidadName)
                    {
                        return visibilidades[i];
                    }
                }
                return null;
            }
        }

        public IList<Publicacion> obtenerPublicacionesSegunVisibilidad(string visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<Publicacion>();
                crit.CreateAlias("Visibilidad", "Visibilidad");
                crit.Add(Expression.Eq("Visibilidad.idVisibilidad", getVisibilidadByName(visibilidad).idVisibilidad));
                return crit.List<Publicacion>();
            }
        }
    }
}
