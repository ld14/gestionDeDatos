using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {

    public class FacturasEmitidas
    {
        public virtual long? rowID { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual int nroFactura { get; set; }
        public virtual DateTime? fecha { get; set; }
        public virtual string montoTotal { get; set; }
        public virtual int? codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
    }
}
