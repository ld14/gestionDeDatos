using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class WorkflowEstadosDaoImpl : WorkflowEstadosDao
    {

        public void Add(WorkflowEstados workflowEstados)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(workflowEstados);
                    transaction.Commit();
                }
            }
        }

        public void Update(WorkflowEstados workflowEstados)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(workflowEstados);
                    transaction.Commit();
                }
            }
        }

        public void Remove(WorkflowEstados workflowEstados)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(workflowEstados);
                    transaction.Commit();
                }
            }
        }



        public IList<Estadopublicacion> darWorkflowEstadosActivoByEstadoActual(int idEstadoPublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                IList<Estadopublicacion> estadopublicacionLst = new List<Estadopublicacion>();


                ICriteria crit = manager.Session.CreateCriteria<WorkflowEstados>();
                crit.CreateAlias("EstadoPublicacionInicial", "estPub");
                crit.Add(Expression.Eq("estPub.idEstadoPublicacion", idEstadoPublicacion));
                IList<WorkflowEstados> workflowEstadosLst = crit.List<WorkflowEstados>();

                foreach (WorkflowEstados workflowEstados in workflowEstadosLst) {
                    estadopublicacionLst.Add(workflowEstados.EstadoPublicacionFinal);
                }
                return estadopublicacionLst;                

        }
    }

    }
}
