using System;
using System.Text;
using System.Collections.Generic;


namespace WindowsFormsApplication1 {
    
    public class Factura {
        public Factura() { }
        public virtual int idFactura { get; set; }
        public virtual double? nroFactura { get; set; }
        public virtual DateTime? fecha { get; set; }
        public virtual double? montoTotal { get; set; }
        public virtual string formaPagoDesc { get; set; }
        public virtual Publicacion Publicacion { get; set; }
        public virtual ISet<ItemFactura> ItemFacturas { get; set; }

        public virtual void setFacturaNueva(double? nroFactura ,DateTime? fecha ,double? montoTotal ,string formaPagoDesc ,
                                       Publicacion Publicacion ,ISet<ItemFactura> ItemFacturas) {
                this.nroFactura = nroFactura;
                this.fecha = fecha;
                this.montoTotal = montoTotal;
                this.formaPagoDesc = formaPagoDesc;
                this.Publicacion = Publicacion;
                this.ItemFacturas = ItemFacturas;
        }
    }
}
