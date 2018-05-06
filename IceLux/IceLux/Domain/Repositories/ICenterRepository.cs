using IceLux.Domain.Core;

namespace IceLux.Domain.Repositories
{
    public interface ICenterRepository : IRepository<Center>
    {
        Center GetCenterTakingsWithDetails(int centerId);
    }
}
