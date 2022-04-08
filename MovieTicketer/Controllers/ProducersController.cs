using Microsoft.AspNetCore.Mvc;
using MovieTicketer.Data;
using System.Linq;

namespace MovieTicketer.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View();
        }
    }
}
