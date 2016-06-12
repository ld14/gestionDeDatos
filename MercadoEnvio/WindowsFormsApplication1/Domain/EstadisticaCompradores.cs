using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {

    public class EstadisticaCompradores{
        public virtual long? rowID { get; set; }
        public virtual int idPublicacion { get; set; }
        public virtual int? codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string nombre { get; set; }
        public virtual int compraCantidad { get; set; }
        public virtual DateTime? fecha { get; set; }
        public virtual int idRubro { get; set; }
        public virtual string descript { get; set; }
    }
}
