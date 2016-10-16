using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;
namespace TodoPagos.Servicios
{
    public interface IServiciosUsuarios
    {
        Usuario ObtenerUsuario(int IdUsuario);
        IEnumerable<Usuario> ObtenerUsuarios();
        int AgregarUsuario(Usuario usuario);
        bool ModificarUsuario(int IdUsuario, Usuario usuario);
        bool BorrarUsuario(int IdUsuario);
    }
}
