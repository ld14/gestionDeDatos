using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface CompraUsuarioDao{
        void Add(CompraUsuario usuario);
        void Update(CompraUsuario usuario);
        void Remove(CompraUsuario usuario);
        CompraUsuario GetByID(int id);
        int getProfileIdSequenceByCodigoCalificacion();
    }
}


