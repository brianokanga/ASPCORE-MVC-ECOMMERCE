﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketer.Data;
using MovieTicketer.Data.Services;
using MovieTicketer.Models;
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

		// GET: ProducersController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ProducersController/Create
		[HttpPost]
		public async Task<ActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Producer producer)
		{
			if (!ModelState.IsValid) return View(producer);
			await _service.AddAsync(producer);
			return RedirectToAction(nameof(Index));
		}
	}
}
