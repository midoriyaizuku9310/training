using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopping2.Model;
using System.Diagnostics;

namespace shopping2.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ProductContext _context;

        public HomeController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Read the image file into a byte array
                byte[] imageData = System.IO.File.ReadAllBytes(imagePath);

                // Save the image to the database
                Product sample = new Product()
                {
                    Id = id,
                    Image = imageData,
                    Path = imagePath
                };
                _context.Product.Add(sample);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            List<Product> samples = _context.Product.ToList();
            return View(samples);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
