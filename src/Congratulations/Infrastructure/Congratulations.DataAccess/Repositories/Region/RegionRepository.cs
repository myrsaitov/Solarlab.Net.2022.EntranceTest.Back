using Sev1.Congratulations.Domain;
using Sev1.Congratulations.DataAccess.Base;
using Sev1.Congratulations.AppServices.Services.Region.Repositories;

namespace Sev1.Congratulations.DataAccess.Repositories
{
    public sealed class RegionRepository : EfRepository<Region, int?>, IRegionRepository
    {
        public RegionRepository(DatabaseContext dbСontext) : base(dbСontext)
        {
        }
    }
}