namespace ConsoleApp4
{
    class prog3
    {

        static void Main()
        {
            string[] names = new string[5];
            Console.WriteLine("enter five names:");

            for(int i=0;i<5;i++)
            {
                names[i] = Console.ReadLine();
            }

            StreamWriter sw = new StreamWriter("C:\\Users\\mdanish\\Documents\\test3.txt");
            foreach(string name in names)
            {
                sw.WriteLine(name);
                
            }
            sw.Close();


        }
    }
}