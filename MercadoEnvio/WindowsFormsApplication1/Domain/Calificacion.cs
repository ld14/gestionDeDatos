using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Calificacion {
        public Calificacion() { }
        public virtual int idCalificacion { get; set; }
        public virtual int codigo { get; set; }
        public virtual int cantEstrellas { get; set; }
        public virtual string descripcion { get; set; }
    }
}
