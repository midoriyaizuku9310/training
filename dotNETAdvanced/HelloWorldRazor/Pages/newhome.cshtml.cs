using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldRazor.Pages
{
    public class newhomeModel : PageModel
    {
        public string Message { get; set; }


       public  Employee Employee {  get; set; }
      
        public void OnGet()
        {
            Message = "this is from onGET";

            Employee = new Employee()
            {
                Ecode = 100,
                EName = "a",
                Salary = 1000,
                Deptid = 200

            };
            


        }
    }
}
