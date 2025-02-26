using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Data;
using TPINCIWED.Models;

namespace TPINCIWED.Controllers
{
    public class TeacherController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext _db)
        {
            _context= _db;
        }

        public IActionResult Index()
        {
            //select * from teachers;
            List<Teacher> list = _context.Teachers.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Teacher obj)
        {
            _context.Teachers.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
