using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using no12finalproject.Data;
using no12finalproject.Models;
using System;
using System.Linq;


namespace no12finalproject.Controllers
{
    public class ShowtimeController : Controller
    {

        private readonly AppDbContext _context;

        public ShowtimeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var showtimes = _context.Showtimes.Include(s => s.Movie).ToList();
            return View(showtimes);
        }

        public IActionResult Details(Guid id)
        {
            var showtime = _context.Showtimes.Include(s => s.Movie).FirstOrDefault(s => s.ShowtimeID == id);
            if (showtime == null) return NotFound();
            return View(showtime);
        }

    }
}
