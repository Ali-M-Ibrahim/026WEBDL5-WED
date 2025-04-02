using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TPINCIWED.Data;
using TPINCIWED.Models;

namespace TPINCIWED.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext db)
        {
            _context = db;
        }


        public async Task<IActionResult> Index()
        {
            // SELECT * FROM ITEMS
            // var data = _context.Items.ToList();
            var data = await _context.Items.ToListAsync();
            // views/item/index.cshtml
            return View(data);
        }


        public async Task<IActionResult> Create()
        {
            return View();

        }

        public async Task<IActionResult> Store(Item item)
        {

             if(item.Price < 10)
            {
                ModelState.AddModelError("Price", "Price should be greater than 10");
            }

            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", item);
            }
         
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Item obj = await _context.Items.FindAsync(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Items.Remove(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
          
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Item obj = await _context.Items.FindAsync(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public async Task<IActionResult> Update(Item obj)
        {
            _context.Items.Update(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
