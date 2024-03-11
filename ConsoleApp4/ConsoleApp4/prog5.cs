using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class prog5
    {
        static void Main()
        {
            int n = 0;
            Console.WriteLine("enter a value for n: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
           catch(FormatException e)
           //catch(Exception e)
            {
                Console.WriteLine("the supplied value is not an integer, the value will be set to 0");
                Console.WriteLine(e.Message);
                n = 0;
            }

            catch( OverflowException e)
            {
                Console.WriteLine("Supplied nuber is out of range, will set 1");
                n = 1;
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine($"square of {n} is {n*n}");
            }
        }
    }
}