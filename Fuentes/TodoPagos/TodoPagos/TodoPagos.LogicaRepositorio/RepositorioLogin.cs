using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TodoPagos.LogicaRepositorio
{
    public static class RepositorioLogin
    {
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

        public static Usuario ObtenerUsuarioPorUsername(String userName)
        {
            BdContexto contexto = BdContexto.GetInstance();
            var usuarios = (from u in contexto.Usuarios
                            where u.NombreUsuario == userName
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }
        
        private static void AutorizarAutentificacion(int idUsuario)
        {
            BdContexto contexto = BdContexto.GetInstance();
            Usuario aModificar = contexto.Usuarios.Single(u => u.UsuarioId == idUsuario);
            aModificar.Autorizado = true;
            contexto.SaveChanges();
        }

        public static Boolean AutentificarUsuario(String nombreUsuario, String contrasenia, Guid guid)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
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
