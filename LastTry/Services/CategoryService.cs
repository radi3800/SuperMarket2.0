using System.Collections.Generic;
using System.Threading.Tasks;
using LastTry.Domain.Models;
using LastTry.Domain.Repositories;
using LastTry.Domain.Services;

namespace LastTry.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
