﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
		public async Task AddAsync(T Entity) => await _context.Set<T>().AddAsync(Entity);
		

		public Task DeleteAsync(int id)
		{
			throw new System.NotImplementedException();
		}

		public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
			 
		public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
		

		public async Task UpdateAsync(int id, T entity)
		{
			EntityEntry entityEntry = _context.Entry(entity);
			entityEntry.State = EntityState.Modified;
		}
	}
}