﻿using MovieTicketer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor Get(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
    }
}
