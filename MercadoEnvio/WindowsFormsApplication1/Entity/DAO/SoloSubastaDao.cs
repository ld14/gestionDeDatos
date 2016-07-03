using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface SoloSubastaDao{
        void Add(SoloSubasta subastaCompra);
        void Update(SoloSubasta subastaCompra);
        void Remove(SoloSubasta subastaCompra);
        //IList<SubastaCompraDelSistema> darSubastaCompra(int idUsuario);
    }
}


