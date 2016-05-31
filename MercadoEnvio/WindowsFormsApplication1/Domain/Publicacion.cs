using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Publicacion {
        public Publicacion() { }
        public virtual int idPublicacion { get; set; }
        public virtual Estadopublicacion EstadoPublicacion { get; set; }
        public virtual Visibilidad Visibilidad { get; set; }
        private ICollection<Rubro> rubroLst;
        public virtual Usuario Usuario { get; set; }
        public virtual double? codigoPublicacion { get; set; }
        public virtual string descripcion { get; set; }
        public virtual DateTime? fechaCreacion { get; set; }
        public virtual DateTime? fechaVencimiento { get; set; }
        public virtual double? stock { get; set; }
        public virtual bool? preguntasSN { get; set; }
        public virtual bool? envioSN { get; set; }
        public virtual ISet<Preguntas> Preguntas { get; set; }

        public virtual ICollection<Rubro> RubroLst  {
            get { return rubroLst; }
            set { rubroLst = value; }
        }

        public virtual void setPublicacion(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, Usuario usuario,
                                   double codigoPublicacion, string descripcion, DateTime fechaCreacion,
                                   DateTime fechaVencimiento, double stock, bool preguntasSN, bool envioSN)
        {
            this.EstadoPublicacion = estadoPublicacion;
            this.Visibilidad = visibilidad;
            this.Usuario = usuario;

            this.codigoPublicacion = codigoPublicacion;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.fechaVencimiento = fechaVencimiento;
            this.stock = stock;
            this.preguntasSN = preguntasSN;
            this.envioSN = envioSN;

        }
    }
}
