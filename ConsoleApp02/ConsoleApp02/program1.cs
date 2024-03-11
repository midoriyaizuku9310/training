using System.Net.Http.Headers;

namespace ConsoleApp02
{
    class person2
    {
        private int age, id;
        private string name;

        public person2()
        {
            id = 0;
            age = 0;
            name = "not provided";
        }
        public person2(int age,int id, string name)
        {
            this.age = age;
            this.id = id;   
            this.name = name;   
        }
        public void getDetails()
        {
            Console.WriteLine($"id: {id}, name: {name}, age: {age}");

        }
        
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            person2 p1 = new person2();
            p1.getDetails();
            person2 p2 = new person2(22, 35, "danish");
            p2.getDetails();
        }
    }
}
