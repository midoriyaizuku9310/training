using Microsoft.AspNetCore.Mvc;
using ShoppingAdmin.Models;
using Microsoft.EntityFrameworkCore;
namespace ShoppingAdmin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            _context = context;
        }
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Product product, IFormFile imageFile)
        {
            if(ModelState.IsValid)
            {
                if(imageFile != null &&imageFile.Length >0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await imageFile.CopyToAsync(memoryStream);
                        product.Image = memoryStream.ToArray(); 
                    }
                }_context.Product.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products);  
        }

    }
}
