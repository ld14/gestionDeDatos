using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface RubroDao     {
        void Add(Rubro rubro);
        void Update(Rubro rubro);
        void Remove(Rubro rubro);
        IList<Rubro> darRubroActivo();
        Rubro GetRubroById(int id);
    }
}


