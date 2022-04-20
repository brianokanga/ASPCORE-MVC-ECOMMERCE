using Microsoft.EntityFrameworkCore;
using MovieTicketer.Data.Base;
using MovieTicketer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketer.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
            :base(context) { }
    }
}
