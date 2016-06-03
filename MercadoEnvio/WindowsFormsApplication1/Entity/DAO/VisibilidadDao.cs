using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface VisibilidadDao{
        void Add(Visibilidad visibilidad);
        void Update(Visibilidad visibilidad);
        void Remove(Visibilidad visibilidad);
        IList<Visibilidad> darVisibilidad();
    }
}


