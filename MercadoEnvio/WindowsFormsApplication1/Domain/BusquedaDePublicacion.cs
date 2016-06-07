using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class BusquedaDePublicacion {
        public BusquedaDePublicacion() { }
        public virtual long? rowID { get; set; }
        public virtual int idPublicacion { get; set; }
        public virtual string tipoPublicacion { get; set; }
        public virtual int? codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
        public virtual double precio { get; set; }
        public virtual string desRubro { get; set; }
        public virtual double costo { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual DateTime? fechaVencimiento { get; set; }
    }
}
