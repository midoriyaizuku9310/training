using midoLibrary;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is conApp03");
            Console.WriteLine(hourClass.wishes());
        }
    }
}
/*
 Demo1:		
Step1: create a class library and name it as KiranLibrary01
		Create HelloClass with Wishes method 
 public class HelloClass
 {
     public static string Wishes()
     {
         int hour = DateTime.Now.Hour;
         if (hour < 12) return "Good Morning!";
         else if (hour < 16) return "Good Afternoon!";
         else return "Good Evening";
     }
 }

Right click and build the project
------------------------------------------------------
Step2:	Create ConApp and name it as ConApp03
	Right click on project and set as startup project
		Import KiranLIbrary01 and consume	(right click on dependencies => Add Project reference => Select KiranLibrary )

using KiranLibrary;
namespace ConsoleApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloClass.Wishes());

        }
    }
}
*/