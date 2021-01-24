using System.Collections.Generic;
using System.Threading.Tasks;
using LastTry.Communication;
using LastTry.Domain.Models;

namespace LastTry.Domain.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> ListAsync();
		Task<CategoryResponse> SaveAsync(Category category);
		Task<CategoryResponse> UpdateAsync(int id, Category category);
		Task<CategoryResponse> DeleteAsync(int id);
	}
}