using Microsoft.AspNetCore.Mvc;

namespace MovieTicketer.Controllers
{
    public class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
