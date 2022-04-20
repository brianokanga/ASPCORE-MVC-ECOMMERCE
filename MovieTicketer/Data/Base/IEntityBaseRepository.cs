using MovieTicketer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Base
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T Entity);
		Task UpdateAsync(int id, T Entity);
		Task DeleteAsync(int id);
	}
}
