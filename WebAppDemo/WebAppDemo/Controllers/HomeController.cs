using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,CompanyContext cc)
        {
            _logger = logger;
            context = cc;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string CreateInformation()
        {
            var info = new Information()
            {
                Name = "Vijay",
                Licence = "abc123",
                Revenue = 10000,
                Established = Convert.ToDateTime("2024/08/01")
            };
            context.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();

            return "Added Successfully";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
