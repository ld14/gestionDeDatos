using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Entity.DAO;

namespace WindowsFormsApplication1
{
    public class ListadoEstadisticasDaoImpl : ListadoEstadisticasDao
    {
        //Inician funciones para armado de listados:
        enum TiposListado { vendedoresMayorCantidadProdNoVendidos, clientesMayorCantidadProdComprados, vendedoresMayorCantidadFacturas, vendedoresMayorMontoFacturado };

        public IList<Object> darInformacionListado(int listadoSeleccionado, int anio, int trimestreSeleccionado, string visibilidadSeleccionada, string rubroSeleccionado)
        {
            int mesFinal = trimestreSeleccionado * 3;
            int mesInicial = mesFinal - 2;
            switch (listadoSeleccionado)
            {
                case (int)TiposListado.vendedoresMayorCantidadProdNoVendidos:
                    return obtenerMayorCantidadProdNoVendidos(anio, mesInicial, mesFinal, visibilidadSeleccionada);
                case (int)TiposListado.clientesMayorCantidadProdComprados:
                    return obtenerMayorCantidadProdComprados(anio, mesInicial, mesFinal, rubroSeleccionado);
                case (int)TiposListado.vendedoresMayorCantidadFacturas:
                    return obtenerMayorCantidadFacturas(anio, mesInicial, mesFinal);
                case (int)TiposListado.vendedoresMayorMontoFacturado:
                    return obtenerMontoMaximoFacturas(anio, mesInicial, mesFinal);
            }
            return null;
        }

        private IList<Object> obtenerMayorCantidadProdNoVendidos(int anio, int mesInicial, int mesFinal, string visibilidad)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<ListadosEstadisticos_vendedoresMayorCantidadProdNoVendidos>();
                    crit.Add(Expression.Eq("anio", anio));
                    crit.Add(Expression.Between("mes", mesInicial, mesFinal));
                    if (visibilidad != "Seleccione una visibilidad") crit.Add(Expression.Eq("visibilidad", visibilidad));
                    crit.AddOrder(Order.Desc("cantidad"));
                    crit.AddOrder(Order.Desc("mes"));
                    crit.SetMaxResults(5);
                    return crit.List<Object>();
                }
            }
        }

        private IList<Object> obtenerMayorCantidadProdComprados(int anio, int mesInicial, int mesFinal, string rubro)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<ListadosEstadisticos_clientesMayorCantidadProdComprados>();
                    crit.Add(Expression.Eq("anio", anio));
                    crit.Add(Expression.Between("mes", mesInicial, mesFinal));
                    if (rubro != "Seleccione un rubro") crit.Add(Expression.Eq("rubro", rubro));
                    crit.AddOrder(Order.Desc("cantidad"));
                    crit.SetMaxResults(5);
                    return crit.List<Object>();
                }
            }
        }

        private IList<Object> obtenerMayorCantidadFacturas(int anio, int mesInicial, int mesFinal)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<ListadosEstadisticos_vendedoresMayorCantidadFacturas>();
                    crit.Add(Expression.Eq("anio", anio));
                    crit.Add(Expression.Between("mes", mesInicial, mesFinal));
                    crit.AddOrder(Order.Desc("cantidad"));
                    crit.SetMaxResults(5);
                    return crit.List<Object>();
                }
            }
        }

        private IList<Object> obtenerMontoMaximoFacturas(int anio, int mesInicial, int mesFinal)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    ICriteria crit = manager.Session.CreateCriteria<ListadosEstadisticos_vendedoresMayorMontoFacturado>();
                    crit.Add(Expression.Eq("anio", anio));
                    crit.Add(Expression.Between("mes", mesInicial, mesFinal));
                    crit.AddOrder(Order.Desc("cantidad"));
                    crit.SetMaxResults(5);
                    return crit.List<Object>();
                }
            }
        }
    }
}
