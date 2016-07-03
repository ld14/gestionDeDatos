using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ListadosEstadisticos_clientesMayorCantidadProdComprados
    {
        public virtual int rowID { get; set; }
        public virtual string nombreUsuario { get; set; }
        public virtual int anio { get; set; }
        public virtual int mes { get; set; }
        public virtual int cantidad { get; set; }
        public virtual string rubro { get; set; }
    }
}
