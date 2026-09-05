using Microsoft.AspNetCore.Mvc;

namespace BullkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
