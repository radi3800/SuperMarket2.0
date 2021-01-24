using System.Collections.Generic;
using System.Threading.Tasks;
using LastTry.Domain.Models;

namespace LastTry.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}