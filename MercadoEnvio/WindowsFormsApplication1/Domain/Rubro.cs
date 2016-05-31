using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Rubro {
        public Rubro() { }
        public virtual int idRubro { get; set; }
        public virtual string codigo { get; set; }
        public virtual string nombreCorto { get; set; }
        public virtual string descripcion { get; set; }
    }
}
