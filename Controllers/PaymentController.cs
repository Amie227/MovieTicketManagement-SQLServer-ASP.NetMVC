using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using no12finalproject.Data;


namespace no12finalproject.Controllers
{
    public class PaymentController : Controller
    {

        private readonly AppDbContext _context;

        public PaymentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var payments = _context.Payments
            .Include(p => p.Order)
            .Include(p => p.PaymentMethod)
            .ToList();
            return View(payments);
        }

        public IActionResult Details(Guid id)
        {
            var payment = _context.Payments
            .Include(p => p.Order)
            .Include(p => p.PaymentMethod)
            .FirstOrDefault(p => p.PaymentID == id);
            if (payment == null) return NotFound();
            return View(payment);
        }

    }
}
