using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class prog6
    {
        delegate void myDelegate(); 
        delegate void myDelegate2(string name);
        delegate int myDelegate3(int n); 
        delegate bool myDelegate4(int t);
        static void Main()
        {
            myDelegate d;
            d = delegate ()
            {
                Console.WriteLine("helllo from anonymous method");
            };
            d();

            d = () => Console.WriteLine("hello from lambda expression");
            d();

            /*
            myDelegate2 d2;
            d2 = delegate (string x)
            {
                Console.WriteLine($"this is {x}");
            };
            d2("mido");

            d2 = x => Console.WriteLine($"this is {x} from lambda");
            d2("mido");
            */

            myDelegate3 d3;
            d3 = delegate (int n)
            {
                return n * n;
            };
            Console.WriteLine(d3(9));

            d3 = x => x * x;
            Console.WriteLine(d3(25));


            myDelegate4 d4;
            d4 = delegate (int n)
            {
                if (n % 2 == 0) return true;
                else return false;
            };
            if (d4(9))
                Console.WriteLine("even");
            else Console.WriteLine("odd");


            d4 = x => x % 2 == 0;
            if (d4(8))
                Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}