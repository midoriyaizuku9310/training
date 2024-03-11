namespace ConsoleApp02
{
    interface myInterface
    {
        void display1();
        void display2();
    }

    class newone : myInterface
    {
        public void display1()
        {
            Console.WriteLine("this is from display1");
        }
        public void display2()
        {
            Console.WriteLine("this is from display2");
        }
    }
    class program9
    {

        
        static void Main()
        {
            newone no = new newone();

            no.display1();
            no.display2();


        }
    }
}