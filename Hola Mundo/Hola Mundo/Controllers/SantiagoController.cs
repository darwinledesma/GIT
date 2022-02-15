using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hola_Mundo.Controllers
{
    public class SantiagoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
