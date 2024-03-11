using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;

namespace practice.Pages
{
    public class BookDataModel : PageModel
    {
        public List<bookStore> books {  get; set; }
        public ActionResult OnGet()
        {
            //BookDisconnected dal = new BookDisconnected();  
            BookConnected dal = new BookConnected();
            books = dal.getBooks();
            return this.Page();
        }
        public ActionResult OnPost()
        {
            return RedirectToPage("./home");
        }
    }
}
