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
    public static class RepositorioAdministrador
    {
        public static void Agregar(int IdUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Usuario usuario = contexto.Administradores.Include("Administradores").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Administrador> ObtenerAdministradores()
        {
            Administrador administrador = new Administrador();
            administrador.Contrasenia = "admin";
            administrador.NombreUsuario = "admin";
            Guid guid = Guid.NewGuid();
            administrador.Token = guid;
            administrador.Nombre = "Administrador 1";
            AgregarAdministrador(administrador);
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Administradores
                            orderby u.Nombre
                            select u);
            return usuarios;
        }

        public static void AgregarAdministrador(Administrador unUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();

            Guid guid = Guid.NewGuid();
            unUsuario.Token = guid;
            contexto.Administradores.Add(unUsuario);
            contexto.SaveChanges();
        }

        public static Administrador ObtenerAdministrador(int unIdUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Administradores
                            where u.UsuarioId == unIdUsuario
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }
        public static Usuario ObtenerAdministradorPorNombreUsuario(String nombreUsuario)
        {
        
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Administradores
                            where u.NombreUsuario == nombreUsuario
                            orderby u.Nombre
                            select u);
            if(!usuarios.Any())
            {
                return null;
            }

            return usuarios.First();
        }
        public static void Modificar(int id, Administrador usuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Administrador aModificar = contexto.Administradores.Single(u => u.UsuarioId == id);

            aModificar.Nombre = usuario.NombreUsuario;
            aModificar.NombreUsuario = usuario.NombreUsuario;
            aModificar.Direccion = usuario.Direccion;
            aModificar.Contrasenia = usuario.Contrasenia;
            aModificar.Apellido = usuario.Apellido;
            contexto.SaveChanges();
        }
    }
}
