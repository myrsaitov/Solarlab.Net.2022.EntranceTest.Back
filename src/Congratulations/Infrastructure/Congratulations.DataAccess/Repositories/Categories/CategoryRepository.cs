using System.Threading;
using System.Threading.Tasks;
using Sev1.Congratulations.Domain;
using Microsoft.EntityFrameworkCore;
using Sev1.Congratulations.AppServices.Services.Category.Repositories;
using Sev1.Congratulations.DataAccess.Base;
using System.Collections.Generic;
using System.Linq;

namespace Sev1.Congratulations.DataAccess.Repositories
{
    public sealed class CategoryRepository : EfRepository<Category, int?>, ICategoryRepository
    {
        public CategoryRepository(DatabaseContext dbСontext) : base(dbСontext)
        {
        }
        public async Task<Category> FindByIdWithParentAndChilds(
            int? id, 
            CancellationToken cancellationToken)
        {
            return await DbСontext
                .Set<Category>()
                .Include(a => a.ChildCategories)
                .Include(a => a.ParentCategory)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        }

        public async Task<ICollection<Category>> GetPagedWhithAdvertisments(
            int offset,
            int limit,
            CancellationToken cancellationToken)
        {
            var data = DbСontext
                .Set<Category>()
                .Include(a => a.Congratulations)
                .Include(a => a.ParentCategory)
                .Include(a => a.ChildCategories)
                .AsNoTracking();

            return await data
                .OrderBy(e => e.Id)
                .Skip(offset)
                .Take(limit)
                .ToListAsync(cancellationToken);
        }

        public async Task<ICollection<Category>> GetAllChilds(
            int? categoryId,
            CancellationToken cancellationToken)
        {
            var data = DbСontext
                .Set<Category>()
                .Include(a => a.Congratulations)
                .AsNoTracking();

            return await data
                .OrderBy(e => e.Id)
                .Where(a => a.ParentCategoryId == categoryId)
                .ToListAsync(cancellationToken);
        }
    }
}