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
            
            BdContexto contexto = BdContexto.GetInstance();
          //  Usuario usuario = contexto.Usuarios.Include("Usuarios").ToList().Find(u => u.UsuarioId == IdUsuario);
            contexto.SaveChanges();
        }

        public static IEnumerable<Usuario> ObtenerUsuarios()
        {
           Usuario up = new Usuario();
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


        public static Usuario ValidacionLogIn(String mail, String clave)
        {
            BdContexto contexto = BdContexto.GetInstance();
            try
            {
                var usuario = (from u in contexto.Usuarios
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
