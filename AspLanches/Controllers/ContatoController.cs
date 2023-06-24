using Microsoft.AspNetCore.Mvc;

namespace AspLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
