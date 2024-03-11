using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingAdmin.Models
    
{
    [Table("dbo.Product")]
    public class Product
    {
        [BindProperty]

        public int Id { get; set; }
        [BindProperty]
        public byte[] Image { get; set; }
    }
}
