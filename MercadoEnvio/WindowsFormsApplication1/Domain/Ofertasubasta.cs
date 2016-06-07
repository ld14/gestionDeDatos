using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Ofertasubasta {
        public virtual int idOfertaSubasta { get; set; }
        public virtual PublicacionSubasta PublicacionSubasta { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual double monto { get; set; }
        public virtual DateTime fecha { get; set; }
        public virtual bool adjudicada { get; set; }
    }
}
