using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1{

    public class SubastaCompraDelSistema
    {
        public virtual long? rowID { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string tipoCompra { get; set; }
        public virtual DateTime? fecha { get; set; }
        public virtual int compraCantidad { get; set; }
        public virtual int? codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
        public virtual int? cantEstrellas { get; set; }
        public virtual string descripcionCalificacion { get; set; }
    }
}
