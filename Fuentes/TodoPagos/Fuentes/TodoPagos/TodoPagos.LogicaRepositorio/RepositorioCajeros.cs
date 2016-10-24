using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public static class RepositorioCajeros
    {
        public static void Agregar(int IdUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Usuario usuario = contexto.Usuarios.Include("Cajeros").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Cajero> ObtenerCajeros()
        {
            Cajero cajero = new Cajero();
            cajero.Contrasenia = "b";
            cajero.NombreUsuario = "b";
            Guid guid = Guid.NewGuid();
            cajero.Token = guid;
            cajero.Nombre = "Cajero 1";
            AgregarCajero(cajero);
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Cajeros
                            orderby u.Nombre
                            select u);
            return usuarios;
        }

        public static void AgregarCajero(Cajero unUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();

            Guid guid = Guid.NewGuid();
            unUsuario.Token = guid;
            contexto.Cajeros.Add(unUsuario);
            contexto.SaveChanges();
        }

        public static Cajero ObtenerCajero(int unIdUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Cajeros
                            where u.UsuarioId == unIdUsuario
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }

        public static void Modificar(int id, Cajero usuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Cajero aModificar = contexto.Cajeros.Single(u => u.UsuarioId == id);

            aModificar.Nombre = usuario.NombreUsuario;
            aModificar.NombreUsuario = usuario.NombreUsuario;
            aModificar.Direccion = usuario.Direccion;
            aModificar.Contrasenia = usuario.Contrasenia;
            aModificar.Apellido = usuario.Apellido;
            aModificar.NumeroCaja = usuario.NumeroCaja;
            contexto.SaveChanges();
        }
    }
}
