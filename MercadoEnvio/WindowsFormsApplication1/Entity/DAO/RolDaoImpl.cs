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
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    Rol newEntityRef = manager.Session.Merge(rol);
                    manager.Session.SaveOrUpdate(newEntityRef);
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

        public Rol getRolbyId(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.Get<Rol>(id);
            }
        }

        
        public IList<Funciones> obtenerFunciones()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<Funciones>().List();
            }
        }

        public IList<Funciones> obtenerFuncionesPorRol(int idRol)
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
        public IList<Rol> GetAll()
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<Rol>().List();
            }
        }

        public IList<Rol> GetByCriteria(short estado, string nombre)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                ICriteria crit = manager.Session.CreateCriteria<Rol>();
                if (nombre.Length > 0)
                    crit.Add(Expression.InsensitiveLike("nombre", "%" + nombre + "%"));
                switch (estado)
                {
                    case 0:
                        crit.Add(Expression.Eq("activo", true));
                        break;
                    case 1:
                        crit.Add(Expression.Eq("activo", false));
                        break;
                }

                return crit.List<Rol>();
            }
        }


        public Rol getRolByName(string rolName)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                var roles = GetAll();

                for (int i = 0; i < roles.Count; i++){
                    if (roles[i].nombre == rolName)
                    {
                        return roles[i];
                    }
                }
                return null;
            }
        }
    }
}
