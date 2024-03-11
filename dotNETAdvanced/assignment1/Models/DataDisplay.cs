using Microsoft.AspNetCore.Mvc.Rendering;

namespace assignment1.Models
{
    public class DataDisplay
    {
        public int ecode {  get; set; }
            public string password { get; set; }
            public string gender { get; set; }// for posting
            public List<string> genders { get; set; }//for creating
            public List<string> hobbies { get; set; }
            public string city { get; set; }
        public List<SelectListItem> cities { get; set; }
    }
}
