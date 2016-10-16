using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Repositorio
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Usuario> RepositorioUsuario { get; }
        void Save();
    }
}
