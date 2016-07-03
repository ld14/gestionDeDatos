using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1{

    public class SoloSubasta
    {
        public virtual long? rowID { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string tipoCompra { get; set; }
        public virtual DateTime? fecha { get; set; }
        public virtual double valorInicialVenta { get; set; }
        public virtual double montoOferta { get; set; }
        public virtual bool adjudicada { get; set; }
        public virtual int codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
    }
}
