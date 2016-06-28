using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Entity.DAO
{
    interface SinCalificarDao
    {
        void Add(SinCalificar pb);
        void Update(SinCalificar pb);
        void Remove(SinCalificar pb);
        IList<SinCalificar> darLista(int id);
    }
}
