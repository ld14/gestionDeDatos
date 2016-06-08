using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface ItemFacturaDao{
        void Add(ItemFactura itm);
        void Update(ItemFactura itm);
        void Remove(ItemFactura itm);
        
    }
}


