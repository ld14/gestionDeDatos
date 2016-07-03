using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ListadosEstadisticoGrilla
    {
        public virtual string nombreUsuario { get; set; }
        public virtual int anio { get; set; }
        public virtual int mes { get; set; }
        public virtual int cantidad { get; set; }
        public virtual string visibilidad { get; set; }
        public virtual string rubro { get; set; }
    }
}
