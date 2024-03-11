namespace ConsoleApp02
{
    abstract class abstractClass
    {
        public void display()
        {
            Console.WriteLine("this is from abstract class display");
        }

        public abstract void display2();
    }

    class myClass : abstractClass
    {
        public myClass()
        {
            Console.WriteLine("this is from myclass");
        }
        public override void display2()
        {
            Console.WriteLine("this is from abstract class display2");
        }

    }

    class program7
    {
        static void Main()
        {
            myClass mc = new myClass();
            mc.display();
            mc.display2();
        }
    }
}       