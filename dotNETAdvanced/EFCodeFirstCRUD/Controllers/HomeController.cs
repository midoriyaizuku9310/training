using EFCodeFirstCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCodeFirstCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerDBContext dbCtx;

        public HomeController(ILogger<HomeController> logger, CustomerDBContext dbCtx)
        {
            _logger = logger;
            this.dbCtx = dbCtx;
        }

        public IActionResult Index()
        {
            var lstCust = dbCtx.customers.ToList();
            return View(lstCust);
        }

        public IActionResult Details(int id)
        {
           
                
            return View();
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
}
