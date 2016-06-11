using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class EstadisticaVendedores {
        public virtual long? rowID { get; set; }
        public virtual int idPublicacion { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string nombre { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual int? stock { get; set; }
        public virtual int idVisibilidad { get; set; }
        public virtual double costo { get; set; }
    }
}
