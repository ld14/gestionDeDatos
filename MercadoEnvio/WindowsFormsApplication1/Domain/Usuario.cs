using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Usuario {
        public Usuario() { }
        private DatosBasicos datosBasicos;
        private ICollection<Rol> rolesLst;
        public virtual int idUsuario { get; set; }
        public virtual string userName { get; set; }
        public virtual string password { get; set; }
        public virtual bool activoUsuario { get; set; }
        public virtual double intentosFallidos { get; set; }
        public virtual bool? publicacionGratis { get; set; }
        public virtual int? cantidadEstrellas { get; set; }
        public virtual int? cantidadVentas { get; set; }

        public virtual DatosBasicos DatosBasicos
        {
            get { return datosBasicos; }
            set { datosBasicos = value; }
        }

        public virtual ICollection<Rol> RolesLst
        {
            get { return rolesLst; }
            set { rolesLst = value; }
        }

        public virtual void setUsuario(string userName, string password, DatosBasicos datosBasicos)
        {
            this.userName = userName;
            this.password = password;
            this.activoUsuario = true;
            this.intentosFallidos = 0;
            this.publicacionGratis = true;
            this.cantidadEstrellas = 0;
            this.cantidadVentas = 0;


            List<Rol> lst = new List<Rol>();
            for (int i = 1; i <= 2; i++) {
                Rol rol = new Rol();
                rol.nombre=i.ToString();
                rol.activo = true;
                lst.Add(rol);
            }
            this.rolesLst = lst;
            this.datosBasicos = datosBasicos;
        }


    }
}
