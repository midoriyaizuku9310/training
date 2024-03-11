using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace MVCApp2.Models
{
    [Keyless]
    public class Login
    {
        [Required]
        [BindProperty]
        public string UserName { get; set; }
        [Required]
        [BindProperty]
        public string Password { get; set; }
    }
}
