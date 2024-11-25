using Microsoft.AspNetCore.Mvc;

namespace PIM_4_Semestre.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
