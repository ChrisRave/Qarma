using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetQarma.Controllers
{
    public class AccueilController : Controller
    {
        public IActionResult Charte()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
