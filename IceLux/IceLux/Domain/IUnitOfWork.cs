using IceLux.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IceLux.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IFirmRepository Firms { get; }
        IMemberFRepository Members { get; }
        ICenterRepository Centers { get; }
        int Complete();
        
    }
}
