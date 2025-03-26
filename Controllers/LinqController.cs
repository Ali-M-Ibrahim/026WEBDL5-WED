using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Data;

namespace TPINCIWED.Controllers
{
    public class LinqController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LinqController(ApplicationDbContext db)
        {
            _context = db;
        }
        public IActionResult Index()
        {
            // SELECT * FROM CATEGORIES WHERE PRICE > 1
            var data = from p in _context.Categories
                       where p.Price > 1
                       select p;
            var data2 = _context.Categories.Where(p => p.Price > 1);

            // SELECT * FROM CATEGORIES WHERE PRICE > 1 
            // AND NAME LIKE %Chocolate%
            var data3 = _context.Categories
                .Where(p => p.Price >= 1)
                .Where(p => p.Name.Contains("chocolate"));

            // SELECT NAME FROM CATEGORIES where price > 1;

            var data4 = _context.Categories.Where(p => p.Price > 1)
                 .Select(p => p.Name);

            // SELECT * FROM CATEGORIES ORDER BY PRICE asc;
            var data5 = _context.Categories.OrderBy(p => p.Price);


            // SELECT * FROM CATEGORIES ORDER BY PRICE desc;
            var data6 = _context.Categories.OrderByDescending(p => p.Price);

            // SELECT * FROM CATEGORIES WHERE NAME LIKE %Chocolate% ORDER BY PRICE ASC
            var data7 = _context.Categories
                .Where(p => p.Name.Contains("Chocolate"))
                .OrderBy(p => p.Price);

            // SELECT * FROM CATEGORIES WHERE PRICE > 1 LIMIT 1
            var data8 = _context.Categories
                .Where(p => p.Price > 1).First();


            // select * from categories where id =1
            var data9 = _context.Categories.Single(p => p.Id ==1);

            // select * from categories where price > 0 limit 2
            var data10 = _context.Categories
            .Where(p => p.Price > 0)
            .Take(2);

            var data11 = _context.Categories
             .Where(p => p.Price > 0)
                 .Skip(1)
                 .Take(2);
         

            var data12 = _context.Categories
                .GroupBy(p => p.Price);


            var haspricegt0 = _context.Categories.Any(p => p.Price > 100);

            var allgt100 = _context.Categories.All(p => p.Price > 100);

            var names = _context.Categories.Select(p => p.Name).Distinct(); ;

            var count = _context.Categories.Count();

            var maxPrice = _context.Categories.Max(p=>p.Price);

            var minPrice = _context.Categories.Min(p => p.Price);

            var sumPrices = _context.Categories.Sum(p => p.Price);

            return Ok(sumPrices);
        }
    }
}
