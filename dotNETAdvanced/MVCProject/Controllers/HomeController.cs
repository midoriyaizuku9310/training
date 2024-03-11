using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;
using MVCProject.Models;
using System.Drawing.Text;

namespace MVCProject.Controllers
{
    //[Route("myApp")]
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IEmpDataAccess _dal;
        public HomeController(IEmpDataAccess dal) {

            _dal = dal;

        
        
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            var message = "welcom to display";
            ViewData.Add("msg",message);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        // [Route("getEmps")]
        //[TypeFilter(typeof(ExceptionFilter))]
        [TypeFilterAttribute<ExceptionFilter>]
        //[TypeFilter<MyActionFilter>]

        public IActionResult DisplayEmps()
        {
            //var listEmps = new List<Employee>
            //{
            //    new Employee{Ecode=101,Ename="a",Salary=1000,Deptid=200},
            //    new Employee{Ecode=102,Ename="b",Salary=1030,Deptid=201},
            //    new Employee{Ecode=103,Ename="c",Salary=1020,Deptid=202}



            //};
            int a = 100;
            int b = 0;
            int result = a / b;
            var listEmps = _dal.GetEmps();
            return View(listEmps);
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (/*[Bind(include:"Ecode,DeptId")]*/Employee emp)
        {
            if(emp.Deptid!=201 && emp.Deptid!=202 && emp.Deptid!=203)
            {
                ModelState.AddModelError("DeptId", "DeptId must be 201/202/203");
            }
            
            if (ModelState.IsValid)
            {
                
                //insert record using DAL
                _dal.AddEmployee(emp);
                return RedirectToAction("DisplayEmps");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            //delete emp
            _dal.DeleteEmployee(id);
            return RedirectToAction("DisplayEmps");
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                //get the emp by id for update
                var emp = _dal.GetEmpById(id);
                return View(emp);
            }
            else
                return View();
        }

        [HttpPost]

        public IActionResult Edit(Employee emp)
        {
            _dal.UpdateEmployee(emp);
            return RedirectToAction("DisplayEmps");
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var emp =_dal.GetEmpById(id);
            return View(emp);
        }

        [Route("Add/{a}/{b}")]
        [HttpGet]

        public string addNUmbers(int a , int b)
        {
            return "sum of" + a + "and" + b + "is" + (a + b);
        }
    }
}
