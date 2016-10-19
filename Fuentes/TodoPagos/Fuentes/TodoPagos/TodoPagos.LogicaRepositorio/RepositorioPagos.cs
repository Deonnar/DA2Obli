using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores; 
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioPagos
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Pago pago = contexto.Pagos.Include("Pagos").ToList().Find(p => p.PagoId == Id);
            contexto.SaveChanges();
        }

        public static IEnumerable<Pago> ObtenerPagos()
        {           
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Pagos                         
                            select u);
            return usuarios;
        }

        public static void Agregar(Pago unPago)
        {
            BdContexto contexto = BdContexto.GetInstance();
                                  
            contexto.Pagos.Add(unPago);
            contexto.SaveChanges();
        }

        public static Pago ObtenerPago(int id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var pagos = (from u in contexto.Pagos
                            where u.PagoId == id
                            select u);
            return pagos.First();
        }

        public static IEnumerable<Pago> ObtenerPagoEntreFechas(DateTime inicio, DateTime fin)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var pagos = (from p in contexto.Pagos
                         where p.FechaEmision >= inicio && p.FechaEmision <= fin
                         select p);
            return pagos;
        }

     /*   public static IEnumerable<Pago> ObtenerPagoEntreFechasPorProveedor(DateTime inicio, DateTime fin)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var pagos = (from p in contexto.Pagos
                         where p.FechaEmision >= inicio && p.FechaEmision <= fin 
                         group p by p.Proveedor.NombreProveedor
                         into total
                         select new { Id = total.Key, Count = total.Sum(p => p.ImporteFactura)});
            return pagos.AsEnumerable();
        }*/
    }
}
