using System;
using TodoPagos.Dominio.Entidades.Usuarios;
using TodoPagos.Repositorio.Contexto;

namespace TodoPagos.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private ContextoTodoPagos contexto;
        public Repository<Administrador> repositorioCajeros;
        private Repository<Usuario> repositorioUsuarios;

        //constructor
        public IRepository<Usuario> RepositorioUsuario
        {
            get
            {

                if (this.repositorioUsuarios == null)
                {
                    this.repositorioUsuarios = new Repository<Usuario>(contexto);
                }
                return repositorioUsuarios;
            }
        }

        public UnitOfWork()
        {
            contexto = new ContextoTodoPagos();
        }

        public UnitOfWork(ContextoTodoPagos contexto)
        {
            this.contexto = contexto; 
        }

        public Repository<Administrador> RepositorioCajeros
        {
            get
            {
                if(this.RepositorioCajeros == null)
                {
                    this.repositorioCajeros = new Repository<Administrador>(contexto);
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
