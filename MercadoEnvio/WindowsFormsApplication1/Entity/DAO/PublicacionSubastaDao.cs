using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface PublicacionSubastaDao    {

        void Add(PublicacionSubasta publicacionSubasta);
        void Update(PublicacionSubasta publicacionSubasta);
        void Remove(PublicacionSubasta publicacionSubasta);
        PublicacionSubasta GetById(int id);
        PublicacionSubasta GetByUsuario(string usuario);
        IList<PublicacionSubasta> GetPublicacionByUsuario(Usuario usuario);
        PublicacionSubasta GetPublicacionByCodigo(double? codigoPublicacion);
        //int getProfileIdSequence();
    }
}
