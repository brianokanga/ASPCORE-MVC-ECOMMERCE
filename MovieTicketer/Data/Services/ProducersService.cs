using MovieTicketer.Data.Base;
using MovieTicketer.Models;

namespace MovieTicketer.Data.Services
{
	public class ProducersService : EntityBaseRepository<Producer>, IProducersService
	{
		public ProducersService(AppDbContext context)
			: base(context) { }
	}
}
