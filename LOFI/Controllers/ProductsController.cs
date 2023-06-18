using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LOFI.Data;

namespace LOFI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDBContext _context;

        public ProductsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View();
        }

        // GET: Products/Details/5
        public IActionResult Detail(int id)
        {
            try
            {
                var product = _context.Products.Find(id);

                if (product == null)
                {
                    return NotFound(); // Trả về mã lỗi 404 nếu không tìm thấy sản phẩm
                }

                return View(product);
            }
            catch
            {
                return RedirectToAction("Index"); // Chuyển hướng đến trang Index nếu xảy ra lỗi
            }
        }



    }
}


     
        