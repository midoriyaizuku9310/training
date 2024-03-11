namespace ConsoleApp02
{


    class person
    {
        public person()
        {
            Console.WriteLine("this is a person constructor");
        }
        public person(string name)
        {
            Console.WriteLine($"the person name is: {name}");
        }

    }
    class Program
    {
       
        static void Main()
        {
          person p1 = new person();
          person p2 = new person("Danish");

        }
    }
}
