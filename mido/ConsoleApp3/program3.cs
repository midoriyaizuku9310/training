

namespace ConsoleApp3
{
    internal class program3
    {
        static void Main()
        {
            Console.WriteLine("hello program3");

            Console.WriteLine("enter your name: ");
            string name  = Console.ReadLine();

            Console.WriteLine("enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your salary: ");
            int sal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("are you an intern? ");
            bool intern = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(sal);
            Console.WriteLine(intern);



        }
    }
}
