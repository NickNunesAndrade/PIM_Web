using Microsoft.AspNetCore.Mvc;

namespace PIM_4_Semestre.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
