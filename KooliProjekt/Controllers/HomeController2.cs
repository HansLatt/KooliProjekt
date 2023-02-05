using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
