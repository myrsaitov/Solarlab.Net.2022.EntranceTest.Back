using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Sev1.Congratulations.AppServices.Services.Congratulation.Repositories;
using Sev1.Congratulations.DataAccess.Base;
using Sev1.Congratulations.Contracts.Enums;

namespace Sev1.Congratulations.DataAccess.Repositories
{
    public sealed class CongratulationRepository : EfRepository<Congratulation, int?>, ICongratulationRepository
    {
        public CongratulationRepository(DatabaseContext dbСontext) : base(dbСontext)
        {
        }

        public async Task<Congratulation> FindByIdWithTagsInclude(
            int? id,
            CancellationToken cancellationToken)
        {
            return await DbСontext
                .Set<Congratulation>()
                .Include(a => a.Tags)
                .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        }
        public async Task<Congratulation> FindByIdWithCategoriesAndTagsAndUserFiles(
            int? id,
            CancellationToken cancellationToken)
        {
            return await DbСontext
                .Set<Congratulation>()
                .Include(a => a.Category)
                .Include(a => a.Category.ChildCategories)
                .Include(a => a.Category.ParentCategory)
                .Include(a => a.Tags)
                .Include(a => a.UserFiles)
                .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        }

        public async Task<int?> CountActive(
            Expression<Func<Congratulation, bool>> predicate,
            CancellationToken cancellationToken)
        {
            var data = DbСontext
                .Set<Congratulation>()
                .AsNoTracking(); ;

            return await data
                .Where(c => c.Status == CongratulationStatus.Active)
                .Where(predicate)
                .CountAsync(cancellationToken);
        }

        public async Task<IEnumerable<Congratulation>> GetPagedWithTagsAndCategoryAndUserFilesInclude(
            Expression<Func<Congratulation, bool>> predicate,
            int offset,
            int limit,
            CancellationToken cancellationToken)
        {
            var data = DbСontext
                .Set<Congratulation>()
                .Include(a => a.Tags)
                .Include(a => a.Category)
                .Include(a => a.Region)
                .Include(a => a.UserFiles)
                .AsNoTracking();

            return await data
                .Where(c => c.Status == CongratulationStatus.Active)
                .Where(predicate)
                .OrderBy(e => e.Id)
                .Skip(offset)
                .Take(limit)
                .ToListAsync(cancellationToken);
        }
    }
}