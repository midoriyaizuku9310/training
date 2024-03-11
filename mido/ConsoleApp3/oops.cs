using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Customer
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


     class oops
    {
         static void Main()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();

            c1.SetDetails(1, "mido", "japan");
            c2.SetDetails(2, "beidou", "japan");

            c1.getDeatils();
            c2.getDeatils();


        }

    }
}
