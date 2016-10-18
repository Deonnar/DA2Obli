using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Proveedores;
using TodoPagos.LogicaNegocio;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public class RepositorioPagos
    {
        public static void Agregar(int Id)
        {
            BdContexto contexto = BdContexto.GetInstance();
            //  Usuario usuario = contexto.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Pago> ObtenerPagos()
        {
            Pago up = new Pago();
            up.Saldo = 30;
            up.EstaPaga = false;
            up.FechaEmision = System.DateTime.Today;
            up.FechaVencimiento = System.DateTime.Today;
            up.Monto = 89;
            up.PagoId = 1;
            Agregar(up);
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
