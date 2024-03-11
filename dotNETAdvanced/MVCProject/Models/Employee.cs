using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Employee
    {
        [Required]
        [SalaryValidation(ErrorMessage="eid already present")]
        public int Ecode { get; set; }
        [Required]
        [Length(3,10,ErrorMessage ="have some naming sense!!")]
       
        public string Ename { get; set; }
        [Required]
        [Range(1000,50000,ErrorMessage ="Bro!!")]
        //[SalaryValidation(ErrorMessage ="are you the CEO?")]
       
        public int Salary { get; set; }
        [Required]
        [RegularExpression("\\d{3,3}",ErrorMessage ="you must not be from this office")]//@"\d{3,3}"
        public int Deptid { get; set; }

    }
}
