using Microsoft.AspNetCore.Mvc;

namespace TPINCIWED.Controllers
{
    public class CroissantController : Controller
    {
        public IActionResult Index()
        {
            return Ok("I am index in croissant controller");
        }

        [Route("newname")]
        public IActionResult Fork()
        {
            return Ok("i am fork function");
        }


        public IActionResult Test()
        {
            return Ok("i am test function");
        }
    }
}
