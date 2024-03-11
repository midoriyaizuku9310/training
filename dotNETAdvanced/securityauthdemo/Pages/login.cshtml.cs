using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace securityauthdemo.Pages
{
    public class loginModel : PageModel
    {

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            if(Username=="admin" && Password=="abc")
            {
                //sign the user and store user info in authentication cookie in browser
                List<Claim> claims = new List<Claim>
                 {
                   new Claim ("username", Username),
                   //new Claim ("password", Password)
                   //new Claim("company","deloitte")
                   //new Claim("secretkey","fuyfuyfkufyuk")
                 };
                ClaimsIdentity identities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identities);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);



                return RedirectToPage("/home");
            }
            else
            {
                return Page();
            }
        }
    }
}
