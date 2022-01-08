using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication9.Models;
using WebApplication9.Repository;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEmployeeRepository repository; 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            repository = new EmployeeRepository();
        }

        public ViewResult Index()
        {
            var employees =repository.GetAll();
            return View(employees);
        }

        public IActionResult Create(Employee employee)
        {
            repository.Create(employee);
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