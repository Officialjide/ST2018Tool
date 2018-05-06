using IceLux.Domain.Core;
using IceLux.Domain.Repositories;
using System;

namespace IceLux.Infrastructure.Business
{
    public class MemberFRepository : Repository<ApplicationUser>, IMemberFRepository
    {
        public MemberFRepository(TakingContext context)
            : base(context)
        {

        }

        public ApplicationUser GetUserFirms(string userId)
        {
            throw new NotImplementedException();
        }

        public TakingContext TakingContext
        {
            get { return Context as TakingContext; }
        }
    }
}
