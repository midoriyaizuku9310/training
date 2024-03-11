namespace ConsoleApp3
{
    internal class assignment
    {
        static double calculateSal(int sal, int shifts)
        {
            int add,remain;
           
            remain = (int)(sal - (double)(sal * 0.5));
            add = (int)(sal*(double)(shifts * 0.02));
            return remain + add;
        }
        static void Main()
        {
            int sal, shifts;
            Console.Write("enter the salary: ");
            sal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (sal > 8000) Console.WriteLine("Salary too large");
            else if (sal < 0) Console.WriteLine("Salary is too small");
            
            else 
                Console.Write("enter the no of shifts: ");
                shifts = Convert.ToInt32(Console.ReadLine());
                if (shifts < 0) Console.WriteLine("Shifts too small");
                else Console.WriteLine(calculateSal(sal, shifts));
        }
    }
}
