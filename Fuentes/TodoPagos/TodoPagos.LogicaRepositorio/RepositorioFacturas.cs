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
    public class RepositorioFacturas
    {
       /* public static void Agregar(int IdFactura)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Factura usuario = contexto.Facturas.Include("Facturas").ToList().Find(f => f.FacturaId == IdFactura);
            contexto.SaveChanges();
        }

        public static IEnumerable<Factura> ObtenerFacturas()
        {
            Factura fac = new Factura();
            fac.Monto = 11;
         //   AgregarFactura(fac);
            BdContexto contexto = BdContexto.GetInstance();
            var facturas = (from f in contexto.Facturas
                            orderby f.FacturaId
                            select f);
            return facturas;
        }

        public static void AgregarFactura(Factura unaFactura)
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
        }*/
    }
}
