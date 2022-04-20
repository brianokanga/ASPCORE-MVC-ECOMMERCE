using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Base
{
	public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		private readonly AppDbContext _context;

		public EntityBaseRepository(AppDbContext context)
		{
			_context = context;
		}
		public Task AddAsync(T Entity)
		{
			throw new System.NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			var results = await _context.Set<T>().ToListAsync();
			return results;
		}

		public async Task<T> GetByIdAsync(int id)
		{
			var results = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
			return results;
		}

		public Task<T> UpdateAsync(int id, T Entity)
		{
			throw new System.NotImplementedException();
		}
	}
}
