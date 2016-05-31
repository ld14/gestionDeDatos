using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class ItemFactura {
        public virtual int idItemFactura { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual double? cantidad { get; set; }
        public virtual double? monto { get; set; }
        

    }
}
