using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using MVCProject.Models;

namespace MVCProject.Models
{
    public class SalaryValidation : ValidationAttribute
    {
        //public override bool IsValid(object? value)
        //{int salary =(int)value;
        //    if (salary < 5000)
        //        return false;
        //    else
        //        return true;
        //}

        public override bool IsValid(object? value)
        {
            EmpDataAccess dal = new EmpDataAccess();
            int id = (int)value;
            try
            {
               
                if (dal.GetEmpById(id) != null)
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }

            return true;
            }
        }
    }

