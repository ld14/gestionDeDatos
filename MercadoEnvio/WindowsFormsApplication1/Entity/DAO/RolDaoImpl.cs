using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class RolDaoImpl : RolDao
    {

        public void Add(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Rol newEntityRef = manager.Session.Merge(rol);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Rol newEntityRef = manager.Session.Merge(rol);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Rol newEntityRef = manager.Session.Merge(rol);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }


        public IList<Rol> darRolActivo()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Rol>();
                crit.Add(Expression.Eq("activo", true));
                return crit.List<Rol>(); 
            }
        }

        public IList<Funciones> obtenerFunciones(int idRol)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                IList<Funciones> ff = manager.Session.QueryOver<Funciones>().List();
                IList<Rol> rr;
                IList<Funciones> fin = new List<Funciones>();
                foreach (Funciones funcion in ff)
                {
                    rr = funcion.RolLst.ToList();
                    if (rr.Any(x => x.idRol == idRol))
                    {
                        fin.Add(funcion);
                    }
                }
               return fin;
            }
        }

    }
}
