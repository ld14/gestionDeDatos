using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface WorkflowEstadosDao
    {
        void Add(WorkflowEstados workflowEstados);
        void Update(WorkflowEstados workflowEstados);
        void Remove(WorkflowEstados workflowEstados);
        IList<Estadopublicacion> darWorkflowEstadosActivoByEstadoActual(int idEstadoPublicacion);
    }
}


