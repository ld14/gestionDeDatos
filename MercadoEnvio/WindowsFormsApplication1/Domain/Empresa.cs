using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Empresa:Usuario {
        public virtual string razonSocial { get; set; }
        public virtual string cuit { get; set; }
        public virtual DateTime? fechaCreacion { get; set; }
        public virtual int perfilActivo { get; set; }
        public virtual string nombreContacto { get; set; }

        public Empresa() {}

        public Empresa(string userName, string password, DatosBasicos datosBasicos, 
                                       String razonSocial, string cuit, DateTime fechaCreacion, string nombreContacto)
        {
            //Datos Basicos del Padre
            this.userName = userName;
            this.password = password;
            this.DatosBasicos = datosBasicos;
            //Datos de la clase.
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.fechaCreacion = fechaCreacion;
            this.nombreContacto = nombreContacto;
        }
    }
}
