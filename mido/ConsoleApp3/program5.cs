using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class program5
    {
        static void Main()
        {
            Console.WriteLine("program5");

            string v1 = "hi hello";
            Console.WriteLine("this is "+v1+" and its datatype is"+ v1.GetType());

            int v2 = 1000;
            Console.WriteLine("this is " + v2 + " and its datatype is" + v2.GetType());  

            char v3 = 'a';
            Console.WriteLine("this is " + v3 + " and its datatype is" + v3.GetType());

            double v4 = 121.212D;
            Console.WriteLine("this is " + v4 + " and its datatype is" + v4.GetType());  

            bool v5 = true;
            Console.WriteLine("this is " + v5 + " and its datatype is" + v5.GetType());
            Console.WriteLine(true);
            Console.WriteLine(123e4);

            Console.WriteLine(Convert.ToDouble(v2));
            Console.WriteLine(Convert.ToInt32(v5));

            Console.WriteLine("enter your user name ");
            string username = Console.ReadLine();
            Console.WriteLine(username);


          
        }
    }
}
