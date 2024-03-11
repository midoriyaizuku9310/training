namespace ConsoleApp02
{
    class assignment4
    {
        public static int SumOddDigits(int n)
        {
            int sum = 0,temp;
            if (n < 0 || n > 32767)
                return -1;
            while (n > 0)
            {
                    temp = n % 10;
                    n = n / 10;
                    if (temp % 2 != 0)
                    {
                        sum += temp;
                    }
            }
            return sum;
        }
        static void Main()
        {
            int n;
            Console.Write("enter an integer ");
            n = Convert.ToInt32(Console.ReadLine());    
            int v = SumOddDigits(n);
            if (v == -1)
                Console.WriteLine("invalid input");
            else
                Console.WriteLine($"{v}");
        }
    }
}