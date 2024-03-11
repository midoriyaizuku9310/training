namespace ConsoleApp3
{
    internal class assignment3
    {
        static int performArithmeticOperation(int num1, int num2, int op)
        {
            switch (op)
            {
                case 1:
                    return num1 + num1;
                case 2:
                    return num2 - num2;
                case 3:
                    return num1 * num2;
                case 4:
                    return num1 / num2;
                default:
                    return -1;
            }
        }
        static void Main()
        {

            int num1, num2, op;
            Console.Write("enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("invalid input");
                return;
            }
            Console.WriteLine("choose the operation: \n 1.add \n 2.substract \n 3.multiply \n 4.divide");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(performArithmeticOperation(num1, num2,op)) ;
        }
    }
}
