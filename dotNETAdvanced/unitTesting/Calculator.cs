using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            int result = x + y;
;
            return result;
        }

        public int Sub(int x, int y)
        {
            int result = x - y;
;
            return result;
        }

        public int Mul(int x, int y)
        {
            int result = x * y;
;
            return result;
        }

        public int Divide(int x, int y)
        {
            
                if(y==0)
                {
                    throw new MyAppException("why 0");

                }
                int result = x / y;
                
                return result;
            
           
        }
    }

    public class MyAppException : Exception
    {
        public MyAppException(string errMsg):base(errMsg)
        {
           
        }
    }
}
