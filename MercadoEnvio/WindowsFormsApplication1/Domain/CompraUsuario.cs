using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class CompraUsuario {
        public virtual int idCompraUsuario { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Calificacion Calificacion { get; set; }
    }
}
