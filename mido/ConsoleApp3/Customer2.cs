namespace ConsoleApp3
{
    class Customer2
    {
        private int id;
        private string cname, city;

        public void SetDetails(int id, string cname, string city)
        {
            this.id = id;
            this.cname = cname;
            this.city = city;
        }

        public void getDeatils()
        {
            Console.WriteLine($"id = {id}, name = {cname}, location = {city}");
        }
    }
}
