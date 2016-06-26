using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Estadisticamaximos {
        public virtual long? rowID { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string detalle { get; set; }
        public virtual int? ano { get; set; }
        public virtual int? mes { get; set; }
        public virtual int? cantidadFacturado { get; set; }
        public virtual double? montosFacturados { get; set; }
    }
}
