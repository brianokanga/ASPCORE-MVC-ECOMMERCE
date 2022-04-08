using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        //Task<IEnumerable<T>> GetAll();
        //Actor GetById(int id);
        //void Add(Actor actor);
        //Actor Update(int id, Actor newActor);
        //void Delete(int id);
    }
}
