using MovieTicketer.Data.Base;
using MovieTicketer.Models;

namespace MovieTicketer.Data.Services
{
	public interface ICinemasService
	{
	}

	public interface ICinemasService : IEntityBaseRepository<Cinema>
	{
	}
}
