using System.Collections.Generic;
using System.Threading.Tasks;
using LastTry.Domain.Models;

namespace LastTry.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}