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
        public virtual IList<ItemFactura> ItemFacturasLts { get; set; }

        public virtual void setFacturaNueva(DateTime fecha, string formaPagoDesc, ItemFactura itemFactura)
        {
            PublicacionNormalDaoImpl pDao = new PublicacionNormalDaoImpl();

            this.fecha = fecha;
            this.montoTotal = itemFactura.monto;
            this.formaPagoDesc = formaPagoDesc;
            this.Publicacion = pDao.GetByCodigo(pDao.getSecuenciaPubli());
            
            this.ItemFacturasLts = new List<ItemFactura>();
            this.ItemFacturasLts.Add(itemFactura);
        }
    }
}
