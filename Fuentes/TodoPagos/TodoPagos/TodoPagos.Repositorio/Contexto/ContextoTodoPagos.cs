using System;
using System.Data.Entity;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Repositorio.Contexto
{
    public class ContextoTodoPagos : DbContext
    {
        public ContextoTodoPagos() : base("name=BdContexto") { }
                                       // public DbSet<Cajero> Cajeros { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set;}
    }
}
