using System;
using Tresana.Data.Entities;

namespace Tresana.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Task> TaskRepository { get; }
        IRepository<Payment> PaymentRepository { get; }
        IRepository<Client> ClientRepository { get; }
        IRepository<ProviderField> ProviderFieldRepository { get; }
        void Save();
    }
}
