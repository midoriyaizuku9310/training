using Microsoft.AspNetCore.Mvc;
using MVCApp2.Models;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;

namespace MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentsContext? studentsContext;

        public HomeController(StudentsContext context)
        {
            studentsContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Products()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Products(products p)
        {
            //string StringFIleName = UploadFile(p);
            //Console.WriteLine(p.image);
            byte[] varBinaryStream;
            using (var memoryStream = new MemoryStream())
            {
                // Copy the file contents to the memory stream
                p.image.CopyToAsync(memoryStream).Wait();

                // Retrieve the byte array from the memory stream
                varBinaryStream = memoryStream.ToArray();
            }

            //Console.WriteLine(varBinaryStream);
            ////Console.WriteLine(StringFIleName);

            //Image img;
            //using (var memoryStream = new MemoryStream(varBinaryStream))
            //{
            //    img = Image.FromStream(memoryStream);
            //}

            //byte[] imageBytes;
            //using (MemoryStream memoryStream = new MemoryStream())
            //{
            //    img.Save(memoryStream, ImageFormat.Jpeg);
            //    imageBytes = memoryStream.ToArray();
            //}

            //string base64Image = Convert.ToBase64String(imageBytes);

            //// Pass the base64 image string to the view
            //ViewBag.ImageData = base64Image;

            //return View();

            string base64String = Convert.ToBase64String(varBinaryStream);
            ViewBag.ImageData = base64String;
            Console.WriteLine(base64String);
            Product pr = new Product
            {
                Id = p.Id,
                CategoryId = p.categoryId,
                CategoryName = p.categoryName,
                SubCategoryId = p.subCategoryId,
                SubCategoryName = p.subCategoryName,
                ProductId = p.productId,
                ProductName = p.productName,
                Price = Convert.ToString(p.price),
                Rating = Convert.ToString(p.rating),
                Image = varBinaryStream
            };
            studentsContext.Products.Add(pr);
            studentsContext.SaveChanges();
            return View();
        }



        
    }
}