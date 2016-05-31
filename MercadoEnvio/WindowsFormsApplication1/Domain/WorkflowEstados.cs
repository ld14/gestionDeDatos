using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class WorkflowEstados {
        public virtual Estadopublicacion EstadoPublicacionInicial { get; set; }
        public virtual Estadopublicacion EstadoPublicacionFinal { get; set; }
        public virtual int idWorkflowEstados { get; set; }
        public virtual bool activo { get; set; }
    }
}
