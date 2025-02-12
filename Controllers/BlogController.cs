using Microsoft.AspNetCore.Mvc;

namespace TPINCIWED.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() //maps to blog/index or /blog
        {
            return Ok("I am blog controller and i am  index function");
        }

        public IActionResult Create()
        {
            return Ok("I am blog controller and i am create function");
        }

        public IActionResult NF()
        {
            return NotFound();
        }

        public IActionResult BR()
        {
            return BadRequest("this is a bad request");
        }


        public IActionResult Sc()
        {
            return StatusCode(201);
        }

        public IActionResult Content()
        {
            return Content("this is my message");
        }

        public IActionResult Redirection()
        {
            return RedirectToAction("create");
        }

        public IActionResult Details(int id, string name)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok("The id is:" + id + " and the name is:"+ name);
        }

    }
}
