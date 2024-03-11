using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace MVCApp2.Controllers
{
    public class UsersController : Controller
    {
        private readonly StudentsContext _context;

        public UsersController(StudentsContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,AuthType,Password,Email,Name,PhoneNumber")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserLogin");
            }
            return RedirectToAction("Create");
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,AuthType,Password,Email,Name,PhoneNumber")] User user)
        {
            if (id != user.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserName))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.UserName == id);
        }
        public IActionResult UserLogin()
        {
            return View("UserLogin");
        }

        [HttpPost]
        public ActionResult UserLogin(Models.Login login)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
            //bool type = _context.Users.FirstOrDefault(user.AuthType == "Admin");


            if (user != null)
            {
                HttpContext.Session.SetString("Username", login.UserName);
                //TempData["Username"] = login.UserName;
                if (user.AuthType=="Admin")
                {
                    //ViewBag.username = login.UserName;
                    //Response.Cookies.Append("UserCookie", "user", new CookieOptions
                    //{
                    //    Expires = DateTime.Now.AddDays(1)
                    //});


                    List<Claim> claims = new List<Claim>
                    {
                        new Claim("Username",login.UserName),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                    

                    return RedirectToAction("AdminHomePage","Users");
                }
                else
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim("Username",login.UserName),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                    
                    return RedirectToAction("Homepage", "Products");
                }
            }
            else
            {

                ViewBag.ErrorMessage = "Invalid username or password";
                return View("UserLogin");
            }
        }


        [Route("UserDashboard/{SubCategoryName}")]
        public async Task<IActionResult> UserDashboard(string? SubCategoryName)
        {
            var listOfProducts = await _context.Products.ToListAsync();
            //HashSet<string> li = new HashSet<string>();
            List<Product> li = new List<Product>();
            foreach (var x in listOfProducts)
            {
                if (x.SubCategoryName == SubCategoryName)
                {
                    li.Add(x);
                }
            }

            //List<string> li1 = new List<string>(li);
            return View(li);
        }

        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult addToCart(int Id)
        {

            var p = _context.Products.FirstOrDefault(m => m.Id == Id);
            //string username = User.FindFirst(ClaimTypes.Username);
            //string username = ViewBag.Username as string;
            //string username = HttpContext.Request.Cookies["Username"];
            //Console.WriteLine(username);
            //List<Claim> claims = TempData["username"] as List<Claim>;
            //Claim usernameClaim = claims.FirstOrDefault(c => c.Type == "Username");
            //string username = usernameClaim?.Value;

            string username = HttpContext.Session.GetString("Username");
            if (username == null)
            {
                return RedirectToAction("UserLogin");
            }
            else
            {
                Cart c = new Cart
                {
                    Price = p.Price,
                    ProductId = Convert.ToInt32(p.ProductId),
                    Name = p.ProductName,
                    UserName = username
                };

                _context.Carts.Add(c);
                _context.SaveChanges();
                return RedirectToAction("HomePage", "Products");
            }
        }

        public IActionResult AdminHomePage()
        {
            return View();
        }

        public async Task<IActionResult> ManageCategories()
        {
            var listOfProducts = await _context.Products.ToListAsync();
            HashSet<string> li = new HashSet<string>();
            foreach (var x in listOfProducts)
            {
                li.Add(x.CategoryName);
            }
            List<string> li1 = new List<string>(li);
            return View(li1);
        }

        
        [Route("DeleteCategory/{CategoryName}")]
        public async Task<IActionResult> DeleteCategory(string CategoryName)
        {
            var entityToDelete = _context.Products.SingleOrDefault(e => e.CategoryName == CategoryName);

            if (entityToDelete != null)
            {
                _context.Products.Remove(entityToDelete);
                _context.SaveChanges();
                // Handle any additional logic or redirect as needed
            }

            return RedirectToAction("ManageCategories");

        }

        [Route("ManageSubCategory/{CategoryName}")]
        public async Task<ActionResult> ManageSubCategoryAsync(string CategoryName)
        {
            var listOfProducts = await _context.Products.ToListAsync();
            HashSet<string> li = new HashSet<string>();
            string CategoryId="";
            foreach (var x in listOfProducts)
            {
                if (x.CategoryName == CategoryName)
                {
                    li.Add(x.SubCategoryName);
                    CategoryId = x.CategoryId;
                }
            }
            ViewBag.CategoryName = CategoryName;
            ViewBag.CategoryId = CategoryId;
            List<string> li1 = new List<string>(li);
            return View(li1);
        }


        [Route("DeleteSubCategory/{SubCategoryName}")]
        public async Task<IActionResult> DeleteSubCategory(string SubCategoryName)
        {
            var entityToDelete = _context.Products.SingleOrDefault(e => e.SubCategoryName == SubCategoryName);

            if (entityToDelete != null)
            {
                _context.Products.Remove(entityToDelete);
                _context.SaveChanges();
                // Handle any additional logic or redirect as needed
            }

            return RedirectToAction("ManageCategories");

        }

        [Route("ManageProduct/{SubCategoryName}")]
        public async Task<ActionResult> ManageProduct(string SubCategoryName)
        {
            var listOfProducts = await _context.Products.ToListAsync();
            List<Product> li = new List<Product>();
            foreach (var x in listOfProducts)
            {
                if (x.SubCategoryName == SubCategoryName)
                {
                    li.Add(x);
                }
            }
            ViewBag.SubCategoryName = SubCategoryName;
            return View(li);
        }

        [Route("Products1/{CategoryName}")]
        public async Task<IActionResult> Products1Async(string CategoryName)
        {

            var listOfProducts = await _context.Products.ToListAsync();
            //List<Product> li = new List<Product>();
            string CategoryId = "";
            foreach (var x in listOfProducts)
            {
                if (x.CategoryName == CategoryName)
                {
                    //li.Add(x);
                    CategoryId = x.CategoryId;
                }
            }
            ViewBag.CategoryId = CategoryId;
            ViewBag.CategoryName = CategoryName;
            return View();
        }


        [Route("Products2/{SubCategoryName}")]
        public async Task<IActionResult> Products2(string SubCategoryName)
        {
            var listOfProducts = await _context.Products.ToListAsync();
            //List<Product> li = new List<Product>();
            string CategoryId = "";
            string CategoryName = "";
            string SubCategoryId = "";
            foreach (var x in listOfProducts)
            {
                if (x.SubCategoryName == SubCategoryName)
                {
                    //li.Add(x);
                    CategoryId = x.CategoryId;
                    CategoryName = x.CategoryName;
                    SubCategoryId = x.SubCategoryId;
                }
            }
            ViewBag.CategoryId = CategoryId;
            ViewBag.CategoryName = CategoryName;
            ViewBag.SubCategoryId = SubCategoryId;
            ViewBag.SubCategoryName = SubCategoryName;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Clear();
            return RedirectToAction("HomePage", "Products");
        }
    }
}