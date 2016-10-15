using System;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Repositorio.Contexto;

namespace TodoPagos.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private ContextoTodoPagos contexto;
        private Repository<Cajero> repositorioCajeros;

        public UnitOfWork()
        {
            contexto = new ContextoTodoPagos();
        }

        public UnitOfWork(ContextoTodoPagos contexto)
        {
            this.contexto = contexto; 
        }

        public Repository<Cajero> RepositorioCajeros
        {
            get
            {
                if(this.RepositorioCajeros == null)
                {
                    this.repositorioCajeros = new Repository<Cajero>(contexto);
                }

                return this.repositorioCajeros;
            }
        }

        public void Save()
        {
            contexto.SaveChanges();
        }

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    contexto.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
