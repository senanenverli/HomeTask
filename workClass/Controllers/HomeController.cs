using Microsoft.AspNetCore.Mvc;
using workClass.Contexts;

namespace workClass.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Models.Slider> sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}
