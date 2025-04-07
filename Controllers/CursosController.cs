using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
