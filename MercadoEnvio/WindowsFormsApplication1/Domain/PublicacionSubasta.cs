using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class PublicacionSubasta:Publicacion {

        public PublicacionSubasta() { }
        public virtual double valorInicialVenta { get; set; }
        public virtual double? valorActual { get; set; }

        public virtual void setPublicacionSubasta(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, Usuario usuario,
                           string descripcion, DateTime fechaCreacion, DateTime fechaVencimiento, double stock,
                           bool preguntasSN, bool envioSN,double valorInicialVenta,double valorActual,Rubro rubro)
        {
            this.EstadoPublicacion = estadoPublicacion;
            this.Visibilidad = visibilidad;
            this.Usuario = usuario;

            //this.codigoPublicacion = codigoPublicacion;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.fechaVencimiento = fechaVencimiento;
            this.stock = stock;
            this.preguntasSN = preguntasSN;
            this.envioSN = envioSN;

            this.valorInicialVenta = valorInicialVenta;
            this.valorActual = valorActual;

            ICollection<Rubro> rubroLts = new List<Rubro>();
            rubroLts.Add(rubro);
            this.RubroLst = rubroLts;
        }

        public virtual void updatePublicacionSubasta(Estadopublicacion estadoPublicacion, Visibilidad visibilidad,
                           string descripcion, DateTime fechaCreacion,
                           DateTime fechaVencimiento, double stock, bool preguntasSN, bool envioSN, double valorInicialVenta, Rubro rubro)
        {
            this.EstadoPublicacion = estadoPublicacion;
            this.Visibilidad = visibilidad;

            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.fechaVencimiento = fechaVencimiento;
            this.stock = stock;
            this.preguntasSN = preguntasSN;
            this.envioSN = envioSN;

            this.valorInicialVenta = valorInicialVenta;
            this.valorActual = valorActual;

            ICollection<Rubro> rubroLts = new List<Rubro>();
            rubroLts.Add(rubro);
            this.RubroLst = rubroLts;
        }
    }
}
