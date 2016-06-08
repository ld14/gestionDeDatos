using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface ComisionesParametrizablesDao{
        void Add(ComisionesParametrizables rol);
        void Update(ComisionesParametrizables rol);
        void Remove(ComisionesParametrizables rol);
        ComisionesParametrizables darComisionesParametrizablesByNombreCorto(string nombreCorto);
    }
}


