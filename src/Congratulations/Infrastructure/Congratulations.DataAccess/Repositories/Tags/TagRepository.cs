using Sev1.Congratulations.AppServices.Services.Tag.Repositories;
using Sev1.Congratulations.Domain;
using Sev1.Congratulations.DataAccess.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.DataAccess.Repositories
{
    public sealed class TagRepository : EfRepository<Tag, int?>, ITagRepository
    {
        public TagRepository(DatabaseContext dbСontext) : base(dbСontext)
        {
        }

        public async Task<IEnumerable<Tag>> GetPagedWhereAdvertismentsNotNull(
            int offset,
            int limit,
            CancellationToken cancellationToken)
        {
            var data = DbСontext
                .Set<Tag>()
                .Include(a => a.Congratulations)
                .AsNoTracking();

            return await data
                .Where(t => t.Congratulations
                    .Where(a => a.Status == CongratulationStatus.Active)
                    .Count() > 0)
                .OrderBy(e => e.Id)
                .Skip(offset)
                .Take(limit)
                .ToListAsync(cancellationToken);
        }
    }
}