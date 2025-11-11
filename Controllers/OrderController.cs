using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using no12finalproject.Data;


namespace no12finalproject.Controllers
{
    public class OrderController : Controller
    {

        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.Include(o => o.User).ToList();
            return View(orders);
        }

        public IActionResult Details(Guid id)
        {
            var order = _context.Orders.Include(o => o.User).FirstOrDefault(o => o.OrderID == id);
            if (order == null) return NotFound();
            return View(order);
        }

    }
}
