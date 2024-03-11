namespace ConsoleApp02
{
    class assignment3
    {
        public static int performArithmeticOperation(int num1, int num2, int op)
        {
            if (num1 < 0 || num2 < 0 || num1 > 32767 || num2 > 32767 || (op < 0 && op > 4))
            {
                return -1;
            }
            else if (op == 1)
                return num1 + num2;
            else if (op == 2)
                return num1 - num2;
            else if (op == 3)
                return num1 * num2;
            else return num1 / num2;
;        }
        static void Main()
        {
            int num1, num2, op;
            Console.Write("enter num1:");
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("select operation");
            Console.WriteLine("1.Adddition \n 2.Substraction \n 3.Multiplication \n 4.Division");
            op = Convert.ToInt32(Console.ReadLine());
            int v = performArithmeticOperation(num1, num2, op);
            if (v == -1)
                Console.WriteLine("invalid input");
            else 
                Console.WriteLine($"{v}");




        }
    }
}