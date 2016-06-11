using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Listado_Estadistico;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface EstadisticaVendedoresDao {
        void Add(EstadisticaVendedores factura);
        void Update(EstadisticaVendedores factura);
        void Remove(EstadisticaVendedores factura);
        IList<EstadisticasVendedoresGrilla> darEstadisticasVendedores(DateTime fechaDesde, DateTime fechaHasta, int visibilidad);
    }
}


