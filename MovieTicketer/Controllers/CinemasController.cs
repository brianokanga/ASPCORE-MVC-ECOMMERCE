﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketer.Data;
using MovieTicketer.Data.Services;
using MovieTicketer.Models;
using System.Threading.Tasks;

namespace MovieTicketer.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //GET : Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        // GET: CinemasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemasController/Create
        [HttpPost]
        public async Task<ActionResult> Create([Bind("Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        // GET: CinemasController/Edit/1
        public async Task<ActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        // POST: ProducersController/Edit
        [HttpPost]
        public async Task<ActionResult> Edit(int id, [Bind("Id,FullName, ProfilePictureURL, Bio")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            if (id == cinema.Id)
            {
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }
    }
}
