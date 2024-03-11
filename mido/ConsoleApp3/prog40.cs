

namespace ConsoleApp3
{
    internal class prog40
    {
        static void Main()
        {
            
            int[] arr = new int[10];
            int temp;
            Console.Write("enter the number of elements:");
            int size = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"enter {size} elements: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
                if (arr[i] % 3 == 0)
                {
                    Console.WriteLine($"the smallest multiple of 3 is: {arr[i]}");
                    break;
                }
               
            }

        }
    }
}
