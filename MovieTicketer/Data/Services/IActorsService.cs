using MovieTicketer.Models;
using System.Collections.Generic;

namespace MovieTicketer.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        Actor Get(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
    }
}
