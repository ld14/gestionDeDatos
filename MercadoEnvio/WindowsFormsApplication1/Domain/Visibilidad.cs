using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Visibilidad {
        public Visibilidad() { }
        public virtual int idVisibilidad { get; set; }
        public virtual double? costo { get; set; }
        public virtual double porcentaje { get; set; }
        public virtual double codigoVisibilidad { get; set; }
        public virtual string nombreVisibilidad { get; set; }
        public virtual bool activo { get; set; }
    }
}
