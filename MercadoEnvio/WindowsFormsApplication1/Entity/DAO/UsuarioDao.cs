using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface UsuarioDao    {
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Remove(Usuario usuario);
        Usuario GetUsuarioById(int id);
    }
}


