using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace securityauthdemo.Pages
{
    public class homeModel : PageModel
    {
        public void OnGet()
        {
        }
        public ActionResult OnGetLogOut()
        {
            HttpContext.SignOutAsync();
            return RedirectToPage("/home");
        }
    }
}
