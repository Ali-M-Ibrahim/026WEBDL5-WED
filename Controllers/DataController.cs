using Microsoft.AspNetCore.Mvc;
using TPINCIWED.Models;

namespace TPINCIWED.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            Student obj = new Student();    
            obj.Id= 1;
            obj.Firstname = "Ali";
            obj.Lastname = "Ibrahim";

            Student obj2 = new Student()
            {
                Id = 2,
                Firstname = "Joe",
                Lastname = "DOe"
            };

            var ListStudent = new List<Student>();
            ListStudent.Add(obj);
            ListStudent.Add(obj2);
            return Ok(ListStudent);
        }
    }
}
