using Microsoft.AspNetCore.Mvc;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class EventOwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(EventOwner owner)
        {
           
            return View();
        }

        public IActionResult Save(EventOwner owner)
        {
           // var ownerlist=Owner.
            return View();
        }
    }
}
