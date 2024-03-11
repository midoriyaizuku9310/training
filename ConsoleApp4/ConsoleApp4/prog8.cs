using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class EmployeeModel
    {
        public int ID { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    class EmployeeBO
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>
    {
        new EmployeeModel{ID=1,EName="Anil",Job="admin",Salary=10000},
        new EmployeeModel{ID=2,EName="Bharath",Job="Developer",Salary=12000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000},
        new EmployeeModel{ID=3,EName="Charan",Job="Programmer",Salary=13000}
    };
        public List<EmployeeModel> GetAll() => employees;
    }
    class prog8
    {
        static void Main()
        {
            EmployeeBO context = new EmployeeBO();
            List<EmployeeModel> employees = context.GetAll();
            //foreach (EmployeeModel e in employees)
            // foreach (EmployeeModel e in employees.Take(5))
            //foreach (EmployeeModel e in employees.Skip(5))
            foreach (EmployeeModel e in employees.Skip(3).Take(7)) 
                Console.WriteLine($"{e.ID} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
/*
 Language integrated query
this is a standard syntax to access any data source like array, collect,xml,etc.,
 */