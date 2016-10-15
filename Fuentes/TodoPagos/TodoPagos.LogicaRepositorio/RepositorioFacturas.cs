using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaNegocio;
using TodoPagos.Dominio;


namespace TodoPagos.LogicaRepositorio
{
    class RepositorioFacturas
    {
        public static void Agregar(int IdFactura)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Factura usuario = contexto.Facturas.Include("Facturas").ToList().Find(f => f.FacturaId == IdFactura);
            contexto.SaveChanges();
        }

        public static IEnumerable<Factura> ObtenerFacturas()
        {
             Factura up = new Factura();
             up.Monto = 11;
             Agregar(up);
            BdContexto contexto = BdContexto.GetInstance();
            var facturas = (from f in contexto.Facturas
                            orderby f.FacturaId
                            select f);
            return facturas;
        }

        public static void Agregar(Factura unaFactura)
        {
            BdContexto contexto = BdContexto.GetInstance();
            contexto.Facturas.Add(unaFactura);
            contexto.SaveChanges();
        }

        public static Factura ObtenerFactura(int unIdFactura)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var facturas = (from f in contexto.Facturas
                            where f.FacturaId == unIdFactura
                            orderby f.FacturaId
                            select f);
            return facturas.First();
        }

    }
}
