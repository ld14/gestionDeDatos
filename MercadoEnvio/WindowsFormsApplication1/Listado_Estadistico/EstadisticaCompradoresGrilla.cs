using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    class EstadisticaCompradoresGrilla
    {

        public virtual int mes { get; set; }
        public virtual int compraCantidad { get; set; }
        public virtual string nombre { get; set; }
        private string nombreMes;

        public virtual string NombreMes
        {
            get
            {
                var mesesDicionario = new Dictionary<int, string>();
                mesesDicionario.Add(1, "enero");
                mesesDicionario.Add(2, "febrero");
                mesesDicionario.Add(3, "marzo");
                mesesDicionario.Add(4, "abril");
                mesesDicionario.Add(5, "mayo");
                mesesDicionario.Add(6, "junio");
                mesesDicionario.Add(7, "julio");
                mesesDicionario.Add(8, "agosto");
                mesesDicionario.Add(9, "septiembre");
                mesesDicionario.Add(10, "octubre");
                mesesDicionario.Add(11, "noviembre");
                mesesDicionario.Add(12, "diciembre");

                return mesesDicionario[this.mes];
            }
            set
            {
                nombreMes = value;
            }
        }

    }
}
      