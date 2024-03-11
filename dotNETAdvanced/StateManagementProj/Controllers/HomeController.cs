using Microsoft.AspNetCore.Mvc;
using StateManagementProj.Models;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace StateManagementProj.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.temp = "from viewbag";
            TempData.Add("X",20);
            return View();
        }

        [HttpPost]
        //[Route("Display/{accnum}")]
        public IActionResult Display(int accnum)
        {
            //ViewData.Add("accnum", accnum);
            //write data to the cookie file
            HttpContext.Response.Cookies.Append("accnum", accnum.ToString());


            return View();
        }
       
        [HttpPost]
        public IActionResult InfoPage(/*int accnum*/)
        {
            //ViewData.Add("accnum", accnum);
            //read from the cookie file
           var accnum= HttpContext.Request.Cookies["accnum"];

            ViewData.Add("accnum", accnum);
            return View();
        }
       
    }
}
