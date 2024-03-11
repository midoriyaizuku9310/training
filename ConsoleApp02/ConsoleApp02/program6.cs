namespace ConsoleApp02
{
    class parent
    {
        public parent()
        {
            Console.WriteLine("this is parent class");
        }
    }

    class intermediate : parent
    {
        public intermediate()
        {
            Console.WriteLine("this is intermediate class");
        }
    }

    class child: intermediate
    {
        public child()
        {
            Console.WriteLine("this is child class");
        }
    }

    class program6
    {
        static void Main()
        {
            child c = new child();
        }
    }
}