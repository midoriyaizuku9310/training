using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class @new
    {
        static void Main()
        {
            int[] arr = new int[5];
            int Max = 0;
            Console.WriteLine("enter 5 elements: ");
            for(int i=0;i<5;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());    
            }
            for(int i=0;i<5;i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
                
            }
            Console.WriteLine($"max :{Max} ");

        }
    }
}
