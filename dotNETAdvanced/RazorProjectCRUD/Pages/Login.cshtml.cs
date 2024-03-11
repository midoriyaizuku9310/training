using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorProjectCRUD.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
         public string Password { get; set; } 
        
        
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            //validate the user from database
            if(Username=="admin" && Password=="abc")
            {
                //valid user
                //1.store the username in the session
                //2.redirect to home page
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("./Home");
            }
            else
            {
                //invalid user
                //return the same login page
                return this.Page();
            }
        }
    }
}
