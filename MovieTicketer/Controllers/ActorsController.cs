using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketer.Data.Services;
using MovieTicketer.Models;
using System.Threading.Tasks;

namespace MovieTicketer.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        // GET: ActorController
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: ActorController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var actorDetails = _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View();
        }

        // GET: ActorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Edit
        public async Task<ActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if(actorDetails == null) return View("NotFound");
            return View();
        }

        // POST: ActorController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id,[Bind("Id, FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
