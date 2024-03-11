using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using midoLibrary;
namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine($"the square is:{Calculator.square(9)}");
            Console.WriteLine($"the biggest of 9,23 is: {Calculator.biggest(9, 23)}");
            Console.WriteLine($"the factorial of 5 is: {Calculator.factorial(5)}");
            Console.WriteLine($"the reverse of 123 is: {Calculator.reverse(123)}");
        }
    }


}
