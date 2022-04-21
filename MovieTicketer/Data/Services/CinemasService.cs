using MovieTicketer.Data.Base;
using MovieTicketer.Models;

namespace MovieTicketer.Data.Services
{
	public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
	{
		public CinemasService(AppDbContext context)
			: base(context) { }
	}
}
