using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Models;

namespace TPINCIWED.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index() // customer || customer/index
        {

            // Strongly typed data
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ali Ibrahim";
            customer.Balance = 10.0;
            // return View(customer);

            ViewData["greeting"] = "Hello class, I am ali ibrahim";
            ViewData["Morning"] = "Good Morning";
            ViewData["data"] = customer;



            ViewBag.greeting = "Hello Class from bag";
            ViewBag.data = customer;
            return View("Weak");
        }

            
        public IActionResult List()
        {
            var list = new List<Customer>();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ali Ibrahim";
            customer.Balance = 10.0;


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Joe Doe";
            customer2.Balance = 10.0;

            list.Add(customer);
            list.Add(customer2);

            return View(list);

        }


        public IActionResult List2()
        {
            var list = new List<Customer>();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ali Ibrahim";
            customer.Balance = 10.0;


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Joe Doe";
            customer2.Balance = 10.0;

            list.Add(customer);
            list.Add(customer2);

            return View(list);

        }

    }
}
