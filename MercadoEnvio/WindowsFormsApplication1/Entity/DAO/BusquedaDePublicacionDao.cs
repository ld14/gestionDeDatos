using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface BusquedaDePublicacionDao    {
        void Add(BusquedaDePublicacion rol);
        void Update(BusquedaDePublicacion rol);
        void Remove(BusquedaDePublicacion rol);
        IList<BusquedaDePublicacion> darLista();
        IList<BusquedaDePublicacion> darListaFiltradaPorRubroDescripcion(List<string> selectedRubrosLst, String descripcionTxt, int idUsuarioLogueado);
    }
}


