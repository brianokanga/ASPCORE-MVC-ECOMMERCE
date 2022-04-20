using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketer.Data;
using MovieTicketer.Data.Services;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketer.Controllers
{
	public class ProducersController : Controller
	{
		private readonly IProducersService  _service;
		public ProducersController(IProducersService service)
		{
			_service = service;
		}
		public async Task<IActionResult> Index()
		{
			var allProducers = await _service.GetAllAsync();
			return View(allProducers);
		}

		//GET : producers/Details/1
		public async Task<IActionResult> Details(int id)
		{
			var prodcerDetails = await _service.GetByIdAsync(id);
			if (prodcerDetails == null) return View("NotFound");
			return View(prodcerDetails);
		}
	}
}
