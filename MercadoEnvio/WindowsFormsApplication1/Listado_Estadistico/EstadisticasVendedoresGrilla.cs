using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class EstadisticasVendedoresGrilla
    {
        public virtual int idUsuario { get; set; }
        public virtual string nombre { get; set; }
        public virtual int? cantidad { get; set; }      
    }
}
