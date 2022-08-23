using Sev1.Congratulations.Domain;
using Sev1.Congratulations.DataAccess.Base;
using Sev1.Congratulations.AppServices.Services.Tag.Repositories;

namespace Sev1.Congratulations.DataAccess.Repositories
{
    public sealed class UserFileRepository : EfRepository<UserFile, int?>, IUserFileRepository
    {
        public UserFileRepository(DatabaseContext dbСontext) : base(dbСontext)
        {
        }
    }
}