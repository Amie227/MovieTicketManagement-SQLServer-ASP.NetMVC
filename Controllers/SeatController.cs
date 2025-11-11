using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using no12finalproject.Data;

namespace no12finalproject.Controllers
{
    public class SeatController : Controller
    {

        private readonly AppDbContext _context;

        public SeatController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var seats = _context.Seats.Include(s => s.Showtime).ToList();
            return View(seats);
        }

        public IActionResult Details(Guid id)
        {
            var seat = _context.Seats.Include(s => s.Showtime).FirstOrDefault(s => s.SeatID == id);
            if (seat == null) return NotFound();
            return View(seat);
        }

    }
}
