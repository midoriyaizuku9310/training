using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp3
{
    enum number
    {
        one, two, three, four, five
    }
    internal class project4
    {
        static void Main()
        {
            /*Console.WriteLine("program4");

            string name ="danish";

            Console.WriteLine($" my name is {name}");

            Console.WriteLine($"the length of name is {name.Length}"); 

            int v = 10;
            Console.WriteLine($"the digit is {v}"); 
            Console.WriteLine($"the next digit is {v+1} the square is {v*v}"); */

            /* Console.WriteLine("enter value for a");
             int a = Convert.ToInt32( Console.ReadLine() );

             Console.WriteLine("enter value for b");
             int b = Convert.ToInt32( Console.ReadLine() ) ;

             if (a > b)
                 Console.WriteLine($"{a} is biggest");
             else if (a == b)
                 Console.WriteLine($"a is equal to b");
             else
                 Console.WriteLine($"{b} is biggest"); */


            /*Console.WriteLine("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine($" the num is zero");
            }
            else if (num > 0)
            {
                Console.WriteLine($"the num {num} is positive");
            }
            else
                Console.WriteLine($"the num {num} is negative"); */


            /* Console.WriteLine("enter your marks in range of 0-100");
             int marks = Convert.ToInt32( Console.ReadLine() );
             if (marks >= 0 && marks <= 100)
             {
                 Console.WriteLine($"the marks {marks} falls in the range of 0-100");

             }
             else
                 Console.WriteLine($"the marks {marks} does not fall in the specified range"); */


            /*Console.WriteLine("enter your whole name:");
            string fn = Console.ReadLine();

            int charPos = fn.IndexOf(" ");

            Console.WriteLine($"your last name is {fn.Substring(charPos)}"); */


            /* number num = number.three;


             switch(num)
             {
                 case (number.one):
                     Console.WriteLine("your number is 1");
                     break;
                 case (number.two):
                     Console.WriteLine("your number is 2");
                     break;
                     case (number.three):
                     Console.WriteLine("your number is 3");
                     break;
                     case (number.four):
                     Console.WriteLine("your number is 5");
                     break;
                     case (number.five):
                     Console.WriteLine("your number is five");
                     break;
                 default:

                     Console.WriteLine("brrrrrr");
                     break;

             }
            */


            /*
                int i;
                i = 1;
                while (i<= 5)
                {
                    Console.WriteLine($"{i * 2} {(i*2)-1} {Math.Pow(i,2)} ");

                    i++;
                }

                Console.WriteLine("       ");
                int j;
                j = 5;
                while (j >0)
                {
                    Console.WriteLine($"{j} {j*2}");
                    j--;
                }

            */


            /*
            int i;

            string msg = string.Empty;

            Console.WriteLine("using while");
            i = 1;

            while (i<=10)
            {
                msg += $"{i} ";
                i++;    
            }
            Console.WriteLine($"{msg}");

            Console.WriteLine("using for loop");

           
            msg = string.Empty;

            for (i = 1; i <= 10; i++)
            {
                msg += i;
               
            }
            Console.WriteLine(msg);
            */


            /*
            Console.WriteLine("enter the number for table:");
            int t = Convert.ToInt32(Console.ReadLine());
            int i;
           for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{t} X {i} = { t* i}");
            }
            */



            /*
            Console.WriteLine("fibonacci");


            int num,one=1,zero=0,sum;
            Console.WriteLine("enter number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (i=1;i<=num;i++)
            {
                if (i > 2)
                {
                    sum = zero + one;
                    zero = one;
                    one = sum;
                    Console.WriteLine(sum);
                }
                else if (i == 1)
                {
                    Console.WriteLine(zero);
                }
                else { Console.WriteLine(one); }
            }
            */



            /*
            int hour = DateTime.Now.Hour;
            if (hour < 12)
                Console.WriteLine("Good Morning");
            else if (hour > 12 && hour < 16)
                Console.WriteLine("Good Afternoon");
            else {
                Console.WriteLine("good evening");
                    }
            Console.WriteLine($"The current time is {DateTime.Now.ToLongTimeString()}");


            string today = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine($"today is {today}");

            if (today == "Sunday" || today == "Saturday")
            {
                Console.WriteLine("its weekend");
            }
            else
                Console.WriteLine("working day");
            */



            /*
            Console.Write("Enter any letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"the letter is : {ch}");
            Console.WriteLine($"the ascii value of {ch} is {(int)ch}");

            for(int i=65;i<=122;i++)
            {
                Console.WriteLine($"for the ascii value {i} the character is {(char)i}");
            }
            */



            /*
            Console.Write("enter any alphabet: ");

            char nch = Convert.ToChar(Console.ReadLine());

            switch (nch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"{nch} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{nch} is a consonant");
                    break;
            }
            string sch = Convert.ToString(nch);
            if(nch>=65 && nch <= 90)
            {
                Console.WriteLine($"the lower case of {nch} is {sch.ToLower()}");
            }
            else
            {
                Console.WriteLine($"the upper case of {nch} is {sch.ToUpper()}");
            }
            */



            /*
            int n, c = 0,d=0,t;
                Console.Write("Enter a value:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"original n is {n} and after removing last digit {n / 10}");
            Console.WriteLine($"the last digit is {n % 10}");
            int og = n;
            while (n > 0)
            {
                c++;
                n = n / 10;
                t = n % 10;
                if (t == 0)
                    d++;
            }
            Console.WriteLine($"the number of digits in {og} are {c}");
            Console.WriteLine($"the number of zeroes in {og} are {d}");
        
            */




            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=5; j++)
                {
                    Console.Write($"{j} ");
                    
                }
                Console.WriteLine();
            }




        }

    }
}
