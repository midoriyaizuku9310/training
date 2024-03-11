
namespace ConsApp02
{
    abstract class EmployeeClass
    {
        private int Id; private string EName;
        public EmployeeClass()
        { }
        public EmployeeClass(int Id, string EName)
        {
            this.Id = Id; this.EName = EName;
        }
        public abstract double CalculateBonus(int salary);
        public void GetDetails()
        {
            Console.WriteLine($"{Id} {EName} ");
        }
    }

    class PermnantEmployeeClass : EmployeeClass
    {
        public PermnantEmployeeClass()
        {
        }
        public PermnantEmployeeClass(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.1;
        }
    }

    class TemporaryEmployeeClass : EmployeeClass
    {
        public TemporaryEmployeeClass()
        {
        }
        public TemporaryEmployeeClass(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary) //extension and valid
        {
            return salary * 0.05;
        }
    }

    class ContractEmployeeClass : EmployeeClass
    {
        public ContractEmployeeClass()
        {
        }
        public ContractEmployeeClass(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.09;
        }
    }

    class Program11
    {
        static void Main(string[] args)
        {
            EmployeeClass e1 = new PermnantEmployeeClass(1001, "Meghana");
            EmployeeClass e2 = new TemporaryEmployeeClass(1002, "Kiran");
            EmployeeClass e3 = new ContractEmployeeClass(1003, "Rani");
            Console.WriteLine($"the bonus: {e1.CalculateBonus(25000)}");
            e1.CalculateBonus(25000);
            e2.CalculateBonus(20000);
            e3.CalculateBonus(15000);
            e1.GetDetails();
            e2.GetDetails();
            e3.GetDetails();

        }
    }

}

