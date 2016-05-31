using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Cliente : Usuario {

        public virtual double dni { get; set; }
        public virtual int tipoDocumento { get; set; }
        public virtual string nombre { get; set; }
        public virtual string apellido { get; set; }
        public virtual DateTime? fechaNacimiento { get; set; }
        public virtual bool perfilActivo { get; set; }
        public virtual DateTime? fechaCreacion { get; set; }
        public virtual int? comprasEfectuadas { get; set; }
        public virtual int? comprasCalificadas { get; set; }

        public Cliente() { }
        
        public Cliente(string userName, string password, double dni,
                       int tipoDocumento, string nombre, string apellido, DateTime fechaNacimiento, DatosBasicos datosBasicos)
        {
            base.setUsuario(userName, password, datosBasicos);
            this.dni = dni;
            this.tipoDocumento = tipoDocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.perfilActivo = true;
            this.fechaCreacion = DateTime.Now; //Cambiar por variable de archivo
            this.comprasEfectuadas = 0;
            this.comprasCalificadas = 0;
        }
    }
}

// The following types may not be used as proxies: WindowsFormsApplication1.Cliente: type should have a visible (public or protected) no-argument constructor
