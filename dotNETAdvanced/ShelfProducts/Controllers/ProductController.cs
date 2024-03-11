using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShelfProducts.Models;

namespace ShelfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        [Route("getAllProducts")]
        public List<Product> GetProducts()
        {
             ProductDataAccess dal = new ProductDataAccess();
            List<Product> products = dal.GetProducts();
            return products;
        }
    }
}
