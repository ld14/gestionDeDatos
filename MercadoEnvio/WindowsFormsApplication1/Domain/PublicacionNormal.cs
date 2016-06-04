using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {

    public class PublicacionNormal:Publicacion   {

        public virtual double precioPorUnidad { get; set; }

        public virtual void setPublicacionNormal(Estadopublicacion estadoPublicacion, Visibilidad visibilidad, Usuario usuario,
                   double codigoPublicacion, string descripcion, DateTime fechaCreacion,
                   DateTime fechaVencimiento, double stock, bool preguntasSN, bool envioSN, double valorInicialVenta)
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
            this.precioPorUnidad = valorInicialVenta;


        }
    }
}
