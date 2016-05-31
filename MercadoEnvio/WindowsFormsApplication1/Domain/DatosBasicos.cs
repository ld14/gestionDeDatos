using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class DatosBasicos {
        public DatosBasicos() { }
        public virtual int idDatosBasicos { get; set; }
        public virtual string email { get; set; }
        public virtual string domCalle { get; set; }
        public virtual double nroCalle { get; set; }
        public virtual double? piso { get; set; }
        public virtual string depto { get; set; }
        public virtual string codPostal { get; set; }
        public virtual string localidad { get; set; }
        public virtual string ciudad { get; set; }


        public virtual void setDatosBasicos(string email, string domCalle, double nroCalle, double piso, string depto, 
                                    string codPostal, string localidad, string ciudad)        {

            this.email = email;
            this.domCalle = domCalle;
            this.nroCalle = nroCalle;
            this.piso = piso;
            this.depto = depto;
            this.codPostal = codPostal;
            this.localidad = localidad;
            this.ciudad = ciudad;
        }
    }
}
