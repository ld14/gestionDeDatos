using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class EmpresaDaoImpl : EmpresaDao    {

        public void Add(Empresa empresa)         {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(empresa);
                    transaction.Commit();
                }
            }
        }

        public void Update(Empresa empresa)        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(empresa);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Empresa empresa) {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(empresa);
                    transaction.Commit();
                }
            }
        }

        public Empresa GetEmpresaByIdUsuario(int id)  {
            using (NHibernateManager manager = new NHibernateManager())  {
                return manager.Session.Get<Empresa>(id);
            }
        }

        public Empresa GetEmpresaByRazonSocial(string razonSocial)    {
            using (NHibernateManager manager = new NHibernateManager())
            {

                ICriteria crit = manager.Session.CreateCriteria<Empresa>();
                //crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("razonSocial", razonSocial));
                return crit.UniqueResult<Empresa>();
            }
        }

        public Empresa GetEmpresaByCuit(string cuit)       {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Empresa>();
                //crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("cuit",cuit));
                return crit.UniqueResult<Empresa>();

        }
    }

    }
}
