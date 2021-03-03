using System;
using MS.Core.DomainObjects;

namespace MS.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        
    }
}