namespace ConsoleApp02
{
    interface Iemail
    {
        void composeEmail();
        void Inbox();
    }

    class outlook : Iemail
    {
        public void composeEmail()
        {
            Console.WriteLine("this is to compose email");
        }

        public void Inbox()
        {
            Console.WriteLine("this is to read emails");
        }
    }

    class program10
    {
        static void Main()
        {
            outlook ol = new outlook();
            ol.composeEmail();
            ol.Inbox();
        }
    }
}