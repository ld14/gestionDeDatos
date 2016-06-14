using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {

    public class PublicacionNormal:Publicacion   {

        public virtual double precioPorUnidad { get; set; }

        public virtual void setPublicacionNormal(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, Usuario usuario,
                   string descripcion, DateTime fechaCreacion, DateTime fechaVencimiento, double stock, bool preguntasSN,
                   bool envioSN, double valorInicialVenta, Rubro rubro)
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
            this.precioPorUnidad = valorInicialVenta;

            ICollection<Rubro> rubroLts = new List<Rubro>();
            rubroLts.Add(rubro);
            this.RubroLst = rubroLts;

        }

        public virtual void updatePublicacionNormal(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, 
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
            this.precioPorUnidad = valorInicialVenta;

            ICollection<Rubro> rubroLts = new List<Rubro>();
            rubroLts.Add(rubro);
            this.RubroLst = rubroLts;

        }
    }
}
