using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface FacturaDao {
        void Add(Factura factura);
        void Update(Factura factura);
        void Remove(Factura factura);
        Factura darFacturaByPublicacionID(int id);
    }
}


