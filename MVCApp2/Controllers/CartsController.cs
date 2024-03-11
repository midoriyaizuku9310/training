using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp2.Models;

namespace MVCApp2.Controllers
{
    public class CartsController : Controller
    {
        private readonly StudentsContext _context;

        public CartsController(StudentsContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            string username = HttpContext.Session.GetString("Username");
            var l = await _context.Carts.ToListAsync();
            List<Cart> carts = new List<Cart>();
            var price = 0;
            var count = 0;
            foreach(var x in l)
            {
                if(x.UserName == username)
                {
                    carts.Add(x);
                    price += Convert.ToInt32(x.Price);
                    count++;
                }
            }
            ViewBag.price = price;
            ViewBag.count = count;  
            return View(carts);
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create1(int Id)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(cart);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(cart);
             var p = _context.Products.FirstOrDefaultAsync(m => m.Id == Id);
            List<Claim> claims = TempData["Username"] as List<Claim>;
            string username = claims.FirstOrDefault(c => c.Type == "Username")?.Value;
           
            //if (ModelState.IsValid)
            //{
            //    _context.Add(p);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(cart);
            return RedirectToAction("Home");

        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserName,Name,ProductId,Id,Price")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
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
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }

        public IActionResult payment()
        {
            return View();   
        }

        public IActionResult Success()
        {
            string username = HttpContext.Session.GetString("Username");
            //var entityToDelete = _context.Carts.FindAsync(username);

            //foreach(var x in entityToDelete) {
            //    if (x != null)
            //    {
            //        _context.Carts.Remove(x);
            //        _context.SaveChanges();
            //        // Handle any additional logic or redirect as needed
            //    }
            //}
            var rowsToDelete = _context.Carts.Where(c => c.UserName == username).ToList();
            _context.Carts.RemoveRange(rowsToDelete);
            _context.SaveChanges();


            return View();
        }
    }
}
