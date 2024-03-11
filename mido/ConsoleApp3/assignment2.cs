namespace ConsoleApp3
{
    internal class assignment2
    {
        static int maximumSum(int[] numbers, int size)
        {
            int even = 0;
            int odd = 0;
            int i;
            for(i=0;i<size;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }

            }
            if (even > odd)
                return even; else return odd;
        }
        static void Main()
        {
            int i;
            Console.Write("enter the number of elements: ");
           if (int.TryParse(Console.ReadLine(), out int size))
            {
                if (size < 0)
                    Console.WriteLine("invalid array size");
            }
           else 
                Console.WriteLine("enter a valid number");
        
                
            int[] numbers = new int[size];
            Console.WriteLine();
            Console.WriteLine($"enter {size} elemnts: ");
            
            for(i=0;i<size;i++)
            {
               
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    Console.WriteLine("invalid input");
                    return;
                }
            }
            

            Console.WriteLine($"the max sum is: {maximumSum(numbers,size)}");
        }
    }
}
