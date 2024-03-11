using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practice.Pages
{
    public class homeModel : PageModel
    {
        public void OnGet()
        {
        }
       public ActionResult OnPost()
        {
            return RedirectToPage("./BookData");
        }
        
    }
}
