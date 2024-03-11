using assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;

namespace assignment1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateWT()
        {
            return View();
        }

        [HttpPost]
        
        //public IActionResult CreateWT(int ecode,string password,string gender,List<string> hobbies, string city)
       public IActionResult CreateWT(DataDisplay data)
        {
            ViewData.Add("ecode", data.ecode);
            ViewData.Add("password",data.password);
            ViewData.Add("gender", data.gender);
            ViewData.Add("hobbies", data.hobbies.Where(o=>o!="false").ToList());
            ViewData.Add("city", data.city);
            return View("Display");
        }

        [HttpGet]
        public IActionResult CreateST()
        {
            var citiesList = new List<SelectListItem>
    {
            new SelectListItem{Text="Hyderabad",Value="HYD"},
            new SelectListItem{Text="Chennai",Value="CHE"},
            new SelectListItem{Text="Bangalore",Value="BNG"}
    };
            var modelData = new DataDisplay
            {
                genders = new List<string> { "Male", "Female" },
                hobbies = new List<string> { "singing", "Gaming", "Drawing" },
                cities = citiesList
            };
            return View(modelData);
        }

    }
}