using Microsoft.AspNetCore.Mvc;

namespace MovieTicketer.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
