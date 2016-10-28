using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TodoPagos.Repositorio
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Agregar(T t);

        IEnumerable<T> ObtenerLista(
               Expression<Func<T, bool>> filtro = null,
               Func<IQueryable<T>, IOrderedQueryable<T>> ordenadoPor = null,
               string propiedades = "");

        T Obtener(object id);
        void Borrar(object id);
        void Borrar(T t);
        void Actualizar(T t);
    }
}
