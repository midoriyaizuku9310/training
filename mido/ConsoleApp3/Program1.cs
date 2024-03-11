namespace ConsoleApp3
{
    internal class Program1
    {

        static void hour()
        {
            int hour = DateTime.Now.Hour;
            Console.WriteLine(hour);
        }

        static void Display (string name)
        {
            Console.WriteLine($"hello {name}");
        }

        static void fibonacci(int limit)
        {
            int a = 0; int b = 1; int c = 0;
            Console.Write($"{a} {b}");
            for (int i = 2; i < limit; i++)
            {
                c = a + b;
                Console.Write($" {c} ");
                a = b;
                b = c;
            }
        }

        static int square(int n)
        {
            return n * n;
        }

        static string biggest(int a, int b)
        {
            if (a > b) return $"{a} is biggest {b} is the smallest";
            else if (a == b) return "they are equal";
           else  return $"{a} is the smallest {b} is the biggest";
        }

        static int length(string s)
        {
            return s.Length;
        }

        static string firstname(string s)
        {
            int pos;
            pos = s.IndexOf(" ");
            return s.Substring(0,pos);
        }

        static string lastname(string s)
        {
            int pos;
            pos = s.LastIndexOf(" ");
            return s.Substring(pos+1);
        }

        static void List(params string[] names)
        {
            string msg = "Names: ";
            for (int i = 0; i < names.Length; i++)
                msg += $"{names[i]} ";

            Console.WriteLine(msg);
        }
        

        static void Main()
        {
            Console.WriteLine("Hello program1");
            Console.WriteLine("working on methods");
            hour();
            Display("danish");
            fibonacci(10);
            Console.WriteLine(square(25));
            Console.WriteLine(biggest(32,23));
            Console.WriteLine(length("mido danish"));
            Console.WriteLine(firstname("mido danish"));
             Console.WriteLine(lastname("mido danish"));
            List("Kiran", "Arvind", "Ganesh");
            List("AAA", "BBB");
            List("a", "b", "c", "d");
            List("Kiran");


        }
    }
}
