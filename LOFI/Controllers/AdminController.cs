using Microsoft.AspNetCore.Mvc;

namespace LOFI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
