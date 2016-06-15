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

        public virtual void setFacturaNueva(DateTime? fecha ,double? montoTotal ,string formaPagoDesc ,
                                       Publicacion Publicacion, IList<ItemFactura> ItemFacturas)
        {
                //Random random = new Random();
                //Double nroFactura = Convert.ToDouble(random.Next(190000, 400000));
                //this.nroFactura = nroFactura;
                //FacturaDaoImpl factDaoImp = new FacturaDaoImpl();
                PublicacionNormalDaoImpl pDao = new PublicacionNormalDaoImpl();
                //this.nroFactura = factDaoImp.getProfileIdSequence();
                this.fecha = fecha;
                this.montoTotal = montoTotal;
                this.formaPagoDesc = formaPagoDesc;
                this.Publicacion = pDao.GetByCodigo(pDao.getSecuenciaPubli());
                this.ItemFacturasLts = ItemFacturas;
        }
    }
}
