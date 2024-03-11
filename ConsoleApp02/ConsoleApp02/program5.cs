namespace ConsoleApp02
{
    class baseClass
    {
        private int t1 = 100;
        protected int t2 = 200;
        public int t3 = 300;

        public void displayBase()
        {
            Console.WriteLine($"from base class t1:{t1}, t2:{t2}, t3:{t3}");
        }

    }

    class derived : baseClass
    {
        public void displayDerived()
        {
            Console.WriteLine($"from derived class te: {t2}, t3: {t3}");
        }

    }

    class program5
    {
        static void Main()
        {
            derived d = new derived();
            d.displayBase();
            d.displayDerived();
            Console.WriteLine($"from the public: {d.t3}");
        }
    }

}