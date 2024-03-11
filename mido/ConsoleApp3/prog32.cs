using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class student
    {
        public int id, age;
        public string name;

        public void setDetails(int sid, int sage, string sname)
        {
            id = sid;
            age = sage;
            name = sname;
        }

        public void getDetails()
        {
            Console.WriteLine($"name:{name}, id:{id}, age: {age}");
        }
    }
    class prog32
    {
        static void Main()
        {
            student s1 = new student();
            Console.Write("enter student name: ");
            string Name = Console.ReadLine();

            Console.Write("enter student age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter student id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            s1.setDetails(Id, Age, Name);
            s1.getDetails();

        }

    }
}
