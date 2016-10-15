using System;
using System.Data.Entity;
using TodoPagos.Dominio.Entidades.Usuarios;

namespace TodoPagos.Repositorio.Contexto
{
    public class ContextoTodoPagos : DbContext
    {
        public DbSet<Cajero> Cajeros { get; set; }
        public DbSet<Administrador> Administradores { get; set;}
    }
}
