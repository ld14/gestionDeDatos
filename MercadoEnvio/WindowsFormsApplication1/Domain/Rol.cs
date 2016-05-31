using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Rol {
        public Rol() { }
        private ICollection<Usuario> usuarioLst;
        private ICollection<Funciones> funcionesLst;
        public virtual int idRol { get; set; }
        public virtual string nombre { get; set; }
        public virtual bool activo { get; set; }

        public virtual ICollection<Usuario> UsuarioLst
        {
            get { return usuarioLst; }
            set { usuarioLst = value; }
        }

        public virtual ICollection<Funciones> FuncionesLst
        {
            get { return funcionesLst; }
            set { funcionesLst = value; }
        }
    }
}
