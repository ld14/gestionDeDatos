using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface UsuarioDao
    {
        void Add(PublicacionSubasta publicacionSubasta);
        void Update(PublicacionSubasta publicacionSubasta);
        void Remove(PublicacionSubasta publicacionSubasta);
    }
}
