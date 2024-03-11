using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class prog7
    {
        
        static void Main()
        {
            Action display = () => Console.WriteLine("hello from display action");
            display();

            Action<string> wishes = x => Console.WriteLine($"hello {x}");
            wishes("danish");

            Func<string, int> len = x => x.Length;
            Console.WriteLine($"length of string {len("danish")}");

            Func<string, string> u = x => x.ToUpper();
            Console.WriteLine($"upper of string {u("danish")}");

            Func<string, string> fn = x => x.Substring(0, x.IndexOf(" "));
            Console.WriteLine($"first name of mido beidou is {fn("mido beidou")}");

            Func<string, string> ln = x => x.Substring(x.LastIndexOf(" ") + 1);
            Console.WriteLine($"first name of mido beidou is {ln("mido beidou")}");

            Func<string, int> fnl = x => fn(x).Length;
            Console.WriteLine($"the length of first name is {fnl("mido danish")}");
        }
    }
}
/*
 * ction : refers to any anonymous method or lambda without returning value
 * Func <datatype, datatype> for returning value
 * Predicate
 */