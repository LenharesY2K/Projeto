﻿using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class ProfessoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
