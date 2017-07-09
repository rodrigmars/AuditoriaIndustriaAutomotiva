using AuditoriaIndustriaAutomotiva.Domain.Entities;
using System.Data.Entity;

namespace AuditoriaIndustriaAutomotiva.Data.EF.Context
{
    public class AuditoriaDbContext : DbContext
    {
        public AuditoriaDbContext() : base("StringConnection")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
