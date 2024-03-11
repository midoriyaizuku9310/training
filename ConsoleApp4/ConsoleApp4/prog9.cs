using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    class Product
    {
        private int stockLeft;
        private string name;
        private string brandName;
        private string productCode;
        private double price;

        public Product( string name, string productCode, string brandName,  int stockLeft, double price)
        {
            this.stockLeft = stockLeft;
            this.name = name;
            this.brandName = brandName;
            this.productCode = productCode;
            this.price = price;

        }
        public double Price { get { return price; } }
        public string Name { get { return brandName; } }
        
        public void getDetails()
        {
               Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7}",name,productCode,brandName,stockLeft,price); 
        }

    }
    
    class prog9
    {
        static void Main()
        {
            List<Product> products = new List<Product>() {
            new Product("Dairy milk","#CA 12 DA-159","Cadbury",500,25),
            new Product("Milky bar","#NE 18 MI-162","Nestle",600,10),
            new Product("Lifebuoy","#UN 20 LI-285","Unilever",195,31), 
            new Product("Almond oil","#BA 11 AL-789","Bajaj",400,72), 
            new Product("Fuse","#CA 17 FU-110","Cadbury",300,20)
};
            

            Console.WriteLine("Enter a search type: \n1.By brand name\n2.By price"); int
            choice = int.Parse(Console.ReadLine());
          
            if (choice == 1)
            {
              
                Console.WriteLine("Enter the brand name:"); 
                string name = Console.ReadLine();
                Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7} ", "Name", "Product code", "Brand name", "Stock left", "Price");
                foreach (Product p in products)
                {
                    if(p.Name == name)
                    {
                        p.getDetails();
                    }
                }
                

            }
            if (choice == 2)
            {
                Console.WriteLine("Enter the price:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7} ", "Name", "Product code", "Brand name", "Stock left", "Price");
                foreach (Product p in products)
                {
                    if (p.Price == price)
                    {
                        p.getDetails();
                    }
                    
                }


            }






        }
    }
}
