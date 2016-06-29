using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class SinCalificar
    {
        public virtual int rowID { get; set; }
        public virtual int idCompraUsuario { get; set; }
        public virtual String tipoPublicacion { get; set; }
        public virtual int codigo { get; set; }
        public virtual string vendedor { get; set; }
        public virtual int idUsuario { get; set; }
        public virtual string descProducto { get; set; }
        public virtual double precio { get; set; }
        public virtual DateTime fechaCompra { get; set; }
        public virtual int cantidad { get; set; }
    }
}
