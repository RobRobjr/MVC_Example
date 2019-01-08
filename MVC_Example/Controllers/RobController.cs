using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Example.Controllers
{
    public class RobController : Controller
    {
        public IActionResult Bio()
        {
            return View();
        }
    }
}