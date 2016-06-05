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
                    WorkflowEstados newEntityRef = manager.Session.Merge(workflowEstados);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(WorkflowEstados workflowEstados)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    WorkflowEstados newEntityRef = manager.Session.Merge(workflowEstados);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(WorkflowEstados workflowEstados)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    WorkflowEstados newEntityRef = manager.Session.Merge(workflowEstados);
                    manager.Session.Delete(newEntityRef);
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
