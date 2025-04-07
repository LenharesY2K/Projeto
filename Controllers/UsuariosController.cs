using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
