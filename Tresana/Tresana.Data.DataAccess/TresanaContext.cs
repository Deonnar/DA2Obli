using Tresana.Data.Entities;
using System.Data.Entity;

namespace Tresana.Data.DataAccess
{
    public class TresanaContext : DbContext
    {
        public TresanaContext():base("name=TresanaContext") { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ProviderField> ProviderFields { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
    }
}
