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
            BdContexto ctx = BdContexto.GetInstance();
            var usuarios = (from u in ctx.Usuarios
                            orderby u.Nombre
                            select u);
            return usuarios;
        }


    }
}
