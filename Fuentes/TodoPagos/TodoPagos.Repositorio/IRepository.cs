using System;

namespace TodoPagos.Repositorio
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Agregar(T t);
        T Obtener(object id);
        void Borrar(object id);
        void Borrar(T t);
        void Actualizar(T t);
    }
}
