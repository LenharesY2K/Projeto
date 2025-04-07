using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class SalaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
