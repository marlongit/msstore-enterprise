using System.Threading.Tasks;

namespace MS.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}