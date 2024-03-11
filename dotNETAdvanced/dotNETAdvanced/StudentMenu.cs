using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dotNETAdvanced
{
    internal class StudentMenu
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("select your operation:");
                Console.WriteLine("1.view students\n2.Add student\n3.delete student\n4.modify data\n5.total age\n6.deleteCommon\n7.commonFind\n0.exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        displayAll();
                        break;
                    case 2:
                        addStudent();
                        break;
                    case 3:
                        deleteStudent();
                        break;
                        case 4:
                        updateStudent();
                        break;
                    case 5:
                        sumAge();
                        break;
                    case 6:
                        deleteComm();
                        break;
                    case 7:
                        comm();
                        break;

                    case 0:
                        Console.WriteLine("exiting");
                        break;
                }
            } while (choice != 0);
            static void displayAll()
            {
                //StudentConnected dal = new StudentConnected();
                StudentDisconnected dal = new StudentDisconnected();
                List<Student> students = dal.getStudent();

                foreach (Student stu in students)
                {
                    Console.WriteLine($"{stu.sid}\t{stu.sname}\t{stu.age}\t{stu.tid}");
                }
            }

            static void comm()
            {
                StudentConnected dal = new StudentConnected();
                Console.WriteLine("enter student name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter student age:");
                int age = int.Parse(Console.ReadLine());

                int comm =dal.commStu(name, age);
                Console.WriteLine($"no of common rows:{comm}");
            }
            
            static void addStudent()
            {
                Student stu = new Student();

                Console.Write("Enter student id:");
                stu.sid = int.Parse(Console.ReadLine());
                Console.Write("Enter  student name:");
                stu.sname = Console.ReadLine();
                Console.Write("Enter age:");
                stu.age = int.Parse(Console.ReadLine());
                Console.Write("Enter teacher id:");
                stu.tid = int.Parse(Console.ReadLine());

                //insert using DAL object
                //StudentConnected dal=new StudentConnected ();
                StudentDisconnected dal = new StudentDisconnected();
                
               
                dal.addStudent(stu);
                Console.WriteLine("Record inserted");
                
              
               

                displayAll();
            }

            static void updateStudent()
            {
                Student stu = new Student();

                
                Console.Write("Enter  student name:");
                stu.sname = Console.ReadLine();
                Console.Write("Enter student id to update:");
                stu.sid = int.Parse(Console.ReadLine());
                Console.Write("Enter age:");
                stu.age = int.Parse(Console.ReadLine());
                Console.Write("Enter teacher id:");
                stu.tid = int.Parse(Console.ReadLine());

                //insert using DAL object
                 StudentConnected dal = new StudentConnected();
                //StudentDisconnected dal = new StudentDisconnected();

                dal.updateStudent(stu);
              

                Console.WriteLine("updated");

                displayAll();
                              

               
            }

            static void deleteStudent()
            {
                Console.Write("Enter sid for delete:");
                int sid = int.Parse(Console.ReadLine());

                //StudentConnected dal = new StudentConnected();
                StudentDisconnected dal = new StudentDisconnected();
                dal.deleteStudent(sid);
                Console.WriteLine("Record deleted");

                displayAll();
            }

            static void sumAge()
            {
                StudentConnected dal = new StudentConnected();

                int sumage = dal.totalAge();
                Console.WriteLine($"total age:{sumage} ");
            }

            static void deleteComm()
            {
                Console.WriteLine("enter student name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter the age");
                int age = int.Parse(Console.ReadLine());

                StudentConnected dal = new StudentConnected();
                dal.deleteSP(name, age);
                Console.WriteLine("delete record");
                displayAll();
               
            }


            
        }
    }
}
