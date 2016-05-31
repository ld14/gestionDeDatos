using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Calificacion {
        public Calificacion() { }
        public virtual int idCalificacion { get; set; }
        public virtual double? codigo { get; set; }
        public virtual double? cantEstrellas { get; set; }
        public virtual string descripcion { get; set; }
    }
}
