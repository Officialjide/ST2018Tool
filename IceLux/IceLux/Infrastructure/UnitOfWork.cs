using IceLux.Domain;
using IceLux.Domain.Repositories;
using IceLux.Infrastructure.Business;
using System;

namespace IceLux.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TakingContext Context;
        public UnitOfWork( TakingContext _context)
        {
            Context = _context;
            Firms = new FirmRepository(Context);
            Members = new MemberFRepository(Context);
            Centers = new CenterRepository(Context);
        }
        public IFirmRepository Firms { get; private set; }

        public IMemberFRepository Members { get; private set; }

        public ICenterRepository Centers { get; private set; }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
