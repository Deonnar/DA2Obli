using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tresana.Data.DataAccess;
using Tresana.Data.Entities;

namespace Tresana.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private TresanaContext context;
        private GenericRepository<User> userRepository;
        private GenericRepository<Task> taskRepository;
        private GenericRepository<Payment> paymentRepository;
        private GenericRepository<Client> clientRepository;
        private GenericRepository<ProviderField> providerFieldRepository;


        public UnitOfWork(TresanaContext tresanaContext)
        {
            context = tresanaContext;
        }

        public IRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }

        public IRepository<Task> TaskRepository
        {
            get
            {
                if (this.taskRepository == null)
                {
                    this.taskRepository = new GenericRepository<Task>(context);
                }
                return taskRepository;
            }
        }

        public IRepository<Payment> PaymentRepository
        {
            get
            {
                if (this.paymentRepository == null)
                {
                    this.paymentRepository = new GenericRepository<Payment>(context);
                }
                return paymentRepository;
            }
        }

        public IRepository<Client> ClientRepository
        {
            get
            {
                if (this.clientRepository == null)
                {
                    this.clientRepository = new GenericRepository<Client>(context);
                }
                return clientRepository;
            }
        }

        public IRepository<ProviderField> ProviderFieldRepository
        {
            get
            {
                if (this.providerFieldRepository == null)
                {
                    this.providerFieldRepository = new GenericRepository<ProviderField>(context);
                }
                return providerFieldRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
