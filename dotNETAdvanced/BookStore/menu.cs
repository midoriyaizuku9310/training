using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class menu
    {
        public static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("Book Menu");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.Display books\n2.Add books\n3.search book\n4.delete book\n0.exit");
                Console.WriteLine("select your operation:");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("----------");
                switch (choice)
                {
                    case 1:
                        getBooks();
                        break;
                    case 2:
                        addBooks();
                        break;
                    case 0:
                        break;
                }


            }
            while (choice != 0);

            static void getBooks()
            {
                BookDisconnected dal = new BookDisconnected();
                List<bookStore> books = dal.getBooks();
                foreach(bookStore book in books)
                {
                    Console.WriteLine($"{book.bname}\t{book.bid}\t{book.bauthor}\t{book.pname}\t{book.copies}\t{book.price}");
                }
            }

            static void addBooks()
            {
                BookDisconnected dal = new BookDisconnected();

                bookStore bs = new bookStore();
                Console.Write("Bookname:");
                bs.bname = Console.ReadLine();
                Console.Write("book id:");
                bs.bid = int.Parse(Console.ReadLine());
                Console.Write("author name:");
                bs.bauthor = Console.ReadLine();
                Console.Write("publisher:");
                bs.pname = Console.ReadLine();
                Console.Write("stock:");
                bs.copies = int.Parse(Console.ReadLine());
                Console.Write("price:");
                bs.price = int.Parse(Console.ReadLine());

                dal.addBooks(bs);
                Console.WriteLine("\n record inserted");


            }



        }
       
    }
}
