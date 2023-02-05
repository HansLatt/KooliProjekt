using KooliProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using KooliProjekt.Data;

namespace KooliProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Treeningpäevik()
        {
            return View();
        }

        public IActionResult KMI()
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult add()
        {
            decimal num1 = Convert.ToDecimal(HttpContext.Request.Form["txtFirst"].ToString());
            decimal num2 = Convert.ToDecimal(HttpContext.Request.Form["txtSecond"].ToString());
            decimal num3 = num2 * num2;
            decimal result = num1 / num3;
            ViewBag.SumResult = result.ToString();
            return View("KMI");
        }
    }
}