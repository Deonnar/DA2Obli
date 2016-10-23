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
    public static class RepositorioUsuarios
    {
        public static void Agregar(int IdUsuario)
        {
            
            BdContexto contexto = BdContexto.GetInstance();
            Usuario usuario = contexto.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Usuario> ObtenerUsuarios()
        {
            Usuario up = new Usuario();
            up.Contrasenia = "a";
            up.NombreUsuario = "a";
            Guid guid = Guid.NewGuid();
            up.Token = guid;
            up.Nombre = "usuario 2";
            AgregarUsuario(up);
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Usuarios
                            orderby u.Nombre
                            select u);
            return usuarios;
        }

        public static void AgregarUsuario(Usuario unUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
          
            Guid guid = Guid.NewGuid();

            unUsuario.Token = guid;

            contexto.Usuarios.Add(unUsuario);
            contexto.SaveChanges();
        }

        public static Usuario ObtenerUsuario(int unIdUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Usuarios
                            where u.UsuarioId == unIdUsuario
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }
        public static Usuario ObtenerUsuarioPorUsername(String userName)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Usuarios
                            where u.NombreUsuario == userName
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }

        public static void Modificar(int id, Usuario usuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Usuario aModificar = contexto.Usuarios.Single(u => u.UsuarioId == id);

            aModificar.Nombre = usuario.NombreUsuario;
            aModificar.NombreUsuario = usuario.NombreUsuario;
            aModificar.Direccion = usuario.Direccion;
            aModificar.Contrasenia = usuario.Contrasenia;
            aModificar.Apellido = usuario.Apellido;
            
            contexto.SaveChanges();
        }

        public static Boolean AutentificarUsuario(String nombreUsuario, String contrasenia, Guid guid)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
               /* var usuario = (from u in contexto.Usuarios
                               where u.NombreUsuario == nombreUsuario && u.Contrasenia == contrasenia && u.Token == guid
                               select u);*/
                Usuario u = ObtenerUsuarioPorUsername(nombreUsuario);

                if (u != null && u.Token == guid)
                {
                    AutorizarAutentificacion(u.UsuarioId);
                    return true;
                }
                return false;
              
            }
            catch
            {
                return false;
            }
        }

        public static Usuario LogearUsuario(String nombreUsuario, String contrasenia)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
                var usuario = (from u in contexto.Usuarios
                               where u.NombreUsuario == nombreUsuario && u.Contrasenia == contrasenia
                               select u);
                return usuario.First();
            }
            catch
            {
                return null;
            }
        }

        private static void AutorizarAutentificacion(int idUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Usuario aModificar = contexto.Usuarios.Single(u => u.UsuarioId == idUsuario);
            aModificar.Autorizado = true;
            contexto.SaveChanges();
        }


        public static Usuario EstaAutentificadoElUsuario(String nombreUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
                var usuario = (from u in contexto.Usuarios
                               where u.NombreUsuario == nombreUsuario
                               select u);
                return usuario.First();
            }
            catch
            {
                return null;
            }
        }
    }
}
