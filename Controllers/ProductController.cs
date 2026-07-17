using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeneralStoreApp.Data;
using GeneralStoreApp.Models;

namespace GeneralStoreApp.Controllers
{
    public class ProductController : Controller
    {
        // This field holds our "connection" to the database.
        // 'readonly' means it can only be assigned once (in the constructor)
        // and never reassigned later — a good practice for dependencies.
        private readonly StoreDbContext _context;

        // Dependency Injection in action: ASP.NET Core automatically
        // creates and passes in a StoreDbContext here, using the
        // registration we set up in Program.cs (Step 11c).
        public ProductController(StoreDbContext context)
        {
            _context = context;
        }

        // ==================== INDEX ====================
        // URL: GET /Product or /Product/Index
        // PURPOSE: Show a list of ALL products.
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return View(products);
        }

        // ==================== DETAILS ====================
        // URL: GET /Product/Details/5
        // PURPOSE: Show full information about ONE product.
        public async Task<IActionResult> Details(int id)
        {
            Product? product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // ==================== CREATE (GET) ====================
        // URL: GET /Product/Create
        // PURPOSE: Show the EMPTY form to the user.
        public IActionResult Create()
        {
            return View();
        }

        // ==================== CREATE (POST) ====================
        // URL: POST /Product/Create
        // PURPOSE: Receive the SUBMITTED form data and save it.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // If validation failed, redisplay the form WITH the user's
            // entered data and WITH the error messages attached.
            return View(product);
        }

        // ==================== EDIT (GET) ====================
        // URL: GET /Product/Edit/5
        // PURPOSE: Show the form PRE-FILLED with the existing product's data.
        public async Task<IActionResult> Edit(int id)
        {
            Product? product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // ==================== EDIT (POST) ====================
        // URL: POST /Product/Edit/5
        // PURPOSE: Receive the UPDATED form data and save changes.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // ==================== DELETE (GET) ====================
        // URL: GET /Product/Delete/5
        // PURPOSE: Show a CONFIRMATION page before actually deleting.
        public async Task<IActionResult> Delete(int id)
        {
            Product? product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);        }

        // ==================== DELETE (POST) ====================
        // URL: POST /Product/Delete/5
        // PURPOSE: Actually remove the product from the database.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Product? product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}