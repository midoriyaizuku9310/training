namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string filename = "C:\\Users\\mdanish\\Documents\\test2.txt";

            bool status = File.Exists(filename);

            if(status)
            {
                Console.WriteLine($"{filename} file exists");
                IEnumerable<string> content = File.ReadLines(filename);
                foreach(string line in content)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"{filename} does not exist");
            }
        }
    }
}
