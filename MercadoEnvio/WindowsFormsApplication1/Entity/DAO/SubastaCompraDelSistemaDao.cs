using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface SubastaCompraDelSistemaDao{
        void Add(SubastaCompraDelSistema subastaCompra);
        void Update(SubastaCompraDelSistema subastaCompra);
        void Remove(SubastaCompraDelSistema subastaCompra);
        IList<SubastaCompraDelSistema> darSubastaCompra(int idUsuario);
    }
}


