using assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    public class HallController : Controller
    {
        private readonly IHallDAL _dal;
        public HallController(IHallDAL dal)
        {

            _dal = dal;



        }
        
        public IActionResult Index()
        {
            return View();
        }

       

        [HttpPost]
        public IActionResult Search(int costPerDay)
        {
            var hallList = _dal.GetHall(costPerDay);
          
                return View(hallList);
            
            
           
        }
    }
}
