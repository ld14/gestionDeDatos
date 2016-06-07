using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Generar_Publicación
{
    class GrillaPublicacion
    {
        public String tipoPublicacion { get; set; }
        public int idPublicacion { get; set; }
        public double? codigo { get; set; }
        public string descProducto { get; set; }
        public string rubro { get; set; }
        public double precio { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaVencimiento { get; set; }
        
        public string estado { get; set; }
        public string Visibilidad { get; set; }

    }
}

        