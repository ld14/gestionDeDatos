using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface EstadoPublicacionDao
    {
        void Add(Estadopublicacion publicacionSubasta);
        void Update(Estadopublicacion publicacionSubasta);
        void Remove(Estadopublicacion publicacionSubasta);
        IList<Estadopublicacion> darEstados();
    }
}

