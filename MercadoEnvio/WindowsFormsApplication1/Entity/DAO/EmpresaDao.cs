using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    class EmpresaDao    {
        void Add(Empresa empresa);
        void Update(Empresa empresa);
        void Remove(Empresa empresa);
        Empresa GetEmpresaByIdUsuario(int idUsuario);
        Empresa GetEmpresaByRazonSocial(string razonSocial);
        Empresa GetEmpresaByCuit(string cuit);
    }
}
