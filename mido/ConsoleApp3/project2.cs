

namespace ConsoleApp3
{
    internal class project2
    {
        static void Main()
        {
            Console.WriteLine("hello project3");
            Console.WriteLine("working with arrays");

            /*
            string[] names = new string[5];

            for(int i=0;i<names.Length;i++)
            {
                Console.Write($"enter {i + 1} name: ");
                    Console.WriteLine();
                names[i]=Console.ReadLine();
            }

            Console.WriteLine("the names are:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");


            }
            */

            // int[] payments = new int[] { 100, 200, 300, 400, 500 };



            /*
            int[] payments = new int[5];
            int sum = 0,big=0,small=0;

            for (int i = 0; i < payments.Length; i++)
            {
                Console.Write($"enter {i + 1} payment: ");
                Console.WriteLine();
                payments[i] = Convert.ToInt32(Console.ReadLine());
                sum += payments[i];
                
                if (i == 0) big = small = payments[0];
                else if (payments[i] > big) big = payments[i];
                else if(payments[i] < small) small = payments[i];
            }
            for (int i = 0; i<payments.Length;i++)
            {
                Console.WriteLine($" {i+1}.{payments[i]}"); 
            }
            Console.WriteLine($"the sum of total payments is {sum}");
            Console.WriteLine($"the avg is {(double)sum/payments.Length}");
            Console.WriteLine($"the smallest value is : {small}");
            Console.WriteLine($"the biggest value is : {big}");

            */


            /*
            int[] arr = new int[6];
            int pos,val,choice;

            for(int i=0;i<3;i++)
            {
                Console.Write($"enter {i + 1} element: ");
                Console.WriteLine();
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.Write("for adding new element 1, for deteleting an element 2: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.Write("enter an element:");
                    val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("enter the position to be inserted:");
                    pos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    arr[pos - 1] = val;

                    Console.WriteLine("after insertion: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {arr[i]}");
                    }

                    break;

                case 2:
                    Console.Write("enter the position to be deleted: ");
                        pos = Convert.ToInt32(Console.ReadLine());
                    arr[pos - 1] = 0;
                    Console.WriteLine() ;
                    Console.WriteLine("after deletion: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {arr[i]}");
                    }
                    break;
            }
                
            */


            /*
            int row=0, col=0,i,j;
           

            Console.Write("enter no of rows: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("enter no of cols: ");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];

            for ( i=0;i<row;i++)
            {
                for( j=0;j<col;j++)
                {
                    Console.Write($"enter  arr[{i},{j}] element: ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine() ;
                }
            }

            Console.WriteLine($"the elements are: ");
            for (i = 0; i < row; i++)
            {
                for ( j = 0; j < col; j++)
                {

                    Console.Write($"{arr[i, j]} ");
                
                    
                }
                Console.WriteLine();
            }

           */


            /*
            int[][] items = new int[5][];

            items[0] = new int[] { 1, 2, 3 };
            items[1] = new int[] { 1, 2, 3, 4, 5 };
            items[2] = new int[] { 1 };
            items[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            items[4] = new int[] { 2, 3 };

            Console.WriteLine("----------Jagged array-----------");

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items[i].Length; j++)
                {
                    Console.Write($"{items[i][j]}");
                }
                Console.WriteLine();
            }

            */

            string[] students = new string[10];
            
            int choice;

            do
            {
                Console.WriteLine("******************");
                Console.WriteLine("Menu");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Display all students");
                Console.WriteLine("2. search student");
                Console.WriteLine("3. add student");
                Console.WriteLine("4. delete student");
                Console.WriteLine("5. edit student");
                Console.WriteLine("6. exit");
                Console.Write("enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());




                switch (choice)
                {
                    case 1:
                        Console.WriteLine("the students: ");

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i]))
                            {
                                Console.WriteLine($"{i + 1} .{students[i]}");
                            }
                            else if (string.IsNullOrEmpty(students[i]))
                                Console.WriteLine("the list is empty");
                            break;

                            
                        }
                        break;

                    case 2:
                        
                        Console.Write("enter the student name: ");
                        Console.WriteLine();
                        string name;
                        name = Console.ReadLine();
                        for(int i = 0;i<students.Length;i++)
                        {
                            if (students[i] == name)
                                Console.WriteLine("student found");
                            else Console.WriteLine("student not found");
                            break;
                        }
                        break;

                    case 3:

                        Console.Write("enter the student name: ");
                        string newName;
                        newName = Console.ReadLine();
                        for(int i=0;i<students.Length;i++)
                        {
                            if (string.IsNullOrEmpty(students[i]))
                            {
                                students[i] = newName;
                                break;
                            }
                            
                        }
                        break;

                    case 4:

                        Console.Write("enter the name of the student to be deleted: ");
                        name = Console.ReadLine();

                        for(int i=0;i<students.Length;i++)
                        {
                            if (students[i] == name)
                                students[i] = "";
                        }
                        break;

                    case 5:

                        Console.Write(" student to be edited: ");
                        string editname = Console.ReadLine();
                        string nname;
                        Console.WriteLine() ;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] == editname)
                            {
                                Console.Write("enter the new name: ");
                                nname = Console.ReadLine();
                                students[i] = nname;
                                break;
                            }
                            else Console.WriteLine("write the correct name");
                            break;
                        }
                        break;

                    case 6:

                        Console.WriteLine("exiting");
                        break;

                }
            }
            while (choice != 6);



            






        }



    }
}
