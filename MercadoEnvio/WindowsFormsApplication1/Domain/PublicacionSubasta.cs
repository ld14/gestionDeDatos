using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class PublicacionSubasta:Publicacion {

        public PublicacionSubasta() { }
        public virtual double valorInicialVenta { get; set; }
        public virtual double? valorActual { get; set; }

        public virtual void setPublicacionSubasta(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, Usuario usuario,
                           double codigoPublicacion, string descripcion, DateTime fechaCreacion,
                           DateTime fechaVencimiento, double stock, bool preguntasSN, bool envioSN,double valorInicialVenta,double valorActual)
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

            this.valorInicialVenta = valorInicialVenta;
            this.valorActual = valorActual;

        }

    }
}
