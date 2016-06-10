using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface ClienteDao{
        void Add(Cliente usuario);
        void Update(Cliente usuario);
        void Remove(Cliente usuario);
        Cliente GetUsuarioById(int id);
        IList<Cliente> getAllClienteActivos();
    }
}


