using assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public ActionResult Index(Rent rent)
        {
            if(rent == null)
                rent = new Rent();
            return View();
        }

        //[HttpPost]

        //public ActionResult Index(Rent rent)
        //{
        //    return RedirectToAction("Calculate");
        //}

        [HttpPost]
        public ActionResult Calculate(Rent rent)
        {
            int start = rent.sd.Day;
            int end = rent.ed.Day;
            int count = end - start;
             rent.totalCost = count * rent.cost;
           
            return View(rent);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
