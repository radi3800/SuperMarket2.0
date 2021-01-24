using System.Collections.Generic;
using System.Threading.Tasks;
using LastTry.Domain.Models;
using LastTry.Domain.Repositories;
using LastTry.Domain.Services;

namespace LastTry.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}