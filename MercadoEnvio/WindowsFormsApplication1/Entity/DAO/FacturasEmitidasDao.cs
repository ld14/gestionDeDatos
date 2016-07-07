using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface FacturasEmitidasDao
    {
        void Add(FacturasEmitidas rol);
        void Update(FacturasEmitidas rol);
        void Remove(FacturasEmitidas rol);
        IList<FacturasEmitidas> darFacturasEmitidas(int idUsuario, DateTime fechaDesde, DateTime fechaHasta, string descripcion);
    }
}


