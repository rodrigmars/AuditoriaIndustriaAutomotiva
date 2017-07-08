using System.Data.Entity;

namespace AuditoriaIndustriaAutomotiva.Data.EF.Context
{
    public class AuditoriaDbContext : DbContext
    {
        public AuditoriaDbContext() : base("StringConnection")
        {

        }
    }
}
