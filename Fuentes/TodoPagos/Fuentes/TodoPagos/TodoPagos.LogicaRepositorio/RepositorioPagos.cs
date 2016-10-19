using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores;
//using TodoPagos.LogicaNegocio;
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
            var usuarios = (from u in contexto.Pagos
                            where u.PagoId == id
                            select u);
            return usuarios.First();
        }
    }
}
