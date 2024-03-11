using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practice.Models;

namespace practice.Pages
{
    public class UpdateModel : PageModel
    {
        public bookStore book {  get; set; }

        public void OnGet(int id)
        {
            BookConnected dal = new BookConnected();
            book = dal.GetBookById(id);
        }

        public ActionResult OnPost()
        {
            BookConnected dal = new BookConnected();
            dal.UpdateBook(book);
            return RedirectToPage("./Home");
        }

    }
}
