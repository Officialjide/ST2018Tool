using IceLux.Domain.Core;
using System.Collections.Generic;

namespace IceLux.Domain.Repositories
{
    public interface IFirmRepository : IRepository<Firm>
    {
        Firm GetFirmWithCenters(int firmId);
        IEnumerable<Firm> GetCentersWithTakings(int pageIndex, int pageSize);
        IEnumerable<Firm> GetFirmsUsers(int firmId);
    }
}
