using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Models;



namespace TPINCIWED.Controllers
{
  
    public class CourseController : Controller
    {

        public IActionResult Index()
        {
            var data = new Course();
            data.Id=11;
            data.Name = "Web Dynamique 2";
            return View(data);
        }

        public IActionResult details()
        {
            var data = new Course();
            data.Id = 11;
            data.Name = "Web Dynamique 2";

            ViewData["hello"] = "Hello Team";
            ViewData["data"] = data;
            return View();
        }


        public IActionResult info()
        {
            var data = new Course();
            data.Id = 11;
            data.Name = "Web Dynamique 2";

            ViewBag.hello = "Hello Team";
            ViewBag.data = data;
            return View();
        }
    }
}
