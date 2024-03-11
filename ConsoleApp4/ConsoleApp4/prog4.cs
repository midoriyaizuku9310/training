using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class prog4
    {
        static void Main()
        {
            FileStream fs;
            fs = new FileStream("C:\\Users\\mdanish\\Documents\\test3.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Added at end");
            sw.Close();
        }
        }
}