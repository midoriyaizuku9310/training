using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstCRUD.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string City { get; set; }

        public string country {  get; set; }


    }
}
