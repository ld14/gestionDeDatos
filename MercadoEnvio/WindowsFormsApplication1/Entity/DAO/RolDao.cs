using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface RolDao    {
        void Add(Rol rol);
        void Update(Rol rol);
        void Remove(Rol rol);
        IList<Rol> darRolActivo();
    }
}


