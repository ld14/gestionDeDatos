using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Preguntas {
        public virtual int idPreguntas { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Publicacion Publicacion { get; set; }
        public virtual string descripcion { get; set; }
    }
}
