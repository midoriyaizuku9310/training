using System.Xml.Linq;

namespace ConsoleApp02
{
    class bank
    {
        private int id, accountBalance;
        private string cname;

        public bank(int id, string name, int accountBalance = 0)
        {
            this.id = id;
            this.accountBalance = accountBalance;
            this.cname = name;
        }

        public void deposit(int amount = 0)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine();
                Console.WriteLine($"successfully deposited {amount}");
                Console.WriteLine("--------------");
            }
            else
                Console.WriteLine("enter a valid amount");
            Console.WriteLine("--------------");

        }

        public void withdraw(int amount)
        {
            if ((accountBalance - amount) <= 0)
            {
                Console.WriteLine("you dont have enough money");
                Console.WriteLine("--------------");
            }
            else
            {
                accountBalance -= amount;
                Console.WriteLine($"withdrawal of {amount} successful");
                Console.WriteLine("--------------");

            }
        }
        public void getDetails()
        {
            Console.Write($"customer name: {cname}");
            Console.WriteLine();
            Console.Write($"customr id: {id}");
            Console.WriteLine();
            Console.WriteLine($"Current balance: {accountBalance}");
            Console.WriteLine("--------------");
        }
    }
    internal class Program3
    {
        static void Main(string[] args)
        {
            int id, balance, withdraw, choice1, choice2;
            string cname;
           
            do
            {
                Console.WriteLine("Welcome to mido's bank \n 1.perform transaction \n 2.create an account \n 3.exit");
                choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:

                        Console.WriteLine("enter the account details: ");
                        Console.Write("enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("enter your name: ");
                        cname = Console.ReadLine();

                        bank b = new bank(id, cname);
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("choose an option: \n 1.check balance \n 2.withdraw \n 3.deposit \n 4.exit");
                            choice2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (choice2)
                            {
                                case 1:
                                    b.getDetails();
                                    break;

                                case 2:
                                    Console.Write("enter the amount to withdraw: ");
                                    withdraw = Convert.ToInt32(Console.ReadLine());
                                    b.withdraw(withdraw);
                                    Console.WriteLine();

                                    break;

                                case 3:
                                    Console.Write("enter amount to deposit: ");
                                    balance = Convert.ToInt32(Console.ReadLine());
                                    b.deposit(balance);


                                    Console.WriteLine();
                                    break;
                                case 4:
                                    Console.WriteLine("thank you!!");
                                    Console.WriteLine("--------------");

                                    Console.WriteLine();

                                    break;

                            }

                        }
                        while (choice2 != 4);
                        break;
                        

                    case 2:
                        Console.WriteLine("enter new id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter your name :");
                        cname = Console.ReadLine();
                        bank b2 = new bank(id, cname);

                        Console.WriteLine("enter the amount to deposit: ");
                        balance = Convert.ToInt32(Console.ReadLine());
                        if (DateTime.Now.ToString("dddd") == "Friday")
                        {
                            balance += 10000;
                        }
                        else if (DateTime.Now.ToString("dddd") == "Saturday")
                        {
                            balance += 500;
                        }
                        else balance += 0;
                        b2.deposit(balance);
                        Console.WriteLine($"account created successfully on {DateTime.Now.Date}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you!!!");
                        break;


                }





            }
            while (choice1 != 3);
        }
    }
}
