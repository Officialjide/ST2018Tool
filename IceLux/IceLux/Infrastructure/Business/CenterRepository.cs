using IceLux.Domain.Core;
using IceLux.Domain.Repositories;
using System;

namespace IceLux.Infrastructure.Business
{
    public class CenterRepository : Repository<Center>, ICenterRepository
    {
        public CenterRepository(TakingContext context)
            : base(context)
        {

        }
        public Center GetCenterTakingsWithDetails(int centerId)
        {
            throw new NotImplementedException();
        }

        public TakingContext TakingContext
        {
            get { return Context as TakingContext; }
        }
    }
}
