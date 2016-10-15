using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Dominio.Entidades.Pagos;
using TodoPagos.LogicaNegocio;
using TodoPagos.Dominio;

namespace TodoPagos.LogicaRepositorio
{
    public static class RepositorioUsuarios
    {
        public static void Agregar(int IdUsuario)
        {
            
            BdContexto ctx = BdContexto.GetInstance();
            Usuario usuario = ctx.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            ctx.SaveChanges();
        }

        public static IEnumerable<Usuario> ObtenerUsuarios()
        {
            Usuario up = new Usuario();
            up.Nombre = "usuario 2";
            Agregar(up);
            BdContexto ctx = BdContexto.GetInstance();
            var usuarios = (from u in ctx.Usuarios
                            orderby u.Nombre
                            select u);
            return usuarios;
        }

        public static void Agregar(Usuario unUsuario)
        {
            BdContexto ctx = BdContexto.GetInstance();
            ctx.Usuarios.Add(unUsuario);
            ctx.SaveChanges();
        }

        public static Usuario ObtenerUsuario(int unIdUsuario)
        {
            BdContexto ctx = BdContexto.GetInstance();
            var usuarios = (from u in ctx.Usuarios
                            where u.UsuarioId == unIdUsuario
                            orderby u.Nombre
                            select u);
            return usuarios.First();
        }


        public static Usuario ValidacionLogIn(String mail, String clave)
        {
            BdContexto ctx = BdContexto.GetInstance();
            try
            {
                var usuario = (from u in ctx.Usuarios
                              // where u.Email == mail && u.Clave == clave
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
