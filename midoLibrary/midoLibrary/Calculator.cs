using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midoLibrary
{
    public class Calculator
    {
        public static int square(int n)
        {
            return n * n;
        }
        public static int biggest(int a, int b)
        {
            if (a > b) return a;
            else if (a == b) return 0;
            else return b;
        }

        public static int factorial(int n)
        {
            for(int i=n-1;i>0;i--)
            {
                n = n * i;
            }
            return n;
        }

        public static int reverse(int n)
        {
            int temp, rev=0;
            while(n >0)
            {
                temp= n % 10;

                rev = rev * 10 + temp;

                n = n / 10;
            }
            return rev;
        }

    }
}
