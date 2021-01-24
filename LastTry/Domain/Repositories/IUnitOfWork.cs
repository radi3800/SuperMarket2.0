using System.Threading.Tasks;

namespace LastTry.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}