namespace ConsoleApp02
{

    class personBO
    {
        List<employeeClass> list = new List<employeeClass>
            {
                new employeeClass { id = 1, ename = "a", job = "analyst", salary = 25000 },
                new employeeClass { id = 2, ename = "b", job = "senior analyst", salary = 50000 },
                new employeeClass { id = 3, ename = "c", job = "architect", salary = 75000 },
                new employeeClass { id = 4, ename = "d", job = "product manager", salary = 100000 }
            };

        public List<employeeClass > getAll()
        {
            return list;
        }
    }
    class program14
    {
        static void Main()
        {

            personBO pb = new personBO();
            List<employeeClass> list = pb.getAll();

            


            foreach(employeeClass e in list)
            {
                Console.WriteLine($"emp name: {e.ename}, empid: {e.id}, job: {e.job}, salary: {e.salary}");
            }

        }
    }
}