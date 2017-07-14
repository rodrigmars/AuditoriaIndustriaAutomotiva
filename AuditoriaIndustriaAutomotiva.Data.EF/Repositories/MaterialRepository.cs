using AuditoriaIndustriaAutomotiva.Data.EF.Context;
using AuditoriaIndustriaAutomotiva.Domain.Entities;
using AuditoriaIndustriaAutomotiva.Domain.Interfaces;

namespace AuditoriaIndustriaAutomotiva.Data.EF.Repositories
{
    class MaterialRepository : RepositoryBase<Material>, IMaterialRepository
    {
        public MaterialRepository(AuditoriaDbContext context) : base(context)
        {

        }
    }
}
