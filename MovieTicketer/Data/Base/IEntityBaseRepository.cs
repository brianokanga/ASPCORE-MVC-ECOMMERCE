using MovieTicketer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Base
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
	{
		Task<IEnumerable<T>> GetAll();
		T GetById(int id);
		void Add(Actor T);
		Actor Update(int id, Actor entity);
		void Delete(int id);
	}
}
