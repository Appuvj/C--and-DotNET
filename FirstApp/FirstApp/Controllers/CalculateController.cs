using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class CalculateController : Controller
    {

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Vijay";
            person.Basic_Salary = 100000;
            person.Age = 23;
        return View(person); 
        }


        public IActionResult Index()
        {
            ViewBag.Heading = "hello vijay...";
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

    }
}
