using Microsoft.AspNetCore.Mvc;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Index()
        {
            return View();
           // return RedirectToAction("DisplayName");

        }

        //[HttpPost]
        //public ActionResult Index(NameModel model)
        //{
        //    return RedirectToAction("DisplayName");
        //}

        [HttpPost]
        
        public ActionResult DisplayName(NameModel model)
        {
            return View(model);
        }
    }
}
