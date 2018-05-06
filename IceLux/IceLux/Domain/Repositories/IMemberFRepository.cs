using IceLux.Domain.Core;

namespace IceLux.Domain.Repositories
{
    public interface IMemberFRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetUserFirms(string userId);
        ////IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
