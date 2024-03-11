namespace ConsoleApp4;

class prog2
{
    static void Main(String[] args)
    {
        StreamWriter sw = new StreamWriter("C:\\Users\\mdanish\\Documents\\test2.txt");
        sw.WriteLine("firstline");
        sw.WriteLine("second line");
        sw.WriteLine("third line");
        sw.WriteLine("last line");
        sw.Write($"file created successfully on {DateTime.Now.ToString()}");

        Console.WriteLine("file created");
        sw.Close();

        Console.ReadKey();
    }
}

