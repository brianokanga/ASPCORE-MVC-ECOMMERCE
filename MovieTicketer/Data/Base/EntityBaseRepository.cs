using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Base
{
	public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		public Task AddAsync(T Entity)
		{
			throw new System.NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public Task<IEnumerable<T>> GetAllAsync()
		{
			throw new System.NotImplementedException();
		}

		public Task<T> GetByIdAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public Task<T> UpdateAsync(int id, T Entity)
		{
			throw new System.NotImplementedException();
		}
	}
}
