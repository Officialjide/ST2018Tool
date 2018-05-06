using IceLux.Domain.Core;
using IceLux.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace IceLux.Infrastructure.Business
{
    public class FirmRepository : Repository<Firm>, IFirmRepository
    {
        public FirmRepository(TakingContext context)
            : base(context)
        {

        }
        public IEnumerable<Firm> GetCentersWithTakings(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Firm> GetFirmsUsers(int firmId)
        {
            throw new NotImplementedException();
        }

        public Firm GetFirmWithCenters(int firmId)
        {
            throw new NotImplementedException();
        }

        public TakingContext TakingContext
        {
            get { return Context as TakingContext; }
        }
    }
}
