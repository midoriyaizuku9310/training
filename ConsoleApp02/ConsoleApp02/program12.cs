namespace ConsoleApp02
{
    class PersonModel
    {
        public int id { get; set; }
        public string name { get; set; }    
        public int age { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
    }
    class program12
    {
        static void Main()
        {
            PersonModel p1 = new PersonModel { id = 1, name = "mido", age = 22, gender = "male", city = "japan" };
            PersonModel p2 = new PersonModel { id = 2, name = "beidou", age = 29, city = "japan", gender = "female" };
            PersonModel p3 = new PersonModel { id = 3, name = "shinobu", age = 19, gender = "female", city = "inazuma" };
            PersonModel p4 = new PersonModel { id = 4, name = "arlecchino", age = 30, gender = "female", city = "fontaine" };

            List<PersonModel> list = [p1, p2, p3, p4];

            foreach (PersonModel p in list)
            {

                Console.WriteLine($"{p.id} {p.name} {p.age} {p.gender} {p1.city}");
            }
        }
    }
}
/*
 * POCO (Plain Old CLR Objects)
 * this is a class containing all public properties
 * the advantage is used to store database row into the object of this class
 * 
 * 
 * 
 * 
 * 
 */