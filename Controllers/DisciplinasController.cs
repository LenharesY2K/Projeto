using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class DisciplinasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
