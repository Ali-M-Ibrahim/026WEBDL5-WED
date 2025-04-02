using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Services;

namespace TPINCIWED.Controllers
{
    public class DIController : Controller
    {

        private readonly Logging logging;

        public DIController(Logging l)
        {
            
            logging = l;
        }


        public IActionResult f1()
        {
            logging.Log("This is my message from f1");
            return Ok("done");
        }


        public IActionResult f2() {

            logging.Log("this is my message from f2");
            return Ok("done 2");
        }


        public IActionResult f3( [FromServices] Logging methodlogging) {


            methodlogging.Log("message from method injection");
            return Ok("done 3");

        }
    }
}
