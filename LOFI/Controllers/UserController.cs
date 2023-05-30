using Microsoft.AspNetCore.Mvc;

namespace LOFI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
