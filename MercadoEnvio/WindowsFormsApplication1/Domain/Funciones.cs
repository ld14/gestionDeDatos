using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Funciones {
        public Funciones() { }
        private ICollection<Rol> rolLst;
        public virtual int idFunciones { get; set; }
        public virtual string nombre { get; set; }
        public virtual string descripcion { get; set; }
        public virtual bool activo { get; set; }

        public virtual ICollection<Rol> RolLst
        {
            get { return rolLst; }
            set { rolLst = value; }
        }

    }
}
