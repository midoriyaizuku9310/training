namespace ConsoleApp02
{

    class employeeClass
    {
        public int id { get; set; }
        public string ename { get; set; }
        public string job { get; set; }
        
        public int salary { get; set; }
    }
    class program13
    {
        static void Main()
        {
            /*
            employeeClass e1 = new employeeClass { id = 1, ename = "a", job = "analyst", salary = 25000 };
            employeeClass e2 = new employeeClass { id = 2, ename = "b", job = "senior analyst", salary = 50000 };
            employeeClass e3 = new employeeClass { id = 3, ename = "c", job = "architect", salary = 75000 };
            employeeClass e4 = new employeeClass { id = 4, ename = "d", job = "product manager", salary = 100000 };

            List<employeeClass> list = [e1, e2, e3, e4];
            */

            /*
            List<employeeClass> list = new List<employeeClass>();

            list.Add(new employeeClass { id = 1, ename = "a", job = "analyst", salary = 25000 });
            list.Add(new employeeClass { id = 2, ename = "b", job = "senior analyst", salary = 50000 });
            list.Add(new employeeClass { id = 3, ename = "c", job = "architect", salary = 75000 });
            list.Add(new employeeClass { id = 4, ename = "d", job = "product manager", salary = 100000 });
            */

            List<employeeClass> list = new List<employeeClass>
            {
                new employeeClass { id = 1, ename = "a", job = "analyst", salary = 25000 },
                new employeeClass { id = 2, ename = "b", job = "senior analyst", salary = 50000 },
                new employeeClass { id = 3, ename = "c", job = "architect", salary = 75000 },
                new employeeClass { id = 4, ename = "d", job = "product manager", salary = 100000 }
            };


            foreach(employeeClass e in list)
            {
                Console.WriteLine($"emp name: {e.ename}, empid: {e.id}, job: {e.job}, salary: {e.salary}");
            }

        }
    }
}