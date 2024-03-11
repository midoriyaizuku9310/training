using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;

namespace practice.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public bookStore book { get; set; }
       
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                BookConnected dal = new BookConnected();
                dal.addBooks(book);
                return RedirectToPage("./BookData");
            }
            else return this.Page();
        }
    }
}
