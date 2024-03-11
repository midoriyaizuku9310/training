namespace ConsoleApp02
{

class assignment5
    {
        public static void sortAndDelete(int n, int[] arr1, int d)
        {
            int i,pos = 0,count=0,size; 
                        Array.Sort(arr1);

            if (n < 0)
            {
                Console.WriteLine("invalid input");
            }
           
            
                for (i = 0; i < n; i++)
                {
                    if (arr1[i] == d)
                    {

                        pos = i;
                    while(i<n && arr1[i] ==d)
                    {
                        i++;
                    }
                    i--;
                    }
                }

                for (i = pos; i < n - 1; i++)
                {
                    arr1[i] = arr1[i + 1];
                }
            Array.Resize(ref arr1, n - 1);
            
            for(i=0;i<n-1;i++)
            {
                Console.WriteLine($"{arr1[i]}");
            }

        }
        static void Main()
        {
            int n,d;
            Console.WriteLine("enter array size: ");
            n = Convert.ToInt32 (Console.ReadLine());
            int[] arr1 = new int[n];

            Console.WriteLine($"enter {n} elements: ");
            for(int i=0;i<n;i++)
            {
                arr1[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter the element to delete:");
            d = Convert.ToInt32(Console.ReadLine());

            sortAndDelete(n, arr1, d);

        }
    }


}
