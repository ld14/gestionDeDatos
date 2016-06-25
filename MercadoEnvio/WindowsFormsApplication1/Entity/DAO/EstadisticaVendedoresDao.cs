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
        IList<EstadisticasVendedoresGrilla> darEstadisticasVendedores(DateTime fechaDesde, DateTime fechaHasta, int visbilidad);
        IList<EstadisticaCompradoresGrilla> darEstadisticasCompradores(DateTime fechaDesde, DateTime fechaHasta, int rubro);
        IList<Estadisticamaximos> darMaximaCantidadFacturas(int ano, int mesInicio, int mesFin);
        IList<Estadisticamaximos> darMonToMaximoFacturas(int ano, int mesInicio, int mesFin);
    }
}


