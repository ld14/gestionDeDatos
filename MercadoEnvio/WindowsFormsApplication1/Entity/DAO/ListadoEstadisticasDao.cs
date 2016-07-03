using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface ListadoEstadisticasDao
    {
        IList<Object> darInformacionListado(int listadoSeleccionado, int anio, int trimestreSeleccionado, string visibilidadSeleccionada, string rubroSeleccionado);
    }
}
