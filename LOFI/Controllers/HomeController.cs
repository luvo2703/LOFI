using LOFI.Data;
using LOFI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LOFI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _context;
        public HomeController(AppBDContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var prolist = this._context.Products.ToList();
            return View(prolist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class AppBDContext
    {
    }
}