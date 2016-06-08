using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface PublicacionNormalDao{

        void Add(PublicacionNormal pubicacionNormal);
        void Update(PublicacionNormal pubicacionNormal);
        void Remove(PublicacionNormal pubicacionNormal);
        PublicacionNormal GetById(int id);
        PublicacionNormal GetByUsuario(string usuario);
        IList<PublicacionNormal> GetPublicacionByUsuario(Usuario usuario);
        PublicacionNormal GetPublicacionByCodigo(double? codigoPublicacion);
        int getProfileIdSequence();
    }
}
