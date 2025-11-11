using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using no12finalproject.Data;

namespace no12finalproject.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult Details(Guid id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserID == id);
            if (user == null) return NotFound();
            return View(user);
        }
    }
}
