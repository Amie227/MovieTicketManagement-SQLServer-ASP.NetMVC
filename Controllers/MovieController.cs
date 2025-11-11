
using Microsoft.AspNetCore.Mvc;
using no12finalproject.Data;
using no12finalproject.Models;
using System;
using System.Linq;

namespace no12finalproject.Controllers
{
    public class MovieController : Controller
    {

        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movie = _context.Movies.ToList();
            return View(movie);
        }

        public IActionResult Details(Guid id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

    }
}
