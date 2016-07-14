using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.ABM_Usuario
{
    class GrillaUsuario
    {
        public String nombreUsuario { get; set; }
        public String Mail { get; set; }
        public String Telefono { get; set; }
        public String DomicilioCalle { get; set; }
        public int? nroCalle { get; set; }
        public int? piso { get; set; }
        public String depto { get; set; }
        public String CodigoPostal { get; set; }
        public String localidad { get; set; }
        public String ciudad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        //DATOS DE CLIENTE--------------------
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public Double Dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        //------------------------------------
        //DATOS DE EMPRESA-------------------
        public String RazonSocial { get; set; }
        public String Cuit { get; set; }
        public String NombreContacto { get; set; }
        //-----------------------------------
        public int idUsuario { get; set; }
    }
}
