using Microsoft.AspNetCore.Mvc;

namespace TPINCIWED.Controllers
{
    [Route("mycontroller")]
    public class CakeController : Controller
    {

        [Route("")]
        public IActionResult Index() // cake || //cake/index
        {
            return Ok("Hello I am index function inside cake controller");
        }

        [Route("mydetails")]
        public IActionResult Details()
        {
            return Ok("i am details function");
        }

     
        public IActionResult More()
        {
            return Ok("i am more");
        }
    }
}
