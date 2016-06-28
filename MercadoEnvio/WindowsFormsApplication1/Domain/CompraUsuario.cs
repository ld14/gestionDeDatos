using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class CompraUsuario {
        public CompraUsuario() { }
        public virtual int idCompraUsuario { get; set; }
        public virtual Publicacion Publicacion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Calificacion Calificacion { get; set; }
        public virtual int compraCantidad { get; set; }
        public virtual DateTime fecha { get; set; }

        public virtual void constructorCompraUsuario(Publicacion Publicacion, Usuario UsuarioNuevo, int compraCantidad, int codigoCalificacion)
        {
            this.Publicacion = Publicacion;
            this.Usuario = UsuarioNuevo;
            this.compraCantidad = compraCantidad;
            /*
            Calificacion nuevaCalificacion = new Calificacion();
            nuevaCalificacion.codigo = codigoCalificacion;
            nuevaCalificacion.cantEstrellas = 0; //Luego Quitar ya que la instancia incial este valor debe ser null
            nuevaCalificacion.descripcion = "";

            this.Calificacion = nuevaCalificacion;
            */
        }
    }
}
