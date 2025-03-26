using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Data;
using TPINCIWED.Models;

namespace TPINCIWED.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext db)
        {
            _context = db;
        }



        //hit category/create
        //views/category/create.cshtml
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Category obj)
        {

            if (obj != null && obj.Name.Length < 3)
            {
                ModelState.AddModelError("Name", "The minimum length is 3");
            }

            if (ModelState.IsValid)
            {
                _context.Categories.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("index");
            }

            return View("Create", obj);

        }

        public IActionResult Index()
        {
            //select * from categories
            List<Category> data = _context.Categories.ToList();
            return View(data);
        }

        public IActionResult Details(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            //select * from categories where id=?
            Category? obj = _context.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            Category obj = _context.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }


        public IActionResult Update(Category obj) { 
        
            _context.Categories.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        
        }


        public IActionResult Delete(int id) { 
        
            Category ob = _context.Categories.Find(id);

            if (ob == null) {
                return NotFound();
            }

            _context.Categories.Remove(ob);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}