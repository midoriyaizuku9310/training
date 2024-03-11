using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProjectCRUD.DataAccess;

namespace RazorProjectCRUD.Pages
{
    public class HomeModel : PageModel
    {

        public List<Employee> Emps { get; set; }
        public ActionResult OnGet()
        {

            string username = HttpContext.Session.GetString("username");

            if (string.IsNullOrEmpty(username))
            {
                //redirect to login page
                return RedirectToPage("./Login");
                //return this.Page();
            }
            else
            {
                EmployeeDataAccess dal = new EmployeeDataAccess();
                Emps = dal.GetEmps();
                return this.Page();
                // return RedirectToPage("./Home");
            }



        }

        //public void OnGet()
        //{

        //        EmployeeDataAccess dal = new EmployeeDataAccess();
        //          Emps = dal.GetEmps();
        //}


        public ActionResult OnPostDelete(int id)
        {
            //DELETE record using DAL component
            EmployeeDataAccess dal = new EmployeeDataAccess();
            dal.DeleteEmployee(id);
            return RedirectToPage("./Home");
        }

        public ActionResult OnGetLogOut()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("./Login");
        }

    }
}
