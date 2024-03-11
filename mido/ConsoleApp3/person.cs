namespace ConsoleApp3
{
    class person
    {
        private int id, age;
        private string pname, gender;

        public void setDetails(int id, string pname, string gender, int age)
        {
            this.id = id;
            this.pname = pname;
            this.gender = gender;
            this.age = age;

        }

        public void getDetails()
        {
            Console.WriteLine($"name: {pname}, age: {age}, gender: {gender}, id: {id}");
        }
    
    
    }
}
