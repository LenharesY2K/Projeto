using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logar()
        {
            return View();
        }
    }
}
