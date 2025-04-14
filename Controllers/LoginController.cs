using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logar(LoginModel dados)
        {
            LoginModel model = new LoginModel();
            model.Login = "carlosalverto@gmail.com";
            model.Password = "Gotsavatantodevoce";
            return View(model);
        }
    }
}
