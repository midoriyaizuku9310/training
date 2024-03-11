using Microsoft.AspNetCore.Mvc;

namespace practice.Models
{
    public class bookStore
    {
        [BindProperty]
        public string bname { get; set; }
        public int? bid { get; set; }
        public string bauthor { get; set; }
        public string pname { get; set; }
        public int? copies { get; set; }
        public int? price { get; set; }
    }
}
