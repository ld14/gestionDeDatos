using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Estadopublicacion {
        public Estadopublicacion() { }
        public virtual int idEstadoPublicacion { get; set; }
        public virtual string nombre { get; set; }
        public virtual string nombreCorto { get; set; }
    }
}
