namespace ConsoleApp02
{
    class student
    {
        private int id, age;
        private string name;

        public student(int id =35, int age = 22, string name = "danish")
        {
            this.id = id;
            this.age = age; 
            this.name = name;   
        }

        public void getDetails()
        {
            Console.WriteLine($"the id is :{id}, the name is :{name}, the age is: {age}");
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.getDetails();

            student s2 = new student(1, 20, "mido"); 
            s2.getDetails();
        }
    }
}
