using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjetoMVC.Controllers
{
    public class ExemploController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Exemplo2()
        {
            return View();
        }
    }
}